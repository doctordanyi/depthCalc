using depthCalc.Processing.Preprocessing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;

namespace depthCalc.UI
{
    // Handling the file menu operations on the UI
    public partial class MainWindow : Form
    {
        
        private void scale2PreprocMenuItem_Click(object sender, EventArgs e)
        {
            Scale scaleDown = new Scale(2);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void scale4PreprocMenuItem_Click(object sender, EventArgs e)
        {
            Scale scaleDown = new Scale(4);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void scale8PreprocMenuItem_Click(object sender, EventArgs e)
        {
            Scale scaleDown = new Scale(8);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void scale16PreprocMenuItem_Click(object sender, EventArgs e)
        {
            Scale scaleDown = new Scale(16);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void scale32PreprocMenuItem_Click(object sender, EventArgs e)
        {
            Scale scaleDown = new Scale(32);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void clearPreprocMenuItem_Click(object sender, EventArgs e)
        {
            paramContainer.preProcessorSteps.Clear();
        }

        private void defaultGaussPreprocMenuItem_Click(object sender, EventArgs e)
        {
            GaussianBlur gaussianBlur = new GaussianBlur(5, 1.5);
            paramContainer.preProcessorSteps.Add(gaussianBlur);
        }

        private void defaultDoGPreprocMenuItem_Click(object sender, EventArgs e)
        {
            DoG doG = new DoG(7, 3, 1.5);
            paramContainer.preProcessorSteps.Add(doG);
        }

        private void normalizePreprocMenuItem_Click(object sender, EventArgs e)
        {
            Normalize normalize = new Normalize();
            paramContainer.preProcessorSteps.Add(normalize);
        }
    }
}
