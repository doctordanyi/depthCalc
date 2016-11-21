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

        public ProcessingQueue()
        {
            Queue = new List<ProcessingStep>();
        }

        public void addStep(ProcessingStep step)
        {
            Queue.Add(step);
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

        public void run()
        {
            foreach (ProcessingStep step in Queue)
            {
                step.doYourJob();
            }
        }
    }
}
