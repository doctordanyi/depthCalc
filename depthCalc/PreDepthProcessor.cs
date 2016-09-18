using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc
{
    class PreDepthProcessor
    {
        // Supported preprocessing steps
        public enum SupportedSteps
        {
            Scale,
            GaussianBlur,
            DifferenceOfGaussians
        };

        public void Scale(int scaleDownFactorm, out Mat Data)
        {
            Data = new Mat();
        }

        public void GaussianBlur(int kernelSize, float sigma, out Mat Data)
        {
            Data = new Mat();
        }

        public void DifferenceOfGaussians(int kernelSize1, int kernelSize2, out Mat Data)
        {
            Data = new Mat();
        }

    }
}
