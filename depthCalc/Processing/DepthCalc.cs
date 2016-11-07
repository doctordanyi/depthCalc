using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Processing
{
    class DepthCalc
    {
        // Read/write/visualise images
        private Util.ImageIO imageIO;
        private Visualiser visualiser;

        // Container for user defined parameters
        private Util.ParamContainer paramContainer;

        // Processing Queues
        private ProcessingQueue preprocessingQueue;
        private ProcessingQueue depthprocessingQueue;
        private ProcessingQueue postprocessingQueue;

        // Raw input images
        private Mat rawReference;
        private Mat rawData;
        // Preprocessed images
        private Mat preprocReference;
        private Mat preprocData;
        // Disparity map
        private Mat rawDisparity;
        // Postprocessed disparity map
        private Mat postprocDisparity;
        // Visualised disparity map
        private Mat visualDisparity;

    }
}
