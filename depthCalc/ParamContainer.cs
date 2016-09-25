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

        // Data availability flags
        public bool rawReferenceAvailable;
        public bool rawDataAvailable;
        public bool preprocessedReferenceAvailable;
        public bool preprocessedDataAvailable;

        // Preprocessing parameters
        public List<PreProcessorStep> preProcessorSteps;

        // Processing parameters
        TemplateMatchingType matchMethod;

        // Postprocessing params

        public ParamContainer()
        {
            preProcessorSteps = new List<PreProcessorStep>();
        }
    };

}


