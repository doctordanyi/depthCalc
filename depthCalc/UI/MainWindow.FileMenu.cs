using System;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;
using DepthCalc.Util;

namespace DepthCalc.UI
{
    // Handling the file menu operations on the UI
    public partial class MainWindow : Form
    {
        private void openReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openReferenceImageDialog.ShowDialog();
        }

        private void openDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDataImageDialog.ShowDialog();
        }

        private void handle_openDataImage_FileOk(object sender, CancelEventArgs e)
        {
            // Pass action to core
            depthCalc.ui_file_openDataImage(openDataImageDialog.FileName);

            // UI administartion
            updateImageView(SupportedBuffers.rawData);
            dataViewMenuItem.Enabled = true;
            rawDataViewMenuItem.Enabled = true;
            // Both source images are loaded
            if (depthCalc.ui_state_getBufferStates().rawReferenceReady)
            {
                button_runPreprocessor.Enabled = true;
                button_runDepthprocessor.Enabled = true;
                button_runAll.Enabled = true;

                dataImage.Enabled = true;
            }
        }

        private void openReferenceImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Pass action to core
            depthCalc.ui_file_openReferenceImage(openReferenceImageDialog.FileName);
            // UI administartion
            updateImageView(SupportedBuffers.rawReference);
            referenceViewMenuItem.Enabled = true;
            rawReferenceViewMenuItem.Enabled = true;
            // Both source images are loaded
            if (depthCalc.ui_state_getBufferStates().rawDataReady)
            {
                button_runPreprocessor.Enabled = true;
                button_runDepthprocessor.Enabled = true;
                button_runAll.Enabled = true;

                dataImage.Enabled = true;
            }
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "result.png";
            saveResultImage.FileName = fileName;
            saveResultImage.ShowDialog();
        }

        private void saveResultImage_FileOk(object sender, CancelEventArgs e)
        {
            depthCalc.ui_file_saveVisualResult(saveResultImage.FileName);
        }
    }
}
