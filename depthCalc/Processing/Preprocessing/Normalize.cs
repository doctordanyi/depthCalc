using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Processing.Preprocessing
{
    class Normalize : ProcessingStep
    {
        private const int windowSize = 80;

        public Normalize()
        {
            stepType = SupportedSteps.DifferenceOfGaussians;
        }

        public override Mat doYourJob()
        {
            Mat result = new Mat();
            CvInvoke.EqualizeHist(inputImage, result);
            return result;
        }
    }
}
