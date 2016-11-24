using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Util
{
    class WindowSelector
    {
        private Rectangle imageArea;
        private Rectangle windowArea;
        private WindowPinType windowPinType = WindowPinType.Center;
        

        public Rectangle WindowArea
        {
            get
            {
                return windowArea;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Empty source image");
                }
                if ((value.Width == 0) || (value.Height == 0))
                {
                    throw new Exception("Invalid image size");
                }
                windowArea = value;
            }
        }

        public WindowSelector(Mat sourceImage)
        {
            if (sourceImage == null)
            {
                throw new Exception("Empty source image");
            }
            if ((sourceImage.Width == 0) || (sourceImage.Height == 0))
            {
                throw new Exception("Invalid image size");
            }

            imageArea = new Rectangle(0, 0, sourceImage.Width, sourceImage.Height);
        }

        public WindowSelector(int width, int height)
        {
            if ((width == 0) || (height == 0))
            {
                throw new Exception("Invalid image size");
            }

            imageArea = new Rectangle(0, 0, width, height);
        }

        public WindowSelector(Rectangle sourceArea)
        {
            if (sourceArea == null)
            {
                throw new Exception("Empty source image");
            }
            if ((sourceArea.Width == 0) || (sourceArea.Height == 0))
            {
                throw new Exception("Invalid image size");
            }

            imageArea = new Rectangle(0, 0, sourceArea.Width, sourceArea.Height);
        }

        public Rectangle getWindow(int x, int y)
        {
            Rectangle window = windowArea;
            switch (windowPinType)
            {
                case WindowPinType.Center:
                    if (x < (windowArea.Width / 2))
                        window.X = 0;
                    else if ((x + windowArea.Width / 2) > imageArea.Width)
                        window.X = imageArea.Width - windowArea.Width;
                    else
                        window.X = x - windowArea.Width / 2;

                    if (y < (windowArea.Height / 2))
                        window.Y = 0;
                    else if ((y + windowArea.Height / 2) > imageArea.Height)
                        window.Y = imageArea.Height - windowArea.Height;
                    else
                        window.Y = y - windowArea.Height / 2;
                    return window;
                case WindowPinType.UpperLeft:
                    if ((x + windowArea.Width) > imageArea.Width)
                        window.X = imageArea.Width - windowArea.Width;
                    else
                        window.X = x;

                    if ((y + windowArea.Height) > imageArea.Height)
                        window.Y = imageArea.Height - windowArea.Height;
                    else
                        window.Y = y - windowArea.Height;
                    return window;
                case WindowPinType.UpperRight:
                    if (x < windowArea.Width)
                        window.X = 0;
                    else
                        window.X = x - windowArea.Width;

                    if ((y + windowArea.Height) > imageArea.Height)
                        window.Y = imageArea.Height - windowArea.Height;
                    else
                        window.Y = y - windowArea.Height;
                    return window;
                case WindowPinType.LowerLeft:
                    if ((x + windowArea.Width) > imageArea.Width)
                        window.X = imageArea.Width - windowArea.Width;
                    else
                        window.X = x;

                    if ((y - windowArea.Height) < 0)
                        window.Y = windowArea.Height;
                    else
                        window.Y = y - windowArea.Height;
                    return window;
                case WindowPinType.LowerRight:
                    return window;
                default:
                    throw new Exception("Unsupported pin type");
            }
        }

    }
}
