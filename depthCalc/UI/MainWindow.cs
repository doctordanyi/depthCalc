using System;
using System.ComponentModel;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Windows.Forms;

namespace depthCalc
{
    partial class MainWindow
    {
        // Read/write/visualise images
        private ImageIO imageIO;
        private Visualiser visualiser;

        // Container for user defined parameters
        private ParamContainer paramContainer;

        // Classes responsible for processing
        private PreDepthProcessor preprocessor;
        private DepthProcessor depthProcessor;
        private PostDepthProcessor postprocessor;

        // Raw input images
        private Mat rawReference;
        private Mat rawData;
        // Preprocessed images
        private Mat preprocReference;
        private Mat preprocData;
        // Disparity map
        private Mat rawDisparity;
        // Postprocessed disparity map
        private Mat postprocDisparity;
        // Visualised disparity map
        private Mat visualDisparity;

        enum SupportedBuffers
        {
            rawData,
            rawReference,
            preprocessedData,
            preprocessedReference,
            Disparity,
            visalisedDispartiy,
            postprocessedDisparity
        }


        private bool resultReady;

        public MainWindow()
        {
            InitializeComponent();

            preprocessor = new PreDepthProcessor();

            visualiser = new Visualiser();
            imageIO = new ImageIO();

            paramContainer = new ParamContainer();

            rawReference = new Mat();
            rawData = new Mat();
            preprocReference = new Mat();
            preprocData = new Mat();
            rawDisparity = new Mat();
            postprocDisparity = new Mat();
            visualDisparity = new Mat();

            resultReady = false;
        }
        

        private void updateImageView(SupportedBuffers buffer)
        {
            Mat displayBuffer = new Mat();
            switch (buffer)
            {
                case SupportedBuffers.rawData:
                    CvInvoke.Resize(rawData, displayBuffer, dataImage.Size, 0, 0, Inter.Nearest);
                    break;
                case SupportedBuffers.rawReference:
                    CvInvoke.Resize(rawReference, displayBuffer, dataImage.Size, 0, 0, Inter.Nearest);
                    break;
                case SupportedBuffers.preprocessedData:
                    CvInvoke.Resize(preprocData, displayBuffer, dataImage.Size, 0, 0, Inter.Nearest);
                    break;
                case SupportedBuffers.preprocessedReference:
                    CvInvoke.Resize(preprocReference, displayBuffer, dataImage.Size, 0, 0, Inter.Nearest);
                    break;
                case SupportedBuffers.Disparity:
                    CvInvoke.Resize(rawDisparity, displayBuffer, dataImage.Size, 0, 0, Inter.Nearest);
                    break;
                case SupportedBuffers.visalisedDispartiy:
                    CvInvoke.Resize(visualDisparity, displayBuffer, dataImage.Size, 0, 0, Inter.Nearest);
                    break;
                case SupportedBuffers.postprocessedDisparity:
                    CvInvoke.Resize(postprocDisparity, displayBuffer, dataImage.Size, 0, 0, Inter.Nearest);
                    break;
                default:
                    break;
            }
            dataImage.Image = displayBuffer.ToImage<Rgb, Byte>().ToBitmap();
        }


        private void visualizeMatchResult(Point coordinates)
        {

            TemplateMatchingType matchMethod = depthProcessor.matchMethod;

            // SQDIFF
            int x = coordinates.X, y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.Sqdiff;
            foreach (PictureBox res in group_matchResult_SQDIFF.Controls)
            {
                using (Image<Gray, float> matchResul = depthProcessor.blockMatch(x, y))
                {
                    res.Image = visualiser.visualiseMatchMap(matchResul, true).ToBitmap();
                }
                x++;
            }
            // Normed SQDIFF
            x = coordinates.X;
            y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.SqdiffNormed;
            foreach (PictureBox res in group_matchResult_NormedSQDIFF.Controls)
            {
                using (Image<Gray, float> matchResul = depthProcessor.blockMatch(x, y))
                {
                    res.Image = visualiser.visualiseMatchMap(matchResul, true).ToBitmap();
                }
                x++;
            }
            // Normed CCORR
            x = coordinates.X;
            y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.CcorrNormed;
            foreach (PictureBox res in group_matchResult_NormedCCORR.Controls)
            {
                using (Image<Gray, float> matchResul = depthProcessor.blockMatch(x, y))
                {
                    res.Image = visualiser.visualiseMatchMap(matchResul).ToBitmap();
                }
                x++;
            }
            // CCOEFF
            x = coordinates.X;
            y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.Ccoeff;
            foreach (PictureBox res in group_matchResult_CCOEFF.Controls)
            {
                using (Image<Gray, float> matchResul = depthProcessor.blockMatch(x, y))
                {
                    res.Image = visualiser.visualiseMatchMap(matchResul).ToBitmap();
                }
                x++;
            }
            // Normed CCOEFF
            x = coordinates.X;
            y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.CcoeffNormed;
            foreach (PictureBox res in group_matchResult_NormedCCOEFF.Controls)
            {
                using (Image<Gray, float> matchResul = depthProcessor.blockMatch(x, y))
                {
                    res.Image = visualiser.visualiseMatchMap(matchResul).ToBitmap();
                }
                x++;
            }

            depthProcessor.matchMethod = matchMethod;
        }

