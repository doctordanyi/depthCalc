using Emgu.CV;
using DepthCalc.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Processing.Preprocessing
{
    class DoG : ProcessingStep
    {
        public int kernelSize1;
        public int kernelSize2;
        public double sigma;

        public DoG(int kernelSize1, int kernelSize2, double sigma)
        {
            stepType = SupportedSteps.DifferenceOfGaussians;

            this.kernelSize1 = kernelSize1;
            this.kernelSize2 = kernelSize2;
            this.sigma = sigma;
        }

        public override Mat doYourJob()
        {
            Mat destImage1 = new Mat();
            Mat destImage2 = new Mat();
            Mat result = new Mat();

            CvInvoke.GaussianBlur(dataImage, destImage1, new System.Drawing.Size(kernelSize1, kernelSize1), sigma);
            CvInvoke.GaussianBlur(dataImage, destImage2, new System.Drawing.Size(kernelSize2, kernelSize2), sigma);

            CvInvoke.AbsDiff(destImage1, destImage2, result);
            CvInvoke.Normalize(result, result, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);

            return result;
        }

        public override string ToString()
        {
            string readable = base.ToString();
            readable += ", Parameters: {";
            readable += "'kernel size 1': " + kernelSize1 + ", ";
            readable += "'kernel size 2': " + kernelSize2 + ", ";
            readable += "'sigma': " + sigma + "}";
            return readable;
        }
    }
}
