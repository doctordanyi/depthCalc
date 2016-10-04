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
        
        private void scale2PreprocMenuItem_Click(object sender, EventArgs e)
        {
            PreProcessorScale scaleDown = new PreProcessorScale(2);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void scale4PreprocMenuItem_Click(object sender, EventArgs e)
        {
            PreProcessorScale scaleDown = new PreProcessorScale(4);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void scale8PreprocMenuItem_Click(object sender, EventArgs e)
        {
            PreProcessorScale scaleDown = new PreProcessorScale(8);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void scale16PreprocMenuItem_Click(object sender, EventArgs e)
        {
            PreProcessorScale scaleDown = new PreProcessorScale(16);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void scale32PreprocMenuItem_Click(object sender, EventArgs e)
        {
            PreProcessorScale scaleDown = new PreProcessorScale(32);
            paramContainer.preProcessorSteps.Add(scaleDown);
        }

        private void clearPreprocMenuItem_Click(object sender, EventArgs e)
        {
            paramContainer.preProcessorSteps.Clear();
        }

        private void defaultGaussPreprocMenuItem_Click(object sender, EventArgs e)
        {
            PreProcessorGaussianBlur gaussianBlur = new PreProcessorGaussianBlur(5, 1.5);
            paramContainer.preProcessorSteps.Add(gaussianBlur);
        }

        private void defaultDoGPreprocMenuItem_Click(object sender, EventArgs e)
        {
            PreProcessorDoG doG = new PreProcessorDoG(7, 3, 1.5);
            paramContainer.preProcessorSteps.Add(doG);
        }

        private void normalizePreprocMenuItem_Click(object sender, EventArgs e)
        {
            PreProcessorNormalize normalize = new PreProcessorNormalize();
            paramContainer.preProcessorSteps.Add(normalize);
        }
    }
}
