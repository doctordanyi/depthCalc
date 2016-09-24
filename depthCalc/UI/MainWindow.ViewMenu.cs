using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;

namespace depthCalc
{
    // Handling the file menu operations on the UI
    public partial class MainWindow : Form
    {
        private void rawReferenceViewMenuItem_Click(object sender, EventArgs e)
        {
            updateImageView(SupportedBuffers.rawReference);
        }

        private void rawDataViewMenuItem_Click(object sender, EventArgs e)
        {
            updateImageView(SupportedBuffers.rawData);
        }

        private void preprocessedDataViewMenuItem_Click(object sender, EventArgs e)
        {
            updateImageView(SupportedBuffers.preprocessedData);
        }

        private void preprocessedReferenceViewMenuItem_Click(object sender, EventArgs e)
        {
            updateImageView(SupportedBuffers.preprocessedReference);
        }
    }
}
