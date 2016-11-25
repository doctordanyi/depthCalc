using DepthCalc.Processing;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Processing.Postprocessing
{
    class VisualizeDisparity: ProcessingStep
    {
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

        private static UInt32 RGBFromValue(double val, double min, double max)
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

        private Mat drawOutputImage()
        {
            Image<Rgb, byte> outImage = new Image<Rgb, byte>(dataImage.Width, dataImage.Height);
            Image<Gray, int> source = dataImage.ToImage<Gray, int>();
            
            UInt32 RGB;
            for (int x = 0; x < dataImage.Width; x++)
            {
                for(int y = 0; y < dataImage.Height; y++)
                {
                    RGB = RGBFromValue(source.Data[y, x, 0],-50, 50);
                    outImage.Data[y, x, 0] = (Byte)RGB;
                    outImage.Data[y, x, 1] = (Byte)(RGB >> 8);
                    outImage.Data[y, x, 2] = (Byte)(RGB >> 16);
                }
            }
            return outImage.Mat;
        }

        public override Mat doYourJob()
        {
            return drawOutputImage();
        }
    }
}
