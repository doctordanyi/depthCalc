using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System.Drawing;
using DepthCalc.Util;

namespace DepthCalc.Processing.Depthprocessing
{
    class ClusteringMatchSelection : ProcessingStep
    {
        //Lets try RANSAC
        private Rectangle windowArea;
        private const int ransacIterations = 10;

        public ClusteringMatchSelection()
        {
            stepType = SupportedSteps.Ransac;
            windowArea = new Rectangle(0, 0, 16, 1);
        }

        private class Model
        {
            public int beginDisparity;
            public int endDisparity;
            public int edgePosition;
        }

        int[] selectMostLikelyMatch(Mat matchWindow)
        {
            // Resources
            Random rndGen = new Random(); // for random selection
            int[] data = new int[matchWindow.Cols * matchWindow.Rows * matchWindow.NumberOfChannels]; // for accessible data
            matchWindow.CopyTo(data);

            // RANSAC variables
            Model bestModel, maybeModel = new Model();
            double bestError = double.MaxValue;
            // indeces
            int i_edge, i_bCol, i_eCol, i_bChoice, i_eChoice;
            // RANSAC iteration
            for (int i = 0; i < ransacIterations; i++)
            {
                // Generate random paramters
                i_edge = rndGen.Next(3, matchWindow.Width - 2);
                i_bCol = rndGen.Next(0, maybeModel.edgePosition);
                i_eCol = rndGen.Next(maybeModel.edgePosition, matchWindow.Width);
                i_bChoice = rndGen.Next(matchWindow.NumberOfChannels);
                i_eChoice = rndGen.Next(matchWindow.NumberOfChannels);

                // Populate model
                maybeModel.edgePosition = i_edge;
                maybeModel.beginDisparity = data[i_bCol * matchWindow.NumberOfChannels + i_bChoice];
                maybeModel.endDisparity = data[i_eCol * matchWindow.NumberOfChannels + i_eChoice];
            }

            return new int[3];
        }
        
        // bestfit = nul
        // besterr = something really large
        // while iterations<k {
            // maybeinliers = n randomly selected values from data
            // maybemodel = model parameters fitted to maybeinliers
            // alsoinliers = empty set
            // for every point in data not in maybeinliers {
                // if point fits maybemodel with an error smaller than t
                     // add point to alsoinliers
            // }
            // if the number of elements in alsoinliers is > d {
                // % this implies that we may have found a good model
                // % now test how good it is
                // bettermodel = model parameters fitted to all points in maybeinliers and alsoinliers
                // thiserr = a measure of how well model fits these points
                // if thiserr<besterr {
                    // bestfit = bettermodel
                    // besterr = thiserr
                // }
        // }
        // increment iterations
        // }
        // return bestfit

        public override Mat doYourJob()
        {
            outBuffer.CopyTo(dataImage);
            WindowSelector windowSelector = new WindowSelector(dataImage);
            windowSelector.WindowArea = windowArea;
            Mat roi = new Mat(dataImage, windowSelector.getWindow(500, 500));
            while (true)
            {
                selectMostLikelyMatch(roi);
            }
            return new Mat();
        }
    }
}
