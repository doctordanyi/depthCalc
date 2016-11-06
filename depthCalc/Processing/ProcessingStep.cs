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

        abstract public Mat doYourJob();
    };
}
