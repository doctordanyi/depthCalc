using System;
using System.Linq;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;
using DepthCalc.Util;

namespace DepthCalc.Processing.Depthprocessing
{
    class ImageDisparity: ProcessingStep, IDisposable
    {
        public TemplateMatchingType matchMethod;
        private Rectangle sampleArea;
        private Rectangle windowArea;
        private const UInt16 linearMatchRange = 16;
        private const int threads = 8;

        public ImageDisparity()
        {
            stepType = SupportedSteps.ImageDisparity;
            matchMethod = TemplateMatchingType.CcoeffNormed;

            sampleArea = new Rectangle(0, 0, 7, 7);
            windowArea = new Rectangle(0, 0, 100, sampleArea.Height);
        }

        public ImageDisparity(DepthprocessingConfig config)
        {
            stepType = SupportedSteps.ImageDisparity;
            matchMethod = config.MatchMethod;

            sampleArea = config.SampleArea;
            windowArea = config.WindowArea;
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

        private Mat calculateDisparity()
        {
            int progressStep = 100 / (dataImage.Height / 20);

            int[] result = new int[dataImage.Width * dataImage.Height];
            Parallel.For(0, threads, submat =>
              {
                  int startRow = submat * (dataImage.Rows / threads);
                  int endRow;
                  if ((submat + 1) * (dataImage.Rows / threads) > (dataImage.Rows - sampleArea.Height))
                  {
                      endRow = dataImage.Rows - sampleArea.Height;
                  }
                  else
                  {
                      endRow = (submat + 1) * (dataImage.Rows / threads);
                  }
                  WindowSelector windowSelector = new WindowSelector(dataImage);
                  windowSelector.WindowArea = windowArea;
                  for (int y = startRow; y < endRow; y++)
                  {
                      for (int x = 0; x < (dataImage.Cols - sampleArea.Width); x++)
                      {
                          Rectangle window = windowSelector.getWindow(x, y);
                          using (Mat matchResult = blockMatch(x, y))
                          {
                              Point[] minLoc = new Point[1];
                              Point[] maxLoc = new Point[1];
                              double[] minValue = new double[1];
                              double[] maxValue = new double[1];

                              matchResult.MinMax(out minValue, out maxValue, out minLoc, out maxLoc);

                              if ((matchMethod == TemplateMatchingType.Sqdiff) || (matchMethod == TemplateMatchingType.SqdiffNormed))
                              {
                                  result[y * dataImage.Width + x] = (int)((minLoc[0].X - (x - window.Left)));
                              }
                              else
                              {
                                  result[y * dataImage.Width + x] = (int)((maxLoc[0].X - (x - window.Left)));
                              }
                          }
                      }
                      /*if ((y % 20) == 0)
                      {
                          PercentComplete += progressStep;
                          if (bw != null)
                              bw.ReportProgress(PercentComplete);
                      }*/
                  }
              });
            Mat retval = new Mat(dataImage.Size, DepthType.Cv32S, 1);
            retval.SetTo<int>(result);
            return retval;
        }

        public override Mat doYourJob()
        {
            outBuffer = new Mat();
            outBuffer = calculateDisparity();
            return outBuffer;
        }

        public override string ToString()
        {
            string readable = base.ToString();
            readable += ", Parameters: {";
            readable += "'match method': " + matchMethod.ToString() + ", ";
            readable += "'window size': " + windowArea.Width + "x" + windowArea.Height + ", ";
            readable += "'sample size': " + sampleArea.Width + "x" + sampleArea.Height + "}";
            return readable;
        }
    }
}
