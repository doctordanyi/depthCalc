using DepthCalc.Processing.Preprocessing;
using System;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;

namespace DepthCalc.UI
{
    // Handling the file menu operations on the UI
    public partial class MainWindow : Form
    {
        
        private void scale2PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(2));
        }

        private void scale4PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(4));
        }

        private void scale8PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(8));
        }

        private void scale16PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(16));
        }

        private void scale32PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(32));
        }

        private void clearPreprocMenuItem_Click(object sender, EventArgs e)
        {
            paramContainer.preProcessorSteps.Clear();
        }

        private void defaultGaussPreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new GaussianBlur(5, 1.5));
        }

        private void defaultDoGPreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new DoG(7, 3, 1.5));
        }

        private void normalizePreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Normalize());
        }
    }
}
