using Emgu.CV;
using DepthCalc.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Processing.Preprocessing
{
    class GaussianBlur : ProcessingStep
    {
        public int kernelSize;
        public double sigma;

        public GaussianBlur(int kernelSize, double sigma)
        {
            stepType = SupportedSteps.GaussianBlur;

            this.kernelSize = kernelSize;
            this.sigma = sigma;
        }

        public override Mat doYourJob()
        {
            Mat destImage = new Mat();
            CvInvoke.GaussianBlur(dataImage, destImage, new System.Drawing.Size(kernelSize, kernelSize), sigma);
            return destImage;
        }

        public override string ToString()
        {
            string readable = base.ToString();
            readable += ", Parameters: {";
            readable += "'kernel size': " + kernelSize + ", ";
            readable += "'sigma': " + sigma + "}";
            return readable;
        }
    }
}
