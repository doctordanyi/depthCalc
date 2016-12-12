using DepthCalc.Processing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using DepthCalc.Util;
using System.Drawing;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace DepthCalc.Processing.Depthprocessing
{
    class CumulateClustering : ProcessingStep
    {

        public TemplateMatchingType matchMethod;
        private Rectangle sampleArea;
        private Rectangle windowArea;
        private Rectangle blockArea;
        private const int blockSize = 16;
        private const int threads = 1;
        private int maxCount = 5;

        public CumulateClustering()
        {
            stepType = SupportedSteps.CumulateClustering;
            matchMethod = TemplateMatchingType.CcoeffNormed;

            sampleArea = new Rectangle(0, 0, 7, 7);
            windowArea = new Rectangle(0, 0, 100, sampleArea.Height);
            blockArea = new Rectangle(0, 0, blockSize, 1);
        }

        public CumulateClustering(DepthprocessingConfig config)
        {
            stepType = SupportedSteps.CumulateClustering;
            matchMethod = config.MatchMethod;

            sampleArea = config.SampleArea;
            windowArea = config.WindowArea;
            blockArea = new Rectangle(0, 0, blockSize, 1);
        }

        public Mat blockMatch(int x,int y)
        {
            Mat matchResult = new Mat();
            WindowSelector windowSelector = new WindowSelector(dataImage);
            windowSelector.WindowArea = windowArea;
            Rectangle window = windowSelector.getWindow(x, y);
            windowSelector.WindowArea = sampleArea;
            Rectangle sample = windowSelector.getWindow(x, y);

            using (Mat dataROI = new Mat(dataImage, window))
            using (Mat sampleROI = new Mat(referenceImage, sample))
            {
                CvInvoke.MatchTemplate(dataROI, sampleROI, matchResult, matchMethod);
            }
            return matchResult;
        }

        private void nonMaximaSuppression(Mat src, ref Mat mask, bool remove_plateaus)
        {
            // find pixels that are equal to the local neighborhood not maximum (including 'plateaus')
            Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 1), new Point(-1, -1));
            CvInvoke.Dilate(src, mask, element, new Point(-1, -1), 1, BorderType.Reflect, new Emgu.CV.Structure.MCvScalar());
            CvInvoke.Compare(src, mask, mask, CmpType.GreaterEqual);
            // optionally filter out pixels that are equal to the local minimum ('plateaus')
            if (remove_plateaus) {
                Mat non_plateau_mask = new Mat();
                element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 1), new Point(-1, -1));
                CvInvoke.Erode(src, non_plateau_mask, element, new Point(-1, -1), 1, BorderType.Reflect, new Emgu.CV.Structure.MCvScalar());
                CvInvoke.Compare(src, non_plateau_mask, non_plateau_mask, CmpType.GreaterThan);
                CvInvoke.BitwiseAnd(mask, non_plateau_mask, mask);
            }
        }

        private VectorOfPoint findPeaks(Mat _src, Size ksize, float scale = 0.2f, bool remove_plateus = true)
        {
            // find the min and max values of the hist image
            double minVal = 0, maxVal = 0;
            Point minLoc = new Point(), maxLoc = new Point();
            CvInvoke.MinMaxLoc(_src, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

            Mat mask = new Mat();
            CvInvoke.GaussianBlur(_src, _src, ksize, 0);
            nonMaximaSuppression(_src, ref mask, remove_plateus);

            VectorOfPoint maxima = new VectorOfPoint();   // output, locations of non-zero pixels
            CvInvoke.FindNonZero(mask, maxima);

            return maxima;
        }

        private MaxElement[] findDominantPeaks(Mat _src)
        {
            VectorOfPoint allPeaks = findPeaks(_src, new Size(5, 1));
            MaxElement[] peaks = new MaxElement[allPeaks.Size];
            float[] matchValues = new float[_src.Width];
            _src.CopyTo(matchValues);

            for (int i = 0; i < allPeaks.Size; i++)
            {
                peaks[i] = new MaxElement(allPeaks[i].X, matchValues[allPeaks[i].X]);
            }
            Array.Sort(peaks);

            if (peaks.Length > maxCount)
            {
                Array.Resize(ref peaks, maxCount);
            }
            else if (peaks.Length < maxCount)
            {
                Array.Resize(ref peaks, maxCount);
                if (peaks[0] == null)
                {
                    peaks[0] = new MaxElement(0, 0f);
                }
                for (int i = allPeaks.Size; i < maxCount; i++)
                {
                    peaks[i] = new MaxElement(peaks[0].location, peaks[0].value);
                }
            }
            return peaks;
        }

        public int[] getDominantPeaks(Mat matchMat)
        {
            MaxElement[] peaks = findDominantPeaks(matchMat);
            int[] intPeaks = new int[peaks.Length];
            for (int i = 0; i < intPeaks.Length; i++)
            {
                intPeaks[i] = peaks[i].location;
            }
            return intPeaks;
        }

        int[] processBlock(Rectangle block)
        {
            int[] max = new int[blockSize];
            VectorOfMat matchResults = new VectorOfMat();
            Mat cumulativeMatch = new Mat(1,94, DepthType.Cv32F, 1);
            for (int x = 0; x < block.Width; x++)
            {
                matchResults.Push(blockMatch(block.X + x, block.Y));
                CvInvoke.Accumulate(matchResults[x], cumulativeMatch);
            }

            int[] clusterCenters = getDominantPeaks(cumulativeMatch);
            
            return max;
        }

        public Mat getCumulativeMatch(Rectangle block)
        {
            VectorOfMat matchResults = new VectorOfMat();
            Mat cumulativeMatch = new Mat(1,94, DepthType.Cv32F, 1);
            for (int x = 0; x < block.Width; x++)
            {
                matchResults.Push(blockMatch(block.X + x, block.Y));
                CvInvoke.Accumulate(matchResults[x], cumulativeMatch);
            }
            
            return cumulativeMatch;
        }

        public override Mat doYourJob()
        {
            outBuffer = new Mat(dataImage.Size, Emgu.CV.CvEnum.DepthType.Cv32S, 1);
            int[] result = new int[dataImage.Width * dataImage.Height];
            Parallel.For(0, threads, submat =>
              {
                  int startRow = submat * (dataImage.Rows / threads);
                  int endRow;
                  if ((submat + 1) * (dataImage.Rows / threads) > dataImage.Rows)
                  {
                      endRow = dataImage.Rows;
                  }
                  else
                  {
                      endRow = (submat + 1) * (dataImage.Rows / threads);
                  }
                  WindowSelector windowSelector = new WindowSelector(dataImage);
                  windowSelector.WindowArea = blockArea;
                  int[] selectedMax;
                  for (int y = startRow; y < endRow; y++)
                  {
                      for (int x = 0; x < dataImage.Width; x++)
                      {
                          Rectangle window = windowSelector.getWindow(x, y);
                          selectedMax = processBlock(window);
                          selectedMax.CopyTo(result, (y * dataImage.Width + window.X));
                      }
                  }
              });
            outBuffer.SetTo<int>(result);
            return outBuffer;
        }
    }
}
