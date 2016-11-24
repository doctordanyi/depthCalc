using System;
using System.ComponentModel;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Windows.Forms;
using System.Collections.Generic;
using DepthCalc.Processing;
using DepthCalc.Util;

namespace DepthCalc.UI
{
    partial class MainWindow
    {
        // Container for user defined parameters
        private ParamContainer paramContainer;

        // Main processing block
        private Processing.DepthCalc depthCalc;

        private Mat displayBuffer;


        public MainWindow()
        {
            depthCalc = new Processing.DepthCalc();
            paramContainer = new ParamContainer();
            displayBuffer = new Mat();
            InitializeComponent();
            updatePreprocessingStepsListView();
        }
        

        private void updateImageView(SupportedBuffers buffer)
        {
            dataImage.Image = depthCalc.ui_image_renderBuffer(dataImage.Size, buffer);
        }


        private void visualizeMatchResult(Point coordinates)
        {
 /*           TemplateMatchingType matchMethod = depthProcessor.matchMethod;

            // SQDIFF
            int x = coordinates.X, y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.Sqdiff;
            foreach (PictureBox res in group_matchResult_SQDIFF.Controls)
            {
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
                {
                    List<MaxElement> maxLocs = depthProcessor.getStrongMaximums(matchResul);
                    res.Image = visualiser.visualiseMatchMap(matchResul, maxLocs, true).ToBitmap();
                }
                x++;
            }
            // Normed SQDIFF
            x = coordinates.X;
            y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.SqdiffNormed;
            foreach (PictureBox res in group_matchResult_NormedSQDIFF.Controls)
            {
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
                {
                    List<MaxElement> maxLocs = depthProcessor.getStrongMaximums(matchResul);
                    res.Image = visualiser.visualiseMatchMap(matchResul, maxLocs, true).ToBitmap();
                }
                x++;
            }
            // Normed CCORR
            x = coordinates.X;
            y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.CcorrNormed;
            foreach (PictureBox res in group_matchResult_NormedCCORR.Controls)
            {
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
                {
                    List<MaxElement> maxLocs = depthProcessor.getStrongMaximums(matchResul);
                    res.Image = visualiser.visualiseMatchMap(matchResul, maxLocs, false).ToBitmap();
                }
                x++;
            }
            // CCOEFF
            x = coordinates.X;
            y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.Ccoeff;
            foreach (PictureBox res in group_matchResult_CCOEFF.Controls)
            {
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
                {
                    List<MaxElement> maxLocs = depthProcessor.getStrongMaximums(matchResul);
                    res.Image = visualiser.visualiseMatchMap(matchResul, maxLocs, false).ToBitmap();
                }
                x++;
            }
            // Normed CCOEFF
            x = coordinates.X;
            y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.CcoeffNormed;
            int[] disp = depthProcessor.improveMatchQuality(y, x);
            Mat asd = new Mat();
            foreach (PictureBox res in group_matchResult_NormedCCOEFF.Controls)
            {
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
                {
                    List<MaxElement> maxLocs = depthProcessor.getStrongMaximums(matchResul);
                    maxLocs.Add(new MaxElement(disp[x-coordinates.X], 0));
                    res.Image = visualiser.visualiseMatchMap(matchResul, maxLocs, false).ToBitmap();
                }
                x++;
            }

            for (x = 0; x < (preprocData.Width - 7); x++)
            {
               using (Mat matchResult = depthProcessor.blockMatch(x, y))
                 {
                     asd.PushBack(matchResult);
                 }
             }
             depthProcessor.matchMethod = matchMethod;
             asd.ToImage<Gray, float>().ToBitmap().Save("asd.png");
             */
        }

        private void visualizeSelectedRegion(Point coordinates, Point sampleRegionLocation)
        {
            int minCols, minRows;
            minCols = (coordinates.X <= 55) ? 0 : coordinates.X - 55;
            minCols = (minCols >= (displayBuffer.Cols - 110)) ? displayBuffer.Cols - 110 : minCols;
            minRows = (coordinates.Y <= 25) ? 0 : coordinates.Y - 25;
            minRows = (minRows >= (displayBuffer.Rows - 50)) ? displayBuffer.Rows - 50 : minRows;

            Rectangle region = new Rectangle(4*(sampleRegionLocation.X - minCols), 4*(sampleRegionLocation.Y - minRows), 64, 8);
            Rectangle window = new Rectangle(minCols, minRows, 110, 50);


            using (Mat dataROI = new Mat(displayBuffer, window))
            {
                CvInvoke.Rectangle(dataROI, region, new MCvScalar(0,0,0), 3);
                CvInvoke.Rectangle(dataROI, region, new MCvScalar(255, 255, 255), 3);

                picture_selectedRegion.Image = dataROI.ToImage<Rgb, byte>().Resize(picture_selectedRegion.Width,picture_selectedRegion.Height, Inter.Nearest).ToBitmap();
            }
        }

        private void handle_dataImage_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            // coordinates.X = coordinates.X * (preprocData.Width / dataImage.Width);
            // coordinates.Y = coordinates.Y * (preprocData.Height / dataImage.Height);

            // show the match result of the clicked coordinates +/- 8 px
            int minCols;
            minCols = (coordinates.X <= 8) ? 0 : coordinates.X - 8;
            minCols = (minCols >= (displayBuffer.Cols - 16)) ? displayBuffer.Cols - 16 : minCols;

            Point sampleRegionLocation = new Point(minCols, coordinates.Y);
            visualizeMatchResult(sampleRegionLocation);

            visualizeSelectedRegion(coordinates, sampleRegionLocation);

        }


        private void handle_sQDIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if(item != sender)
                    item.Checked = false;
            }

            depthCalc.ui_conf_setMatchMethod(TemplateMatchingType.Sqdiff);
        }

        private void handle_normedSQDIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthCalc.ui_conf_setMatchMethod(TemplateMatchingType.SqdiffNormed);
        }

        private void handle_cCORRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthCalc.ui_conf_setMatchMethod(TemplateMatchingType.Ccorr);
        }

        private void handle_normedCCORRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthCalc.ui_conf_setMatchMethod(TemplateMatchingType.CcorrNormed);
        }

        private void handle_cCOEFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthCalc.ui_conf_setMatchMethod(TemplateMatchingType.Ccoeff);
        }

        private void handle_normedCCOEFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in matchMethodToolStripMenuItem.DropDownItems)
            {
                if (item != sender)
                    item.Checked = false;
            }

            depthCalc.ui_conf_setMatchMethod(TemplateMatchingType.CcoeffNormed);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
