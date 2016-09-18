using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace depthCalc
{
    class ImageIO
    {
        public Image<Gray,Byte> actBuffer;
        public Image<Bgr, Byte> outBuffer;

        // Write actBuffer to file
        public void write(String path)
        {
            outBuffer.Save(path.ToString());
            return;
        }

        // Load image from file to actBuffer
        public void read(String path)
        {
            actBuffer = new Image<Gray, Byte>(path.ToString());
            return;
        }


    }
}
