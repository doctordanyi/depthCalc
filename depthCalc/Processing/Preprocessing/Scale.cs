using Emgu.CV;
using DepthCalc.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Processing.Preprocessing
{
    class Scale : ProcessingStep
    {
        public int scaleDownFactor;

        public Scale(int scaleDownFactor)
        {
            stepType = SupportedSteps.Scale;
            this.scaleDownFactor = scaleDownFactor;
        }

        public override Mat doYourJob()
        {
            Mat destImage = new Mat();
            CvInvoke.Resize(inputImage, destImage, new System.Drawing.Size(0,0) ,(1 / (double)scaleDownFactor), (1 / (double)scaleDownFactor));
            return destImage;
        }

        public override string ToString()
        {
            string readable = base.ToString();
            readable += ", Parameters: {";
            readable += "'scale': 1:" + scaleDownFactor + "}";
            return readable;
        }
    }
}
