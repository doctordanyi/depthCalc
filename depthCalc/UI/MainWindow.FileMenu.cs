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
        void handle_openDataImage_FileOk(object sender, CancelEventArgs e)
        {
            Mat displayBuffer = new Mat();

            imageIO.read(openDataImageDialog.FileName, out rawData);
            CvInvoke.Resize(rawData, displayBuffer, new Size(640, 512), 0, 0, Inter.Nearest);

            dataImage.Image = displayBuffer.ToImage<Rgb, Byte>().ToBitmap();

        }

        private void openReferenceImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            Mat displayBuffer = new Mat();

            imageIO.read(openReferenceImageDialog.FileName, out rawReference);
            CvInvoke.Resize(rawReference, displayBuffer, new Size(640, 512), 0, 0, Inter.Nearest);

            dataImage.Image = displayBuffer.ToImage<Rgb, Byte>().ToBitmap();
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
            if (depthProcessor.imageScale == 1)
            {
                fileName += "_full";
            }
            else
            {
                fileName += "_half";
            }

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
