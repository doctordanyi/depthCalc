using System;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Threading.Tasks;

namespace depthCalc
{
    class depthProcessor
    {
        public Image<Gray,Byte> reference;
        public Image<Gray, Byte> data;
        public Image<Gray, Int32> result;

        public TemplateMatchingType matchMethod;

        private const UInt16 SampleRows = 7;
        private const UInt16 SampleCols = 7;

        private Image<Gray, double> variance;

        private const UInt16 WindowRows = SampleRows;
        private const UInt16 WindowCols = 100;


        public depthProcessor(Image<Gray,Byte> reference, Image<Gray,Byte> data)
        {
            this.reference = reference;
            this.data = data;

            result = new Image<Gray, Int32>(data.Cols, data.Rows);
            variance = new Image<Gray, double>(data.Cols, data.Rows);
        }

        public void calculate_variance()
        {
            Gray avg;
            MCvScalar sdv;
            for (int y = SampleRows; y < (result.Rows - SampleRows); y++)
            {
                for (int x = SampleCols; x < (result.Cols - SampleCols); x++)
                {
                    Image<Gray, Byte> sampleROI = reference.GetSubRect((new Rectangle(x-SampleCols, y-SampleRows, SampleCols, SampleRows)));
                    sampleROI.AvgSdv(out avg, out sdv);
                    variance.Data[y, x, 0] = sdv.V0 * sdv.V0;
                }
            }
        }

        public Image<Gray,float> blockMatch(int x,int y)
        {
            int windowX, windowY;
            Image<Gray, float> matchResult;

            windowX = (x <= WindowCols / 2) ? 0 : x - WindowCols / 2;
            windowX = (windowX >= (data.Cols - WindowCols)) ? data.Cols - WindowCols : windowX;
            windowY = y;

            using (Image<Gray, Byte> dataROI = data.GetSubRect(new Rectangle(windowX, windowY, WindowCols, WindowRows)))
            using (Image<Gray, Byte> sampleROI = reference.GetSubRect((new Rectangle(x, y, SampleCols, SampleRows))))
            {
                matchResult = dataROI.MatchTemplate(sampleROI, matchMethod);
            }

            return matchResult;
        }

        public void calculate_displacement()
        {
            Parallel.For(0, 8, submat =>
              {
                  int startRow = submat * (data.Rows / 8);
                  int endRow;
                  if( (submat + 1) * (data.Rows / 8) > (data.Rows - SampleRows))
                  {
                      endRow = data.Rows - SampleRows;
                  }
                  else
                  {
                      endRow = (submat + 1) * (data.Rows / 8);
                  }
                  for (int y = startRow; y < endRow; y++)
                  {
                      for (int x = 0; x < (data.Cols - SampleCols); x++)
                      {
                          using (Image<Gray, float> matchResult = blockMatch(x, y))
                          {
                              Point[] minLoc = new Point[1];
                              Point[] maxLoc = new Point[1];
                              double[] minValue = new double[1];
                              double[] maxValue = new double[1];

                              matchResult.MinMax(out minValue, out maxValue, out minLoc, out maxLoc);

                              if ((matchMethod == TemplateMatchingType.Sqdiff) || (matchMethod == TemplateMatchingType.SqdiffNormed))
                              {
                                  result.Data[y, x, 0] = minLoc[0].X - WindowCols / 2;
                              }
                              else
                              {
                                  result.Data[y, x, 0] = maxLoc[0].X - WindowCols / 2;
                              }
                          }
                      }
                  }
              });
        }

        public void medianFilter()
        {
            result = result.SmoothMedian(5);
        }

    }
}
