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

        private Mat input, processedImage;

        // Supported preprocessing steps
        public enum SupportedSteps
        {
            Scale,
            GaussianBlur,
            DifferenceOfGaussians
        };

        public void run(Mat RawImage, out Mat PreprocessedImage, List<SupportedSteps> preProcessingSteps)
        {
            processedImage = RawImage;
            foreach (var step in preProcessingSteps)
            {
                switch (step)
                {
                    case SupportedSteps.Scale:

                        break;
                    case SupportedSteps.GaussianBlur:
                        break;
                    case SupportedSteps.DifferenceOfGaussians:
                        break;
                    default:
                        break;
                }
            }
            PreprocessedImage = processedImage;
        }

        private void Scale(int scaleDownFactorm)
        {
            
        }

        private void GaussianBlur(int kernelSize, float sigma)
        {
            
        }

        private void DifferenceOfGaussians(int kernelSize1, int kernelSize2)
        {
           
        }

    }
}
