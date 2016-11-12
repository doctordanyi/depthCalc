using System;
using System.Linq;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;
using depthCalc.Util;

namespace depthCalc
{
    class DepthProcessor
    {
        private Mat reference;
        private Mat data;
        private MatchResultContainer matchResultContainer;

        public TemplateMatchingType matchMethod;

        private const UInt16 SampleRows = 7;
        private const UInt16 SampleCols = 7;
        private const UInt16 linearMatchRange = 16;
        private const int threads = 8;

        private const UInt16 WindowRows = SampleRows;
        private UInt16 WindowCols = 100;


        public DepthProcessor()
        {
            matchMethod = TemplateMatchingType.CcoeffNormed;
        }

        public void run(Mat data, Mat reference, out Mat disparity)
        {
            this.data = data;
            this.reference = reference;
            disparity = calculateDisparity();
        }

        public Mat blockMatch(int x,int y)
        {
            int windowX, windowY;
            Mat matchResult = new Mat(); ;

            windowX = (x <= WindowCols / 2) ? 0 : x - WindowCols / 2;
            windowX = (windowX >= (data.Cols - WindowCols)) ? data.Cols - WindowCols : windowX;
            windowY = y;

            using (Mat dataROI = new Mat(data, new Rectangle(windowX, windowY, WindowCols, WindowRows)))
            using (Mat sampleROI = new Mat(reference, new Rectangle(x, y, SampleCols, SampleRows)))
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
            matchResultContainer = new MatchResultContainer(data.Height - SampleRows, data.Width - SampleCols);
            matchResultContainer.BlockWidth = 16;

            int[] result = new int[data.Width * data.Height];
            Parallel.For(0, threads, submat =>
              {
                  int windowX, windowY;
                  int startRow = submat * (data.Rows / threads);
                  int endRow;
                  if( (submat + 1) * (data.Rows / threads) > (data.Rows - SampleRows))
                  {
                      endRow = data.Rows - SampleRows;
                  }
                  else
                  {
                      endRow = (submat + 1) * (data.Rows / threads);
                  }

                  for (int y = startRow; y < endRow; y++)
                  {
                      for (int x = 0; x < (data.Cols - SampleCols); x++)
                      {
                          windowX = (x <= WindowCols / 2) ? 0 : x - WindowCols / 2;
                          windowX = (windowX >= (data.Cols - WindowCols)) ? data.Cols - WindowCols : windowX;
                          windowY = y;

                          using (Mat matchResult = blockMatch(x, y))
                          {
                              if ((matchMethod == TemplateMatchingType.Sqdiff) || (matchMethod == TemplateMatchingType.SqdiffNormed))
                              {
                                  Point[] minLoc = new Point[1];
                                  Point[] maxLoc = new Point[1];
                                  double[] minValue = new double[1];
                                  double[] maxValue = new double[1];

                                  matchResult.MinMax(out minValue, out maxValue, out minLoc, out maxLoc);

                                  if ((matchMethod == TemplateMatchingType.Sqdiff) || (matchMethod == TemplateMatchingType.SqdiffNormed))
                                  {
                                      result[y * data.Width + x] = (int)((minLoc[0].X - (x - windowX)));
                                  }
                              }
                              else
                              {
                                  matchResultContainer[y, x] = getStrongMaximums(matchResult);
                                  foreach (MaxElement item in matchResultContainer[y,x])
                                  {
                                      item.disparity = item.location - (x - windowX);
                                  }
                                  result[y * data.Width + x] = matchResultContainer[y,x][0].disparity;
                              }
                          }
                      }
                  }
              });
            for(int y = 0; y < matchResultContainer.Height; y++)
            {
                for(int x = 0; x < matchResultContainer.Width; x += 16)
                {
                    int[] disp = improveMatchQuality(y, x);
                    disp.CopyTo(result, y * data.Width + x);
                }
            }
            Mat retval = new Mat(data.Size, DepthType.Cv32S, 1);
            retval.SetTo<int>(result);
            return retval;
        }
    }
}
