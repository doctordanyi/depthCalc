﻿using System;
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

        private Mat displayBuffer;

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
            depthProcessor = new DepthProcessor();

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
            displayBuffer = new Mat();

            resultReady = false;
        }
        

        private void updateImageView(SupportedBuffers buffer)
        {
            switch (buffer)
            {
                case SupportedBuffers.rawData:
                    displayBuffer = rawData;
                    break;
                case SupportedBuffers.rawReference:
                    displayBuffer = rawReference;
                    break;
                case SupportedBuffers.preprocessedData:
                    displayBuffer = preprocData;
                    break;
                case SupportedBuffers.preprocessedReference:
                    displayBuffer = preprocReference;
                    break;
                case SupportedBuffers.Disparity:
                    displayBuffer = rawDisparity;
                    break;
                case SupportedBuffers.visalisedDispartiy:
                    displayBuffer = visualDisparity;
                    break;
                case SupportedBuffers.postprocessedDisparity:
                    displayBuffer = postprocDisparity;
                    break;
                default:
                    break;
            }
            dataImage.Image = displayBuffer.ToImage<Rgb, Byte>().Resize(dataImage.Width,dataImage.Height, Inter.Nearest).ToBitmap();
        }


        private void visualizeMatchResult(Point coordinates)
        {

            TemplateMatchingType matchMethod = depthProcessor.matchMethod;

            // SQDIFF
            int x = coordinates.X, y = coordinates.Y;
            depthProcessor.matchMethod = TemplateMatchingType.Sqdiff;
            foreach (PictureBox res in group_matchResult_SQDIFF.Controls)
            {
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
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
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
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
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
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
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
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
                using (Mat matchResul = depthProcessor.blockMatch(x, y))
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

            coordinates.X = coordinates.X * (preprocData.Width / dataImage.Width);
            coordinates.Y = coordinates.Y * (preprocData.Height / dataImage.Height);

            // show the match result of the clicked coordinates +/- 8 px
            int minCols;
            minCols = (coordinates.X <= 8) ? 0 : coordinates.X - 8;
            minCols = (minCols >= (displayBuffer.Cols - 16)) ? displayBuffer.Cols - 16 : minCols;

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
