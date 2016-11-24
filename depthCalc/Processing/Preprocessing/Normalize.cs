using Emgu.CV;
using DepthCalc.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Processing.Preprocessing
{
    class Normalize : ProcessingStep
    {
        public Normalize()
        {
            stepType = SupportedSteps.Normalize;
        }

        public override Mat doYourJob()
        {
            Mat result = new Mat();
            CvInvoke.EqualizeHist(dataImage, result);
            return result;
        }
    }
}
