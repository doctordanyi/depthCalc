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

        public MainWindow()
        {
            InitializeComponent();
            data = new ImageIO();
            reference = new ImageIO();
            result = new ImageIO();
            visualize = new Visualiser();

            // Using fix reference for now
            reference.read("D:\\onlab_kinect\\images\\ref\\Infrared_1280x1024_2016-02-24_22-47-40_dog.bmp");
        }
        

        // UI event handlers
        void handle_openDataImage_FileOk(object sender, CancelEventArgs e)
        {
            data.read(openDataImageDialog.FileName);

            displayBuffer = data.actBuffer.Resize(0.5, Emgu.CV.CvEnum.Inter.Nearest).ToBitmap();
            dataImage.Image = displayBuffer;

            disparityCalculator = new depthProcessor(reference.actBuffer, data.actBuffer);
        }

        private void handle_calculateDisparity_Click(object sender, EventArgs e)
        {
            disparityCalculator.calculate_displacement();
            visualize.source = disparityCalculator.result;
            visualize.drawOutputImage();

            displayBuffer = visualize.outImage.Resize(0.5, Emgu.CV.CvEnum.Inter.Nearest).ToBitmap();
            dataImage.Image = displayBuffer;
        }

        private void handle_dataImage_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            coordinates.X = coordinates.X * 2;
            coordinates.Y = coordinates.Y * 2;
            // show the match result of the clicked coordinates +/- 10 px
            int minCols;
            minCols = (coordinates.X <= 5) ? 0 : coordinates.X - 5;
            minCols = (minCols >= (disparityCalculator.data.Cols - 10)) ? disparityCalculator.data.Cols - 10 : minCols;
            // Even rows
            int x = minCols, y = coordinates.Y;
            foreach(PictureBox res in group_matchResult_1.Controls)
            {
                using (Image<Gray, float> matchResul = disparityCalculator.blockMatch(x, y))
                {
                    res.Image = visualize.visualiseMatchMap(matchResul).ToBitmap();
                }
                x++;
            }
            // Odd rows
            x = minCols;
            y = coordinates.Y+1;
            foreach (PictureBox res in group_matchResult_2.Controls)
            {
                using (Image<Gray, float> matchResul = disparityCalculator.blockMatch(x, y))
                {
                    res.Image = matchResul.Resize(100, 20, Inter.Nearest).ToBitmap();
                }
                x++;
            }

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
    }
}
