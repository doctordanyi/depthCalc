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
        private void uncheckAllMenuItems(ToolStripMenuItem menuItem)
        {
            foreach(ToolStripMenuItem item in menuItem.DropDownItems)
            {
                if(item.DropDownItems.Count > 0)
                {
                    uncheckAllMenuItems(item);
                }
                    item.Checked = false;
            }
        }

        private void rawReferenceViewMenuItem_Click(object sender, EventArgs e)
        {
            uncheckAllMenuItems(viewMenuItem);
            rawReferenceViewMenuItem.Checked    = true;
            referenceViewMenuItem.Checked = true;
            updateImageView(SupportedBuffers.rawReference);
        }

        private void rawDataViewMenuItem_Click(object sender, EventArgs e)
        {
            uncheckAllMenuItems(viewMenuItem);
            rawDataViewMenuItem.Checked = true;
            dataViewMenuItem.Checked = true;
            updateImageView(SupportedBuffers.rawData);
        }

        private void preprocessedDataViewMenuItem_Click(object sender, EventArgs e)
        {
            uncheckAllMenuItems(viewMenuItem);
            preprocessedDataViewMenuItem.Checked = true;
            dataViewMenuItem.Checked = true;
            updateImageView(SupportedBuffers.preprocessedData);
        }

        private void preprocessedReferenceViewMenuItem_Click(object sender, EventArgs e)
        {
            uncheckAllMenuItems(viewMenuItem);
            preprocessedReferenceViewMenuItem.Checked = true;
            referenceViewMenuItem.Checked = true;
            updateImageView(SupportedBuffers.preprocessedReference);
        }
    }
}
