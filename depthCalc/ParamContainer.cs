using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;

namespace depthCalc
{
    class ParamContainer
    {
        // Store parameters selected by the user

        // File paths
        public string pathReference;
        public string pathData;
        public string pathResult;

        // Preprocessing parameters
        public List<PreProcessorStep> preProcessorSteps;

        // Processing parameters
        TemplateMatchingType matchMethod;

        // Postprocessing params

        public ParamContainer()
        {
            preProcessorSteps = new List<PreProcessorStep>();
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
        public float sigma;

        public PreProcessorGaussianBlur(int kernelSize, float sigma)
        {
            stepType = PreDepthProcessor.SupportedSteps.GaussianBlur;
            this.kernelSize = kernelSize;
            this.sigma = sigma;
        }

        public override Mat doYourJob(Mat inputImage, PreDepthProcessor preprocessor)
        {
            throw new NotImplementedException();
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
