using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;

namespace DepthCalc.Util
{
    class ParamContainer
    {
        // Store parameters selected by the user

        // File paths
        public string pathResult;


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

    class BufferStates
    {
        public bool rawDataReady = false;
        public bool rawReferenceReady = false;
        public bool preprocDataReady = false;
        public bool preprocReferenceReady = false;
        public bool rawDisparityReady = false;
        public bool postprocDisparityReady = false;
        public bool visualDisparityReady = false;
    }

    class SourceFilePaths
    {
        public string reference;
        public string data;
    }
}


