using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc
{
    class PostDepthProcessor
    {
        // Supported postprocessing steps
        public enum SupportedSteps
        {
            MedianFilter
        };

        public void MedianFilter(int kernelSize, out Mat Data)
        {
            Data = new Mat();
        }
    }
}
