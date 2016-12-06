using DepthCalc.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using Emgu.CV.Util;

namespace DepthCalc.Processing.Postprocessing
{
    class DrawMatchMap : ProcessingStep
    {
        private Size canvasSize;

        public Size CanvasSize
        {
            get
            {
                return canvasSize;
            }

            set
            {
                canvasSize = value;
            }
        }

        public Image<Rgb, byte> visualiseMatchMap(int[] peaks, bool min = false)
        {
            Image<Rgb, byte> outImage = new Image<Rgb, byte>(dataImage.Width, canvasSize.Height);
            outImage.SetValue(new Rgb(255, 255, 255));

            Point[] minLoc = new Point[1];
            Point[] maxLoc = new Point[1];
            double[] minValue = new double[1];
            double[] maxValue = new double[1];

            dataImage.MinMax(out minValue, out maxValue, out minLoc, out maxLoc);

            float step = (float) (maxValue[0]) / canvasSize.Height;

            int maxIndex = 0;
            Array.Sort(peaks);
            byte r = 0, b = 0, g = 0;
            for (int x=0; x < outImage.Width; x++)
            {
                if ((maxIndex < peaks.Length) && (x == peaks[maxIndex]))
                {
                    r = 0;
                    b = 0;
                    maxIndex++;
                }
                else
                {
                    r = 255;
                    b = 0;
                }
                int y = (int)((float)dataImage.ToImage<Gray, float>().Data[0, x, 0] / step);
                for( ; y > 0; y--)
                {
                    outImage.Data[(canvasSize.Height - y), x, 0] = r;
                    outImage.Data[(canvasSize.Height - y), x, 1] = g;
                    outImage.Data[(canvasSize.Height - y), x, 2] = b;
                }
            }
            Point top, bottom;
            if (min)
            {
                top = new Point(minLoc[0].X, 0);
                bottom = new Point(minLoc[0].X, canvasSize.Height - 1);
            }
            else
            {
                top = new Point(maxLoc[0].X, 0);
                bottom = new Point(maxLoc[0].X, canvasSize.Height - 1);
            }

            outImage.Draw(new LineSegment2D(top, bottom), new Rgb(0, 0, 255), 1);
            outImage = outImage.Resize(canvasSize.Width, canvasSize.Height, Emgu.CV.CvEnum.Inter.Nearest);

            return outImage;
        }

        public override Mat doYourJob()
        {
            throw new NotImplementedException();
        }
    }
}
