using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;

namespace depthCalc
{
    class ParamContainer
    {
        // Store parameters selected by the user

        // File paths
        public String pathReference;
        public String pathData;
        public String pathResult;

        // Preprocessing parameters
        public int scale;

        // Processing parameters
        TemplateMatchingType matchMethod;

        // Postprocessing params
    }
}
