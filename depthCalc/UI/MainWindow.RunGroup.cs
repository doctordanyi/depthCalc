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

        private void preprocRunMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = createBackgroudWorker(depthCalc.ui_run_preProcessingQueue);
            bw.RunWorkerCompleted += PreprocessingCompleted;
            bw.ProgressChanged += PreprocessingProgressChanged;
            bw.RunWorkerAsync();
        }

        private void PreprocessingProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            String step = e.UserState as String;
            procStepStatusLabel.Text = step;
        }

        private void PreprocessingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preprocessedDataViewMenuItem.Enabled = true;
            preprocessedReferenceViewMenuItem.Enabled = true;
            updateImageView(SupportedBuffers.preprocessedData);
            procStepStatusLabel.Text = "Idle";
        }

        // UI event handlers
        private void dispRunStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = createBackgroudWorker(depthCalc.ui_run_depthProcessingQueue);
            bw.RunWorkerCompleted += DepthprocessingCompleted;
            bw.ProgressChanged += DepthprocessingProgressChanged;
            bw.RunWorkerAsync();
        }

        private void DepthprocessingProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            String step = e.UserState as String;
            procStepStatusLabel.Text = step;
            procProgressBar.Value = e.ProgressPercentage;
        }

        private void DepthprocessingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            procProgressBar.Value = 0;
            procStepStatusLabel.Text = "Idle";
            postprocRunMenuItem.Enabled = true;
            updateImageView(SupportedBuffers.Disparity);
        }

        private void postprocRunMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = createBackgroudWorker(depthCalc.ui_run_postProcessingQueue);
            bw.RunWorkerCompleted += PostprocessingCompleted;
            bw.RunWorkerAsync();
        }

        private void PostprocessingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            updateImageView(SupportedBuffers.visalisedDispartiy);
        }

        private void allRunMenuItem_Click(object sender, EventArgs e)
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
