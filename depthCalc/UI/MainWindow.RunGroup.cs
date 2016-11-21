using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DepthCalc.Util;

namespace DepthCalc.UI
{
    // Handling the run group events on the UI
    public partial class MainWindow : Form
    {
        private BackgroundWorker createBackgroudWorker(DoWorkEventHandler task)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(task);
            return bw;
        }

        private void button_runPreprocessor_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = createBackgroudWorker(depthCalc.ui_run_preProcessingQueue);
            bw.RunWorkerCompleted += PreprocessingCompleted;
            bw.RunWorkerAsync();
        }

        private void PreprocessingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preprocessedDataViewMenuItem.Enabled = true;
            preprocessedReferenceViewMenuItem.Enabled = true;
            updateImageView(SupportedBuffers.preprocessedData);
        }

        // UI event handlers
        private void button_runDepthprocessor_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = createBackgroudWorker(depthCalc.ui_run_depthProcessingQueue);
            bw.RunWorkerCompleted += DepthprocessingCompleted;
            bw.RunWorkerAsync();
            updateImageView(SupportedBuffers.visalisedDispartiy);
        }

        private void DepthprocessingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_runPostprocessor_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = createBackgroudWorker(depthCalc.ui_run_postProcessingQueue);
            bw.RunWorkerCompleted += PostprocessingCompleted;
            bw.RunWorkerAsync();
        }

        private void PostprocessingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_runAll_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = createBackgroudWorker(depthCalc.ui_run_allQueues);
            bw.RunWorkerCompleted += ProcessingCompleted;
            preprocessedDataViewMenuItem.Enabled = true;
            preprocessedReferenceViewMenuItem.Enabled = true;
        }

        private void ProcessingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
