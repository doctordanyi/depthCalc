using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;

namespace depthCalc.UI
{
    // Handling the run group events on the UI
    public partial class MainWindow : Form
    {
        private void button_runPreprocessor_Click(object sender, EventArgs e)
        {
            preprocessor.run(rawData, out preprocData, paramContainer.preProcessorSteps);
            preprocessor.run(rawReference, out preprocReference, paramContainer.preProcessorSteps);
            preprocessedDataViewMenuItem.Enabled = true;
            preprocessedReferenceViewMenuItem.Enabled = true;
            updateImageView(SupportedBuffers.preprocessedData);
        }

        // UI event handlers
        private void button_runDepthprocessor_Click(object sender, EventArgs e)
        {
            depthProcessor.run(preprocData, preprocReference, out rawDisparity);
            visualiser.source = rawDisparity.ToImage<Gray, int>();
            visualiser.drawOutputImage(out visualDisparity);

            updateImageView(SupportedBuffers.visalisedDispartiy);

            resultReady = true;
        }

        private void button_runPostprocessor_Click(object sender, EventArgs e)
        {

        }

        private void button_runAll_Click(object sender, EventArgs e)
        {
            preprocessor.run(rawData, out preprocData, paramContainer.preProcessorSteps);
            preprocessor.run(rawReference, out preprocReference, paramContainer.preProcessorSteps);
            depthProcessor.run(preprocData, preprocReference, out rawDisparity);
            preprocessedDataViewMenuItem.Enabled = true;
            preprocessedReferenceViewMenuItem.Enabled = true;
        }
    }
}
