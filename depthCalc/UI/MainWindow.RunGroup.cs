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
        private void button_runPreprocessor_Click(object sender, EventArgs e)
        {
            preprocessor.run(rawData, out preprocData, paramContainer.preProcessorSteps);
            preprocessor.run(rawReference, out preprocReference, paramContainer.preProcessorSteps);
        }

        // UI event handlers
        private void button_runDepthprocessor_Click(object sender, EventArgs e)
        {
            depthProcessor.calculate_displacement();
            visualiser.source = depthProcessor.result;
            visualiser.drawOutputImage();

            //        displayBuffer = visualiser.outImage.Resize(640,512, Emgu.CV.CvEnum.Inter.Nearest).ToBitmap();
            //       dataImage.Image = displayBuffer;

            resultReady = true;
        }

        private void button_runPostprocessor_Click(object sender, EventArgs e)
        {

        }

        private void button_runAll_Click(object sender, EventArgs e)
        {

        }
    }
}
