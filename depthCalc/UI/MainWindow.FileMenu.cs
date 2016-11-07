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
        private void openReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openReferenceImageDialog.ShowDialog();
        }

        private void openDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDataImageDialog.ShowDialog();
        }

        void handle_openDataImage_FileOk(object sender, CancelEventArgs e)
        {
            paramContainer.pathData = openDataImageDialog.FileName;
            imageIO.read(openDataImageDialog.FileName, out rawData);
            updateImageView(SupportedBuffers.rawData);
            paramContainer.rawDataAvailable = true;
            dataViewMenuItem.Enabled = true;
            rawDataViewMenuItem.Enabled = true;
            // Both source images are loaded
            if (paramContainer.rawReferenceAvailable)
            {
                button_runPreprocessor.Enabled = true;
                button_runDepthprocessor.Enabled = true;
                button_runAll.Enabled = true;

                dataImage.Enabled = true;
            }
        }

        private void openReferenceImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            paramContainer.pathReference = openReferenceImageDialog.FileName;
            imageIO.read(openReferenceImageDialog.FileName, out rawReference);
            updateImageView(SupportedBuffers.rawReference);
            paramContainer.rawReferenceAvailable = true;
            referenceViewMenuItem.Enabled = true;
            rawReferenceViewMenuItem.Enabled = true;
            // Both source images are loaded
            if(paramContainer.rawDataAvailable)
            {
                button_runPreprocessor.Enabled = true;
                button_runDepthprocessor.Enabled = true;
                button_runAll.Enabled = true;

                dataImage.Enabled = true;
            }
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fileName = "result";

            // Add matching algorithm
            switch (depthProcessor.matchMethod)
            {
                case TemplateMatchingType.Sqdiff:
                    fileName += "_SQDIFF";
                    break;
                case TemplateMatchingType.SqdiffNormed:
                    fileName += "_NormedSQDIFF";
                    break;
                case TemplateMatchingType.Ccorr:
                    fileName += "_CCORR";
                    break;
                case TemplateMatchingType.CcorrNormed:
                    fileName += "_NormedCCORR";
                    break;
                case TemplateMatchingType.Ccoeff:
                    fileName += "_CCOEFF";
                    break;
                case TemplateMatchingType.CcoeffNormed:
                    fileName += "_NormedCCOEFF";
                    break;
            }

            // Add preprocessing
            fileName += "_Raw";

            // Add scale
 /*           if (depthProcessor.imageScale == 1)
            {
                fileName += "_full";
            }
            else
            {
                fileName += "_half";
            }*/

            // Add extension
            fileName += ".bmp";

            saveResultImage.FileName = fileName;

            saveResultImage.ShowDialog();
        }

        private void saveResultImage_FileOk(object sender, CancelEventArgs e)
        {
            visualiser.outImage.Save(saveResultImage.FileName);
        }
    }
}
