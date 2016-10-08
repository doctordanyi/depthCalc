using System;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Threading.Tasks;

namespace depthCalc
{
    class DepthProcessor
    {
        private Mat reference;
        private Mat data;

        public TemplateMatchingType matchMethod;

        private const UInt16 SampleRows = 7;
        private const UInt16 SampleCols = 7;
        private const int threads = 8;

        private Image<Gray, double> variance;

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

            using (Mat dataROI = new Mat(data,new Rectangle(windowX, windowY, WindowCols, WindowRows)))
            using (Mat sampleROI = new Mat(reference, new Rectangle(x, y, SampleCols, SampleRows)))
            {
                CvInvoke.MatchTemplate(dataROI, sampleROI, matchResult, matchMethod);
            }

            return matchResult;
        }

        private Mat calculateDisparity()
        {
            Int16[] result = new short[data.Width * data.Height];
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
                          using (Mat matchResult = blockMatch(x, y))
                          {
                              Point[] minLoc = new Point[1];
                              Point[] maxLoc = new Point[1];
                              double[] minValue = new double[1];
                              double[] maxValue = new double[1];

                              matchResult.MinMax(out minValue, out maxValue, out minLoc, out maxLoc);

                              windowX = (x <= WindowCols / 2) ? 0 : x - WindowCols / 2;
                              windowX = (windowX >= (data.Cols - WindowCols)) ? data.Cols - WindowCols : windowX;
                              windowY = y;

                              if ((matchMethod == TemplateMatchingType.Sqdiff) || (matchMethod == TemplateMatchingType.SqdiffNormed))
                              {
                                  result[y * data.Width + x] = (short)((minLoc[0].X - (x - windowX)));
                              }
                              else
                              {
                                  result[y * data.Width + x] = (short)((maxLoc[0].X - (x - windowX)));
                              }
                          }
                      }
                  }
              });
            Mat retval = new Mat(data.Size, DepthType.Cv16S, 1);
            retval.SetTo<short>(result);
            return retval;
        }
    }
}
