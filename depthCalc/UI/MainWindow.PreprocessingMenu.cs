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
            updatePreprocessingStepsListView();
        }

        private void scale4PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(4));
            updatePreprocessingStepsListView();
        }

        private void scale8PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(8));
            updatePreprocessingStepsListView();
        }

        private void scale16PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(16));
            updatePreprocessingStepsListView();
        }

        private void scale32PreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Scale(32));
            updatePreprocessingStepsListView();
        }

        private void clearPreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_clearPreprocessingSteps();
            updatePreprocessingStepsListView();
        }

        private void defaultGaussPreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new GaussianBlur(5, 1.5));
            updatePreprocessingStepsListView();
        }

        private void defaultDoGPreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new DoG(7, 3, 1.5));
            updatePreprocessingStepsListView();
        }

        private void normalizePreprocMenuItem_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_addPreprocessingStep(new Normalize());
            updatePreprocessingStepsListView();
        }

        private void updatePreprocessingStepsListView()
        {
            preprocListView.Columns[0].Width = preprocListView.Width;
            preprocListView.Items.Clear();
            foreach (String item in depthCalc.ui_state_getPreprocessorSteps())
            {
                ListViewItem lvItem = new ListViewItem(item);
                preprocListView.Items.Add(lvItem);
            }
        }
    }
}
