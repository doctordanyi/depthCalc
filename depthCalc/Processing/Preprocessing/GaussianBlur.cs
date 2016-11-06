using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Processing.Preprocessing
{
    class GaussianBlur : ProcessingStep
    {
        private Mat inputImage;

        public int kernelSize;
        public double sigma;

        public GaussianBlur(ref Mat image, int kernelSize, double sigma)
        {
            stepType = SupportedSteps.GaussianBlur;

            inputImage = image;

            this.kernelSize = kernelSize;
            this.sigma = sigma;
        }

        public override Mat doYourJob()
        {
            Mat destImage = new Mat();
            CvInvoke.GaussianBlur(inputImage, destImage, new System.Drawing.Size(kernelSize, kernelSize), sigma);
            return destImage;
        }
    }
}
