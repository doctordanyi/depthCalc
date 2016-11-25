using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Drawing;

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

    class DepthprocessingConfig
    {
        TemplateMatchingType matchMethod;
        Rectangle sampleArea;
        Rectangle windowArea;

        public DepthprocessingConfig()
        {
            MatchMethod = TemplateMatchingType.CcoeffNormed;
            SampleArea = new Rectangle(0, 0, 7, 7);
            WindowArea = new Rectangle(0, 0, 100, SampleArea.Height);
        }

        public TemplateMatchingType MatchMethod
        {
            get
            {
                return matchMethod;
            }

            set
            {
                matchMethod = value;
            }
        }

        public Rectangle SampleArea
        {
            get
            {
                return sampleArea;
            }

            set
            {
                sampleArea = value;
            }
        }

        public Rectangle WindowArea
        {
            get
            {
                return windowArea;
            }

            set
            {
                windowArea = value;
            }
        }
    }
}


