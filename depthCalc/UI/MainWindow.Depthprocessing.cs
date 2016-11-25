using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepthCalc.UI
{
    // Handling the depthprocessing configuration on the UI
    public partial class MainWindow : Form
    {
        private void addDepthprocStepButton_Click(object sender, EventArgs e)
        {
            Util.DepthprocessingConfig config = new Util.DepthprocessingConfig();
            TemplateMatchingType matchMethod;
            Enum.TryParse<TemplateMatchingType>(matchMethodSelector.SelectedValue.ToString(), out matchMethod);
            config.MatchMethod = matchMethod;
            config.SampleArea = new Rectangle(0, 0, (int)sampleWidthUpDown.Value, (int)sampleHeightUpDown.Value);
            config.WindowArea = new Rectangle(0, 0, (int)windowWidthUpDown.Value, (int)windowHeightUpDown.Value);
            depthCalc.ui_conf_addDepthprocessingStep(new Processing.Depthprocessing.ImageDisparity(config));
            updateDepthprocessingStepsListView();
        }

        private void clearDepthprocQueueButton_Click(object sender, EventArgs e)
        {
            depthCalc.ui_conf_clearDepthprocessingSteps();
            updateDepthprocessingStepsListView();
        }

        private void updateDepthprocessingStepsListView()
        {
            depthprocListView.Columns[0].Width = depthprocListView.Width;
            depthprocListView.Items.Clear();
            foreach (String item in depthCalc.ui_state_getDepthprocessorSteps())
            {
                ListViewItem lvItem = new ListViewItem(item);
                depthprocListView.Items.Add(lvItem);
            }
        }

        private void DepthprocListView_Resize(object sender, EventArgs e)
        {
            depthprocListView.Columns[0].Width = depthprocListView.Width;
        }
    }
}
