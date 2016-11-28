using Emgu.CV;
using System;
using DepthCalc.Util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace DepthCalc.Processing
{
    abstract class ProcessingStep: IDisposable
    {
        public SupportedSteps stepType;
        protected Mat dataImage;
        protected Mat referenceImage;
        protected Mat outBuffer;

        protected BackgroundWorker bw;
        public BackgroundWorker Bw
        {
            set
            {
                bw = value;
            }
        }

        protected int percentComplete = 0;
        public int PercentComplete
        {
            get
            {
                return percentComplete;
            }
            protected set
            {
                Interlocked.Exchange(ref percentComplete, value);
            }
        }

        public int setDataImage(Mat inputImage)
        {
            if (inputImage != null)
            {
                this.dataImage = inputImage;
                return 0;
            }
            throw new Exception("Empty input image");
        }

        public int setReferenceImage(Mat inputImage)
        {
            // Can be null in case of single operand steps
            this.referenceImage = inputImage;
            return 0;
        }

        // Used when the step uses the output of the previous step
        public int setOutBuffer(Mat buffer)
        {
            // Can be null in case of single operand steps
            outBuffer = new Mat();
            this.outBuffer = buffer;
            return 0;
        }

        public override string ToString()
        {
            return ("Type: " + stepType.ToString());
        }

        abstract public Mat doYourJob();

        public void Dispose()
        {
            /*if (dataImage != null)
                dataImage.Dispose();
            if (referenceImage != null)
                referenceImage.Dispose();
            if (outBuffer != null)
                outBuffer.Dispose();*/
        }
    };
}