        private void visualizeSelectedRegion(Point coordinates, Point sampleRegionLocation)
        {
            int minCols, minRows;
            minCols = (coordinates.X <= 55) ? 0 : coordinates.X - 55;
            minCols = (minCols >= (depthProcessor.scaledData.Cols - 110)) ? depthProcessor.scaledData.Cols - 110 : minCols;
            minRows = (coordinates.Y <= 25) ? 0 : coordinates.Y - 25;
            minRows = (minRows >= (depthProcessor.scaledData.Rows - 50)) ? depthProcessor.scaledData.Rows - 50 : minRows;

            Rectangle region = new Rectangle(4*(sampleRegionLocation.X - minCols), 4*(sampleRegionLocation.Y - minRows), 64, 8);
            Rectangle window = new Rectangle(minCols, minRows, 110, 50);

            if (resultReady)
            {
                using (Image<Bgr, Byte> dataROI = new Image<Bgr, Byte>(visualiser.outImage.GetSubRect(window).Resize(4, Inter.Nearest).ToBitmap()))
                {
                    dataROI.Draw(region, new Bgr(0, 0, 0), 3);
                    dataROI.Draw(region, new Bgr(255, 255, 255), 1);
                    picture_selectedRegion.Image = dataROI.ToBitmap();
                }
            }
            else
            {
                using (Image<Gray, Byte> dataROI = new Image<Gray, Byte>(depthProcessor.data.GetSubRect(window).Resize(4, Inter.Nearest).ToBitmap()))
                {
                    dataROI.Draw(region, new Gray(0), 3);
                    dataROI.Draw(region, new Gray(255), 1);

                    picture_selectedRegion.Image = dataROI.ToBitmap();
                }
            }

        }

        private void handle_dataImage_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            coordinates.X = coordinates.X * depthProcessor.scaledData.Width / 640;
            coordinates.Y = coordinates.Y * depthProcessor.scaledData.Width / 640;

            // show the match result of the clicked coordinates +/- 8 px
            int minCols;
            minCols = (coordinates.X <= 8) ? 0 : coordinates.X - 8;
            minCols = (minCols >= (depthProcessor.scaledData.Cols - 16)) ? depthProcessor.scaledData.Cols - 16 : minCols;

            Point sampleRegionLocation = new Point(minCols, coordinates.Y);
            visualizeMatchResult(sampleRegionLocation);

            visualizeSelectedRegion(coordinates, sampleRegionLocation);

        }

        private void openReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openReferenceImageDialog.ShowDialog();
        }

        private void openDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDataImageDialog.ShowDialog();
        }

        private void handle_sQDIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if(item != sender)
                    item.Checked = false;
            }

            depthProcessor.matchMethod = TemplateMatchingType.Sqdiff;
        }

        private void handle_normedSQDIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthProcessor.matchMethod = TemplateMatchingType.SqdiffNormed;
        }

        private void handle_cCORRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthProcessor.matchMethod = TemplateMatchingType.Ccorr;
        }

        private void handle_normedCCORRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthProcessor.matchMethod = TemplateMatchingType.CcorrNormed;
        }

        private void handle_cCOEFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthProcessor.matchMethod = TemplateMatchingType.Ccoeff;
        }

        private void handle_normedCCOEFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthProcessor.matchMethod = TemplateMatchingType.CcoeffNormed;
        }


    }
}
