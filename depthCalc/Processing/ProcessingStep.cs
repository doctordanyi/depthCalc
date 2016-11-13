using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Processing
{
    abstract class ProcessingStep
    {
        public enum SupportedSteps
        {
            Scale,
            GaussianBlur,
            DifferenceOfGaussians,
            Normalize
        };

        public SupportedSteps stepType;
        protected Mat inputImage;

        public int setInputImage(ref Mat inputImage)
        {
            if (inputImage != null)
            {
                this.inputImage = inputImage;
                return 0;
            }
            throw new Exception("Empty input image");
        }

        abstract public Mat doYourJob();
    };
}
