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

        private Mat processedImage;

        // Supported preprocessing steps
        public enum SupportedSteps
        {
            Scale,
            GaussianBlur,
            DifferenceOfGaussians
        };

        public void run(Mat RawImage, out Mat PreprocessedImage, List<PreProcessorStep> preProcessingSteps)
        {
            processedImage = RawImage;
            foreach (var step in preProcessingSteps)
            {
                processedImage = step.doYourJob(processedImage, this);
            }
            PreprocessedImage = processedImage;
        }

        public Mat Scale(int scaleDownFactor, Mat inputImage)
        {
            Mat destImage = new Mat();
            CvInvoke.Resize(inputImage, destImage, new System.Drawing.Size(0,0) ,(1 / (double)scaleDownFactor), (1 / (double)scaleDownFactor));
            return destImage;
        }

        private void GaussianBlur(int kernelSize, float sigma)
        {
            
        }

        private void DifferenceOfGaussians(int kernelSize1, int kernelSize2)
        {
           
        }

    }
}
