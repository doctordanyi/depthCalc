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

        public Mat GaussianBlur(int kernelSize, double sigma, Mat inputImage)
        {
            Mat destImage = new Mat();
            CvInvoke.GaussianBlur(inputImage, destImage, new System.Drawing.Size(kernelSize, kernelSize), sigma);
            return destImage;
        }

        private void DifferenceOfGaussians(int kernelSize1, int kernelSize2)
        {
           
        }

    }

    abstract class PreProcessorStep
    {
        public PreDepthProcessor.SupportedSteps stepType;

        abstract public Mat doYourJob(Mat inputImage, PreDepthProcessor preprocessor);
    };

    class PreProcessorScale : PreProcessorStep
    {
        public int scaleDownFactor;

        public PreProcessorScale(int scaleDownFactor)
        {
            stepType = PreDepthProcessor.SupportedSteps.Scale;
            this.scaleDownFactor = scaleDownFactor;
        }

        public override Mat doYourJob(Mat inputImage, PreDepthProcessor preprocessor)
        {
            return preprocessor.Scale(scaleDownFactor, inputImage);
        }

    }

    class PreProcessorGaussianBlur : PreProcessorStep
    {
        public int kernelSize;
        public double sigma;

        public PreProcessorGaussianBlur(int kernelSize, double sigma)
        {
            stepType = PreDepthProcessor.SupportedSteps.GaussianBlur;
            this.kernelSize = kernelSize;
            this.sigma = sigma;
        }

        public override Mat doYourJob(Mat inputImage, PreDepthProcessor preprocessor)
        {
            return preprocessor.GaussianBlur(kernelSize, sigma, inputImage);
        }

    }

    class PreProcessorDoG : PreProcessorStep
    {
        public int kernelSize1;
        public int kernelSize2;

        public PreProcessorDoG(int kernelSize1, int kernelSize2)
        {
            stepType = PreDepthProcessor.SupportedSteps.DifferenceOfGaussians;
            this.kernelSize1 = kernelSize1;
            this.kernelSize2 = kernelSize2;
        }

        public override Mat doYourJob(Mat inputImage, PreDepthProcessor preprocessor)
        {
            throw new NotImplementedException();
        }
    }
}

