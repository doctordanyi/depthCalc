using Emgu.CV;
using DepthCalc.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Processing.Preprocessing
{
    class Identity : ProcessingStep
    {
        public Identity()
        {
            stepType = SupportedSteps.Identity;
        }

        public override Mat doYourJob()
        {
            return inputImage;
        }
    }
}
