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
        private const int ransacIterations = 100;

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

        int[] chooseInliersBasedOnModel(Model model, Mat roi)
        {
            int[] data = new int[roi.Cols * roi.Rows * roi.NumberOfChannels]; // for accessible data
            roi.CopyTo(data);
            int[] inliers = new int[roi.Width];
            for (int i = 0; i < model.edgePosition; i++)
            {
                int err = Math.Abs(model.beginDisparity - data[i * roi.NumberOfChannels]);
                for (int j = 1; j < roi.NumberOfChannels; j++)
                {
                    int newErr = Math.Abs(model.beginDisparity - data[i * roi.NumberOfChannels + j]);
                    inliers[i] = data[i * roi.NumberOfChannels];
                    if(newErr < err)
                    {
                        err = newErr;
                        inliers[i] = data[i * roi.NumberOfChannels + j];
                    }
                }
            }
            for (int i = model.edgePosition; i < roi.Width; i++)
            {
                int err = Math.Abs(model.endDisparity - data[i * roi.NumberOfChannels]);
                for (int j = 1; j < roi.NumberOfChannels; j++)
                {
                    int newErr = Math.Abs(model.endDisparity - data[i * roi.NumberOfChannels + j]);
                    inliers[i] = data[i * roi.NumberOfChannels];
                    if(newErr < err)
                    {
                        err = newErr;
                        inliers[i] = data[i * roi.NumberOfChannels + j];
                    }
                }
            }
            return inliers;
        }

        int getModelError(Model model, int[] inliers)
        {
            int error = 0;
            for (int i = 0; i < model.edgePosition; i++)
            {
                error += Math.Abs(model.beginDisparity - inliers[i]);
            }
            for (int i = model.edgePosition; i < inliers.Length; i++)
            {
                error += Math.Abs(model.endDisparity - inliers[i]);
            }
            return error;
        }

        bool fitModelToInliers(int[] inliers, out Model model)
        {
            Model betterModel = new Model();
            int[] dInliers = new int[inliers.Length]; // derivative
            for (int i = 0; i < (inliers.Length - 1); i++)
            {
                dInliers[i] = inliers[i] - inliers[i + 1];
            }
            dInliers[inliers.Length - 1] = 0;

            model = betterModel;
            return true;
        }


        int[] selectMostLikelyMatch(Mat matchWindow)
        {
            // Resources
            Random rndGen = new Random(); // for random selection
            int[] data = new int[matchWindow.Cols * matchWindow.Rows * matchWindow.NumberOfChannels]; // for accessible data
            matchWindow.CopyTo(data);

            // RANSAC variables
            Model bestModel = new Model(), maybeModel = new Model();
            bestModel.beginDisparity = data[0];
            bestModel.edgePosition = matchWindow.Width / 2;
            bestModel.endDisparity = data[(matchWindow.Width - 1) * matchWindow.NumberOfChannels];
            int[] bestInliers = chooseInliersBasedOnModel(bestModel, matchWindow);
            int bestError = getModelError(bestModel, bestInliers);
            // indices
            int i_edge, i_bCol, i_eCol, i_bChoice, i_eChoice;
            // RANSAC iteration
            for (int i = 0; i < ransacIterations; i++)
            {
                // Generate random paramters
                i_edge = rndGen.Next(3, matchWindow.Width - 2);
                i_bCol = rndGen.Next(0, i_edge);
                i_eCol = rndGen.Next(i_edge, matchWindow.Width);
                i_bChoice = rndGen.Next(matchWindow.NumberOfChannels);
                i_eChoice = rndGen.Next(matchWindow.NumberOfChannels);

                // Populate model
                maybeModel.edgePosition = i_edge;
                maybeModel.beginDisparity = data[i_bCol * matchWindow.NumberOfChannels + i_bChoice];
                maybeModel.endDisparity = data[i_eCol * matchWindow.NumberOfChannels + i_eChoice];

                // Get inliers  &error of the model
                int[] inliers = chooseInliersBasedOnModel(maybeModel, matchWindow);
                int error = getModelError(maybeModel, inliers);
                fitModelToInliers(inliers);

                if (error < bestError)
                {
                    bestError = error;
                    bestInliers = inliers;
                    bestModel = maybeModel;
                }
            }

            return bestInliers;
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
