using Emgu.CV;
using System;
using DepthCalc.Util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Processing
{
    abstract class ProcessingStep
    {
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

        public override string ToString()
        {
            return ("Type: " + stepType.ToString());
        }

        abstract public Mat doYourJob();
    };
}
