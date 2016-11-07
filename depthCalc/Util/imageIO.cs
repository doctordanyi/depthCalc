using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace depthCalc.Util
{
    class ImageIO
    {
        // Write actBuffer to file
        public void write(String path, Mat writeBuffer)
        {
            writeBuffer.Save(path.ToString());
        }

        // Load image from file to actBuffer
        public void read(String path, out Mat readBuffer)
        {
            readBuffer = CvInvoke.Imread(path, Emgu.CV.CvEnum.LoadImageType.Grayscale);
        }
    }
}
