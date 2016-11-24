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
    class ImageDisparity: ProcessingStep 
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

        public void run(Mat data, Mat reference, out Mat disparity)
        {
            this.dataImage = data;
            this.referenceImage = reference;
            disparity = calculateDisparity();
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

        public List<MaxElement> getStrongMaximums(Mat matchResult, int count = 0) {
            List<MaxElement> maxLocs = new List<MaxElement>();

            using (Mat binary = new Mat())
            {
                matchResult.CopyTo(binary);
                Point[] minLoc = new Point[1];
                Point[] maxLocc = new Point[1];
                double[] minValue = new double[1];
                double[] maxValuee = new double[1];

                matchResult.MinMax(out minValue, out maxValuee, out minLoc, out maxLocc);

                CvInvoke.Threshold(matchResult, binary, 0.7 * maxValuee[0], 1, ThresholdType.ToZero);
                float[] binaryData = new float[binary.Width];

                binary.CopyTo(binaryData);
                float maxValue = 0;
                int maxLoc = 0;
                bool inReagion = false;
                for (int i = 0; i < binary.Width; i++)
                {
                    if (inReagion)
                    {
                        if (binaryData[i] > 0)
                        {
                            if (binaryData[i] > maxValue)
                            {
                                maxValue = binaryData[i];
                                binaryData[maxLoc] = 0;
                                maxLoc = i;
                            }
                            else
                            {
                                binaryData[i] = 0;
                            }
                        }
                        else
                        {
                            inReagion = false;
                            maxLocs.Add(new MaxElement(maxLoc, maxValue));
                        }
                    }
                    else if (binaryData[i] > 0)
                    {
                        maxLoc = i;
                        maxValue = binaryData[i];
                        inReagion = true;
                    }
                }
                if (maxLocs.Count == 0)
                    maxLocs.Add(new MaxElement(maxLoc, maxValue));
            }

            maxLocs.Sort(MaxElement.sortByValue);
            return maxLocs;
        }

        private Mat calculateDisparity()
        {
            matchResultContainer = new MatchResultContainer(dataImage.Height - sampleArea.Height, dataImage.Width - sampleArea.Width);
            matchResultContainer.BlockWidth = 16;
            int progressStep = 100 / (dataImage.Height / 20);

            int[] result = new int[dataImage.Width * dataImage.Height];
            Parallel.For(0, threads, submat =>
              {
                  int startRow = submat * (dataImage.Rows / threads);
                  int endRow;
                  if( (submat + 1) * (dataImage.Rows / threads) > (dataImage.Rows - sampleArea.Height))
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
                              if (true)
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
                              else
                              {
                                  matchResultContainer[y, x] = getStrongMaximums(matchResult);
                                  foreach (MaxElement item in matchResultContainer[y,x])
                                  {
                                      item.disparity = item.location - (x - window.Left);
                                  }
                                  result[y * dataImage.Width + x] = matchResultContainer[y,x][0].disparity;
                              }
                          }
                      }
                      if((y % 20) == 0)
                      {
                          PercentComplete += progressStep;
                          if (bw != null)
                              bw.ReportProgress(PercentComplete);
                      }
                  }
              });
            /*for(int y = 0; y < matchResultContainer.Height; y++)
            {
                for(int x = 0; x < matchResultContainer.Width; x += 16)
                {
                    int[] disp = improveMatchQuality(y, x);
                    disp.CopyTo(result, y * dataImage.Width + x);
                }
            }*/
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
    }
}
