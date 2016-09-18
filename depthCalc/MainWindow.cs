using System;
using System.ComponentModel;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Windows.Forms;

namespace depthCalc
{
    public partial class MainWindow : Form
    {

        private Bitmap displayBuffer;

        private ImageIO reference;
        private ImageIO data;
        private ImageIO result;

        private Visualiser visualize;

        private depthProcessor disparityCalculator;
        private bool resultReady;

        public MainWindow()
        {
            InitializeComponent();
            data = new ImageIO();
            reference = new ImageIO();
            result = new ImageIO();
            visualize = new Visualiser();
            resultReady = false;

            // Using fix reference for now
            reference.read("D:\\onlab_kinect\\images\\ref\\Infrared_1280x1024_2016-02-24_22-47-40.bmp");
        }
        

        // UI event handlers
        void handle_openDataImage_FileOk(object sender, CancelEventArgs e)
        {
            data.read(openDataImageDialog.FileName);

            displayBuffer = data.actBuffer.Resize(640,512, Emgu.CV.CvEnum.Inter.Nearest).ToBitmap();
            dataImage.Image = displayBuffer;

            disparityCalculator = new depthProcessor(reference.actBuffer, data.actBuffer);
            resultReady = false;
        }

        private void handle_calculateDisparity_Click(object sender, EventArgs e)
        {
            disparityCalculator.calculate_displacement();
            visualize.source = disparityCalculator.result;
            visualize.drawOutputImage();

            displayBuffer = visualize.outImage.Resize(640,512, Emgu.CV.CvEnum.Inter.Nearest).ToBitmap();
            dataImage.Image = displayBuffer;

            resultReady = true;
        }


        private void visualizeMatchResult(Point coordinates)
        {

            TemplateMatchingType matchMethod = disparityCalculator.matchMethod;

            // SQDIFF
            int x = coordinates.X, y = coordinates.Y;
            disparityCalculator.matchMethod = TemplateMatchingType.Sqdiff;
            foreach (PictureBox res in group_matchResult_SQDIFF.Controls)
            {
                using (Image<Gray, float> matchResul = disparityCalculator.blockMatch(x, y))
                {
                    res.Image = visualize.visualiseMatchMap(matchResul, true).ToBitmap();
                }
                x++;
            }
            // Normed SQDIFF
            x = coordinates.X;
            y = coordinates.Y;
            disparityCalculator.matchMethod = TemplateMatchingType.SqdiffNormed;
            foreach (PictureBox res in group_matchResult_NormedSQDIFF.Controls)
            {
                using (Image<Gray, float> matchResul = disparityCalculator.blockMatch(x, y))
                {
                    res.Image = visualize.visualiseMatchMap(matchResul, true).ToBitmap();
                }
                x++;
            }
            // Normed CCORR
            x = coordinates.X;
            y = coordinates.Y;
            disparityCalculator.matchMethod = TemplateMatchingType.CcorrNormed;
            foreach (PictureBox res in group_matchResult_NormedCCORR.Controls)
            {
                using (Image<Gray, float> matchResul = disparityCalculator.blockMatch(x, y))
                {
                    res.Image = visualize.visualiseMatchMap(matchResul).ToBitmap();
                }
                x++;
            }
            // CCOEFF
            x = coordinates.X;
            y = coordinates.Y;
            disparityCalculator.matchMethod = TemplateMatchingType.Ccoeff;
            foreach (PictureBox res in group_matchResult_CCOEFF.Controls)
            {
                using (Image<Gray, float> matchResul = disparityCalculator.blockMatch(x, y))
                {
                    res.Image = visualize.visualiseMatchMap(matchResul).ToBitmap();
                }
                x++;
            }
            // Normed CCOEFF
            x = coordinates.X;
            y = coordinates.Y;
            disparityCalculator.matchMethod = TemplateMatchingType.CcoeffNormed;
            foreach (PictureBox res in group_matchResult_NormedCCOEFF.Controls)
            {
                using (Image<Gray, float> matchResul = disparityCalculator.blockMatch(x, y))
                {
                    res.Image = visualize.visualiseMatchMap(matchResul).ToBitmap();
                }
                x++;
            }

            disparityCalculator.matchMethod = matchMethod;
        }

        private void visualizeSelectedRegion(Point coordinates, Point sampleRegionLocation)
        {
            int minCols, minRows;
            minCols = (coordinates.X <= 55) ? 0 : coordinates.X - 55;
            minCols = (minCols >= (disparityCalculator.scaledData.Cols - 110)) ? disparityCalculator.scaledData.Cols - 110 : minCols;
            minRows = (coordinates.Y <= 25) ? 0 : coordinates.Y - 25;
            minRows = (minRows >= (disparityCalculator.scaledData.Rows - 50)) ? disparityCalculator.scaledData.Rows - 50 : minRows;

            Rectangle region = new Rectangle(4*(sampleRegionLocation.X - minCols), 4*(sampleRegionLocation.Y - minRows), 64, 8);
            Rectangle window = new Rectangle(minCols, minRows, 110, 50);

            if (resultReady)
            {
                using (Image<Bgr, Byte> dataROI = new Image<Bgr, Byte>(visualize.outImage.GetSubRect(window).Resize(4, Inter.Nearest).ToBitmap()))
                {
                    dataROI.Draw(region, new Bgr(0, 0, 0), 3);
                    dataROI.Draw(region, new Bgr(255, 255, 255), 1);
                    picture_selectedRegion.Image = dataROI.ToBitmap();
                }
            }
            else
            {
                using (Image<Gray, Byte> dataROI = new Image<Gray, Byte>(disparityCalculator.data.GetSubRect(window).Resize(4, Inter.Nearest).ToBitmap()))
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

            coordinates.X = coordinates.X * disparityCalculator.scaledData.Width / 640;
            coordinates.Y = coordinates.Y * disparityCalculator.scaledData.Width / 640;

            // show the match result of the clicked coordinates +/- 8 px
            int minCols;
            minCols = (coordinates.X <= 8) ? 0 : coordinates.X - 8;
            minCols = (minCols >= (disparityCalculator.scaledData.Cols - 16)) ? disparityCalculator.scaledData.Cols - 16 : minCols;

            Point sampleRegionLocation = new Point(minCols, coordinates.Y);
            visualizeMatchResult(sampleRegionLocation);

            visualizeSelectedRegion(coordinates, sampleRegionLocation);

        }

        private void openReferenceToolStripMenuItem_Click(object sender, EventArgs e)
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

            disparityCalculator.matchMethod = TemplateMatchingType.Sqdiff;
        }

        private void handle_normedSQDIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            disparityCalculator.matchMethod = TemplateMatchingType.SqdiffNormed;
        }

        private void handle_cCORRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            disparityCalculator.matchMethod = TemplateMatchingType.Ccorr;
        }

        private void handle_normedCCORRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            disparityCalculator.matchMethod = TemplateMatchingType.CcorrNormed;
        }

        private void handle_cCOEFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            disparityCalculator.matchMethod = TemplateMatchingType.Ccoeff;
        }

        private void handle_normedCCOEFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            disparityCalculator.matchMethod = TemplateMatchingType.CcoeffNormed;
        }

        private void radio_half_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_full.Checked == true)
            {
                disparityCalculator.Scale(1);
            }
            if (radio_half.Checked == true)
            {
                disparityCalculator.Scale(0.5);
            }
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fileName = "result";

            // Add matching algorithm
            switch (disparityCalculator.matchMethod)
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
            if (disparityCalculator.imageScale == 1)
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
             visualize.outImage.Save(saveResultImage.FileName);
        }
    }
}
