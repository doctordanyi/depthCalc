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
        private MatchResultContainer matchResultContainer;

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

        public int[] improveMatchQuality(int y, int x, Util.MatchResultContainer.BlockPinType blockPinType = Util.MatchResultContainer.BlockPinType.PinToLeftEdge)
        {
            int[] disparities = new int[matchResultContainer.BlockWidth];
            int blockBase = matchResultContainer.getBlockBaseIndex(x, blockPinType);
            for (int i = 0; i < matchResultContainer.BlockWidth; i++)
                disparities[i] = matchResultContainer[y, blockBase + i][0].disparity;
            double avg = disparities.Average();

            double[] error = new double[matchResultContainer.BlockWidth];
            for (int i = 0; i < matchResultContainer.BlockWidth; i++)
                error[i] = (disparities[i]-avg) * (disparities[i]-avg);

            for(int iterations = 3; iterations > 0; iterations--)
            {
                double maxError = error.Max();
                double avgError = error.Average();
                for (int i = 0; i < matchResultContainer.BlockWidth; i++)
                {
                    if( (maxError > avgError*2) && (error[i] == maxError))
                    {
                        foreach (MaxElement item in matchResultContainer[y, blockBase+i])
                        {
                            if( ((item.disparity-avg) * (item.disparity-avg)) < error[i])
                            {
                                error[i] = ((item.disparity - avg) * (item.disparity - avg));
                                disparities[i] = item.disparity;
                                avg = disparities.Average();
                            }
                        }
                    }
                }
                for (int j = 0; j < matchResultContainer.BlockWidth; j++)
                    error[j] = (disparities[j] - avg) * (disparities[j] - avg);
            }

            return disparities;
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
