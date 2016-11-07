using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;

namespace depthCalc.Util
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
        public List<Processing.ProcessingStep> preProcessorSteps;

        // Processing parameters
        TemplateMatchingType matchMethod;

        // Postprocessing params

        public ParamContainer()
        {
            preProcessorSteps = new List<Processing.ProcessingStep>();
        }
    };

}


