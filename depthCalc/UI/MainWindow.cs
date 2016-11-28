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
        private double onClickZoomScale = 4;
        TemplateMatchingType visualizedMatchResultTypeLeft;
        TemplateMatchingType visualizedMatchResultTypeRight;
        DepthprocessingConfig config = new Util.DepthprocessingConfig();

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
            visualizedMatchResultTypeLeft = TemplateMatchingType.Sqdiff;
            matchVisualizationSelectorRight.DataSource = Enum.GetValues(typeof(TemplateMatchingType));
            matchVisualizationSelectorRight.SelectedItem = TemplateMatchingType.CcoeffNormed;
            visualizedMatchResultTypeRight = TemplateMatchingType.CcoeffNormed;

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
            double x, y;
            x = (double)coordinates.X / dataImage.Width;
            y = (double)coordinates.Y / dataImage.Height;
            List<Bitmap> matchMapsLeft  = depthCalc.ui_image_getVisualizedMatchResult(x, y, 16, pictureBox1.Size, visualizedMatchResultTypeLeft);
            List<Bitmap> matchMapsRight = depthCalc.ui_image_getVisualizedMatchResult(x, y, 16, pictureBox1.Size, visualizedMatchResultTypeRight);
            int i = 0;
            foreach (PictureBox item in panel1.Controls)
            {
                item.Image = matchMapsLeft[i];
                i++;
            }
            i = 0;
            foreach (PictureBox item in panel2.Controls)
            {
                item.Image = matchMapsRight[i];
                i++;
            }
        }

        private void drawSelectedRegion(Point coordinates)
        {
            double relativeX, relativeY;
            relativeX = (double)coordinates.X / dataImage.Width;
            relativeY = (double)coordinates.Y / dataImage.Height;
            picture_selectedRegion.Image = depthCalc.ui_image_renderScaledBuffer(
                picture_selectedRegion.Size, 
                relativeX, relativeY, 
                currentDisplayBuffer, 
                onClickZoomScale);
        }

        private void handle_dataImage_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            drawSelectedRegion(coordinates);
            visualizeMatchResult(coordinates);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void matchVisualizationSelectorLeft_SelectedIndexChanged(object sender, EventArgs e) {
            Enum.TryParse<TemplateMatchingType>(matchVisualizationSelectorLeft.SelectedValue.ToString(), out visualizedMatchResultTypeLeft);
        }

        private void matchVisualizationSelectorRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<TemplateMatchingType>(matchVisualizationSelectorRight.SelectedValue.ToString(), out visualizedMatchResultTypeRight);
        }
    }
}
