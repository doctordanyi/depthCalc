using System;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Collections.Generic;
using depthCalc.Util;

namespace depthCalc
{
    class Visualiser
    {
        public Image<Gray, Int32> source;
        public Image<Bgr, Byte> outImage;

        int matchResultWindowHeight = 40;

        static double interpolate(double val, double y0, double x0, double y1, double x1)
        {
            return (val - x0) * (y1 - y0) / (x1 - x0) + y0;
        }

        static double interpolate2(double val)
        {
            if (val <= -0.75) return 0;
            else if (val <= -0.25) return interpolate(val, 0.0, -0.75, 1.0, -0.25);
            else if (val <= 0.25) return 1.0;
            else if (val <= 0.75) return interpolate(val, 1.0, 0.25, 0.0, 0.75);
            else return 0.0;
        }

        static double red(double gray)
        {
            return interpolate2(gray - 0.5);
        }
        static double green(double gray)
        {
            return interpolate2(gray);//+0
        }
        static double blue(double gray)
        {
            return interpolate2(gray + 0.5);//0.5
        }

        public static UInt32 RGBFromValue(double val, double min, double max)
        {
            double d = (val - min) / (max - min) * 2 - 1;

            double r = red(d) * 255;
            double g = green(d) * 255;
            double b = blue(d) * 255;
            if (r < 0) r = 0; if (r > 255) r = 255;
            if (g < 0) g = 0; if (g > 255) g = 255;
            if (b < 0) b = 0; if (b > 255) b = 255;

            return 0xff000000U | ((UInt32)r) << 16 | ((UInt32)g) << 8 | ((UInt32)b);
        }

        public void medianFilter(int iteration)
        {
            for(int i=0;i<iteration;i++)
                outImage = outImage.SmoothMedian(5);
            outImage = outImage.Dilate(1);
        }

        public void drawOutputImage(out Mat outMat)
        {
            outImage = new Image<Bgr, byte>(source.Width, source.Height);
            Gray avg;
            MCvScalar sdv;
            UInt32 RGB;
            source.AvgSdv(out avg, out sdv);
            for (int x = 0; x < source.Width; x++)
            {
                for(int y = 0; y < source.Height; y++)
                {
                    RGB = RGBFromValue(source.Data[y, x, 0],-40, 40);
                    outImage.Data[y, x, 0] = (Byte)RGB;
                    outImage.Data[y, x, 1] = (Byte)(RGB >> 8);
                    outImage.Data[y, x, 2] = (Byte)(RGB >> 16);
                }
            }
            outMat = outImage.Mat;
        }

        public Image<Rgb, byte> visualiseMatchMap(Mat matchResult, List<MaxElement> maxLocs, bool min = false)
        {
            Image<Rgb, byte> outImage = new Image<Rgb, byte>(matchResult.Width, matchResultWindowHeight);
            outImage.SetValue(new Rgb(255, 255, 255));

            Point[] minLoc = new Point[1];
            Point[] maxLoc = new Point[1];
            double[] minValue = new double[1];
            double[] maxValue = new double[1];

            matchResult.MinMax(out minValue, out maxValue, out minLoc, out maxLoc);

            float step = (float) (maxValue[0]) / matchResultWindowHeight;

            for (int x=0; x < outImage.Width; x++)
            {
                int y = (int)((float)matchResult.ToImage<Gray, float>().Data[0, x, 0] / step);
                for( ; y > 0; y--)
                {
                    outImage.Data[(matchResultWindowHeight - y), x, 0] = 255;
                    outImage.Data[(matchResultWindowHeight - y), x, 1] = 0;
                    outImage.Data[(matchResultWindowHeight - y), x, 2] = 0;
                }
            }
            Point top, bottom;
            for (int i = 0; i < maxLocs.Count; i++)
            {
                top = new Point(maxLocs[i].location, 0);
                bottom = new Point(maxLocs[i].location, matchResultWindowHeight - 1);

                if (i == 0)
                {
                    outImage.Draw(new LineSegment2D(top, bottom), new Rgb(0, 0, 255), 1);
                }
                else if (i == (maxLocs.Count - 1))
                {
                    outImage.Draw(new LineSegment2D(top, bottom), new Rgb(0, 128, 0), 1);
                }
                else
                {
                    outImage.Draw(new LineSegment2D(top, bottom), new Rgb(0, 0, 0), 1);
                }
            }

            outImage = outImage.Resize(200, 40, Emgu.CV.CvEnum.Inter.Nearest);

            return outImage;
        }

    }
}
