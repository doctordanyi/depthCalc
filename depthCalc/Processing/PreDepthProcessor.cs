using Emgu.CV;
using Emgu.CV.Structure;
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
            DifferenceOfGaussians,
            Normalize
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
        public double sigma;

        public PreProcessorDoG(int kernelSize1, int kernelSize2, double sigma)
        {
            stepType = PreDepthProcessor.SupportedSteps.DifferenceOfGaussians;
            this.kernelSize1 = kernelSize1;
            this.kernelSize2 = kernelSize2;
            this.sigma = sigma;
        }

        public override Mat doYourJob(Mat inputImage, PreDepthProcessor preprocessor)
        {
            return preprocessor.DifferenceOfGaussians(kernelSize1, kernelSize2, sigma, inputImage);
        }
    }

    class PreProcessorNormalize : PreProcessorStep
    {
        private const int windowSize = 80;

        public PreProcessorNormalize()
        {
            stepType = PreDepthProcessor.SupportedSteps.DifferenceOfGaussians;
        }

        public override Mat doYourJob(Mat inputImage, PreDepthProcessor preprocessor)
        {
            Mat result = new Mat();
            inputImage.CopyTo(result);

            MCvScalar avg = CvInvoke.Mean(inputImage);
            for (int y = 0; y < (inputImage.Height - windowSize); y++)
            {
                for (int x = 0; x < (inputImage.Width - windowSize); x++)
                {
                    System.Drawing.Rectangle ROI = new System.Drawing.Rectangle(x, y, windowSize, windowSize);
                    Mat subimage = new Mat(result, ROI);
                    CvInvoke.Normalize(subimage, subimage, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);
                }
            }
            return result;
        }
    }
}

