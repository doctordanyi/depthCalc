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
        SupportedBuffers currentDisplayBuffer;

        // Main processing block
        private Processing.DepthCalc depthCalc;

        private Mat displayBuffer;


        public MainWindow()
        {
            depthCalc = new Processing.DepthCalc();
            paramContainer = new ParamContainer();
            displayBuffer = new Mat();
            InitializeComponent();
            depthprocListView.Resize += DepthprocListView_Resize;
            preprocListView.Resize += PreprocListView_Resize;

            matchMethodSelector.DataSource = Enum.GetValues(typeof(TemplateMatchingType));
            matchMethodSelector.SelectedItem = TemplateMatchingType.CcoeffNormed;

            matchVisualizationSelectorLeft.DataSource = Enum.GetValues(typeof(TemplateMatchingType));
            matchVisualizationSelectorLeft.SelectedItem = TemplateMatchingType.Sqdiff;
            matchVisualizationSelectorRight.DataSource = Enum.GetValues(typeof(TemplateMatchingType));
            matchVisualizationSelectorRight.SelectedItem = TemplateMatchingType.CcoeffNormed;

            updatePreprocessingStepsListView();
            updateDepthprocessingStepsListView();
        }



        private void updateImageView(SupportedBuffers buffer)
        {
            dataImage.Image = depthCalc.ui_image_renderBuffer(dataImage.Size, buffer);
            currentDisplayBuffer = buffer;
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

        private void drawSelectedRegion(Point coordinates)
        {
            double relativeX, relativeY;
            relativeX = (double)coordinates.X / dataImage.Width;
            relativeY = (double)coordinates.Y / dataImage.Height;
            picture_selectedRegion.Image = depthCalc.ui_image_renderScaledBuffer(picture_selectedRegion.Size, relativeX, relativeY, currentDisplayBuffer, 4);
        }

        private void handle_dataImage_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            drawSelectedRegion(coordinates);
            // visualizeMatchResult(sampleRegionLocation);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
