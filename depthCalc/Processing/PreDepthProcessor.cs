using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Processing
{
    class PreDepthProcessor
    {

        private Mat processedImage;

        // Supported preprocessing steps

        public void run(Mat RawImage, out Mat PreprocessedImage, List<ProcessingStep> preProcessingSteps)
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

        public Mat GaussianBlur(int kernelSize, double sigma, Mat inputImage)
        {
            Mat destImage = new Mat();
            CvInvoke.GaussianBlur(inputImage, destImage, new System.Drawing.Size(kernelSize, kernelSize), sigma);
            return destImage;
        }

        public Mat DifferenceOfGaussians(int kernelSize1, int kernelSize2, double sigma, Mat inputImage)
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

        public void NormalizeIntensity()
        {
            
        }

    }

}
