using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Processing
{
    class ProcessingQueue
    {
        private List<ProcessingStep> Queue;
        private BackgroundWorker bw;
        public BackgroundWorker Bw
        {
            set
            {
                bw = value;
            }
        }

        public ProcessingQueue()
        {
            Queue = new List<ProcessingStep>();
        }

        public void addStep(ProcessingStep step)
        {
            Queue.Add(step);
        }

        public void clear()
        {
            Queue.Clear();
        }

        public List<String> stepsToStringList()
        {
            List<String> stepList = new List<string>();
            foreach (ProcessingStep step in Queue)
            {
                stepList.Add(step.ToString());
            }
            return stepList;
        }

        public void run(Mat inputImage, ref Mat outputImage)
        {
            Mat temp = new Mat();
            inputImage.CopyTo(temp);
            foreach (ProcessingStep step in Queue)
            {
                step.Bw = bw;
                bw.ReportProgress(0, step.stepType.ToString());
                step.setDataImage(ref temp);
                temp = step.doYourJob();
            }
            temp.CopyTo(outputImage);
        }

        public void run(Mat dataImage, Mat referenceImage, ref Mat outputImage)
        {
            Mat temp = new Mat();
            foreach (ProcessingStep step in Queue)
            {
                step.Bw = bw;
                bw.ReportProgress(0, step.stepType.ToString());
                step.setDataImage(ref dataImage);
                step.setReferenceImage(ref referenceImage);
                step.setOutBuffer(temp);
                temp = step.doYourJob();
            }
            temp.CopyTo(outputImage);
        }
    }
}
