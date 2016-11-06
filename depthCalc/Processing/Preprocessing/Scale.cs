using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Processing.Preprocessing
{
    class Scale : ProcessingStep
    {

        private Mat inputImage;
        public int scaleDownFactor;

        public Scale(ref Mat image, int scaleDownFactor)
        {
            stepType = SupportedSteps.Scale;
            this.scaleDownFactor = scaleDownFactor;
            inputImage = image;
        }

        public override Mat doYourJob()
        {
            Mat destImage = new Mat();
            CvInvoke.Resize(inputImage, destImage, new System.Drawing.Size(0,0) ,(1 / (double)scaleDownFactor), (1 / (double)scaleDownFactor));
            return destImage;
        }
    }
}
