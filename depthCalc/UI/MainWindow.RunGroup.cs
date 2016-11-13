using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;
using static depthCalc.Processing.DepthCalc;

namespace depthCalc.UI
{
    // Handling the run group events on the UI
    public partial class MainWindow : Form
    {
        private void button_runPreprocessor_Click(object sender, EventArgs e)
        {
            depthCalc.ui_run_preProcessingQueue();
            preprocessedDataViewMenuItem.Enabled = true;
            preprocessedReferenceViewMenuItem.Enabled = true;
            updateImageView(SupportedBuffers.preprocessedData);
        }

        // UI event handlers
        private void button_runDepthprocessor_Click(object sender, EventArgs e)
        {
            depthCalc.ui_run_depthProcessingQueue();
            updateImageView(SupportedBuffers.visalisedDispartiy);
        }

        private void button_runPostprocessor_Click(object sender, EventArgs e)
        {

        }

        private void button_runAll_Click(object sender, EventArgs e)
        {
            depthCalc.ui_run_allQueues();
            preprocessedDataViewMenuItem.Enabled = true;
            preprocessedReferenceViewMenuItem.Enabled = true;
        }
    }
}
