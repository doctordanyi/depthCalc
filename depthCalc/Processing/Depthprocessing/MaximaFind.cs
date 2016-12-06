using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using System.Drawing;
using DepthCalc.Util;

namespace DepthCalc.Processing.Depthprocessing
{
    class MaximaFind : ProcessingStep
    {
        public TemplateMatchingType matchMethod;

        private Rectangle sampleArea;
        private Rectangle windowArea;
        private const UInt16 linearMatchRange = 16;
        private const int threads = 8;
        private int maxCount = 5;

        public MaximaFind(DepthprocessingConfig config)
        {
            stepType = SupportedSteps.FindFirstKMax;
            matchMethod = config.MatchMethod;

            sampleArea = config.SampleArea;
            windowArea = config.WindowArea;
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
                for (int i = allPeaks.Size; i < maxCount; i++)
                {
                    peaks[i] = new MaxElement(peaks[0].location, peaks[0].value);
                }
            }
            return peaks;
        }

        public int[] getPeaks(Mat matchMat)
        {
            VectorOfPoint peaks = findPeaks(matchMat, new Size(5, 1));
            int[] intPeaks = new int[peaks.Size];
            for (int i = 0; i < intPeaks.Length; i++)
            {
                intPeaks[i] = peaks[i].X;
            }
            return intPeaks;
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

        public override Mat doYourJob()
        {
            outBuffer = new Mat(dataImage.Size, DepthType.Cv32S, maxCount);
            int[] result = new int[dataImage.Width * dataImage.Height * maxCount];
            int[] peaks;
            WindowSelector windowSelector = new WindowSelector(dataImage);
            windowSelector.WindowArea = windowArea;
            for (int y = 0; y < (dataImage.Height - sampleArea.Height); y++)
            {
                for (int x = 0; x < (dataImage.Width - sampleArea.Width); x++)
                {
                    Rectangle window = windowSelector.getWindow(x, y);
                    using (Mat matchResult = blockMatch(x, y))
                    {
                        peaks = getDominantPeaks(matchResult);
                        for (int i = 0; i < maxCount; i++)
                        {
                            peaks[i] = peaks[i] - (x - window.Left);
                        }
                        peaks.CopyTo(result, (y * dataImage.Width + x) * maxCount);
                    }
                }
            }
            outBuffer.SetTo<int>(result);
            return outBuffer;
        }
    }
}
