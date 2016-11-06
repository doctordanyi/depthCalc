using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Processing.Preprocessing
{
    class DoG : ProcessingStep
    {
        private Mat inputImage;

        public int kernelSize1;
        public int kernelSize2;
        public double sigma;

        public DoG(ref Mat image, int kernelSize1, int kernelSize2, double sigma)
        {
            stepType = SupportedSteps.DifferenceOfGaussians;

            inputImage = image;

            this.kernelSize1 = kernelSize1;
            this.kernelSize2 = kernelSize2;
            this.sigma = sigma;
        }

        public override Mat doYourJob()
        {
            Mat destImage1 = new Mat();
            Mat destImage2 = new Mat();
            Mat result = new Mat();

            CvInvoke.GaussianBlur(inputImage, destImage1, new System.Drawing.Size(kernelSize1, kernelSize1), sigma);
            CvInvoke.GaussianBlur(inputImage, destImage2, new System.Drawing.Size(kernelSize2, kernelSize2), sigma);

            CvInvoke.AbsDiff(destImage1, destImage2, result);
            CvInvoke.Normalize(result, result, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);

            return result;
        }
    }
}
