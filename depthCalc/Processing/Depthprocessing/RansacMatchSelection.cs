﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System.Drawing;
using DepthCalc.Util;
using Emgu.CV.Structure;

namespace DepthCalc.Processing.Depthprocessing
{
    class RansacMatchSelection : ProcessingStep
    {
        //Lets try RANSAC
        private Rectangle windowArea;
        private const int ransacIterations = 1000;
        private const int threads = 8;

        public RansacMatchSelection()
        {
            stepType = SupportedSteps.Ransac;
            windowArea = new Rectangle(0, 0, 16, 1);
        }

        // 2 parameter model
        // 2 constant disparity values
        private class Model
        {
            double disparityBegin;
            double disparityEnd;
            bool isOneParModel = false;

            public Model()
            {
                disparityBegin = 0;
                disparityEnd = 0;
            }

            public Model(double disparityBegin, double disparityEnd)
            {
                this.disparityBegin = disparityBegin;
                this.disparityEnd = disparityEnd;
                if (Math.Abs(disparityEnd - disparityEnd) < 1)
                    isOneParModel = true;
            }

            public Model(int[] inliers)
            {
                // Try fitting with one parameter
                double avg = 0;
                double oneParError = 0; 
                isOneParModel = true;
                for (int i = 0; i < inliers.Length; i++)
                {
                    avg += inliers[i];
                }
                avg /= inliers.Length;
                disparityBegin = avg;
                oneParError = getModelError(inliers);
                // Try fitting with 2 parameters, but only if neccessary
                if (oneParError > 1)
                {
                    double twoParError = 0;
                    int edgeIndex = getDominantEdgePosition(inliers);
                    double avgDisp1 = 0, avgDisp2 = 0;
                    for (int i = 0; i < edgeIndex; i++)
                    {
                        avgDisp1 += inliers[i];
                    }
                    for (int i = edgeIndex; i < inliers.Length; i++)
                    {
                        avgDisp2 += inliers[i];
                    }
                    avgDisp1 /= edgeIndex;
                    avgDisp2 /= inliers.Length - edgeIndex;
                    isOneParModel = false;
                    disparityBegin = avgDisp1;
                    disparityEnd = avgDisp2;
                    twoParError = getModelError(inliers);
                    // Check which model fits better
                    if (oneParError < twoParError)
                    {
                        isOneParModel = true;
                        disparityBegin = avg;
                    }
                }
            }

            public double DisparityBegin
            {
                get
                {
                    return disparityBegin;
                }

                set
                {
                    disparityBegin = value;
                }
            }

            public double DisparityEnd
            {
                get
                {
                    return disparityEnd;
                }

                set
                {
                    disparityEnd = value;
                }
            }

            public bool IsOneParModel
            {
                get
                {
                    return isOneParModel;
                }
            }

            public static int getDominantEdgePosition(int[] inliers)
            {
                int max = 0, maxIndex = 0, act = 0;
                for (int i = 1; i < inliers.Length; i++)
                {
                    act = Math.Abs(inliers[i] - inliers[i - 1]);
                    if (act > max)
                    {
                        max = act;
                        maxIndex = i;
                    }
                }
                return maxIndex;
            }

            public double getModelError(int[] inliers)
            {
                double error = 0;
                if (isOneParModel)
                {
                    for (int i = 0; i < inliers.Length; i++)
                    {
                        error += Math.Abs(disparityBegin - inliers[i]);
                    }
                }
                else
                {
                    int edgePosition = getDominantEdgePosition(inliers);
                    for (int i = 0; i < edgePosition; i++)
                    {
                        error += Math.Abs(disparityBegin - inliers[i]);
                    }
                    for (int i = edgePosition; i < inliers.Length; i++)
                    {
                        error += Math.Abs(disparityEnd - inliers[i]);
                    }
                }
                error /= inliers.Length;
                return error;
            }
        }

        int[] chooseInliersBasedOnModel(Model model, Mat roi)
        {
            int[] data = new int[roi.Cols * roi.Rows * roi.NumberOfChannels]; // for accessible data
            roi.CopyTo(data);

            int[] inliers = new int[roi.Width];
            // Search for inliears to the first model parameter
            for (int i = 0; i < roi.Width; i++)
            {
                double err = Math.Abs(model.DisparityBegin - data[i * roi.NumberOfChannels]);
                inliers[i] = data[i * roi.NumberOfChannels];
                for (int j = 1; j < roi.NumberOfChannels; j++)
                {
                    double newErr = Math.Abs(model.DisparityBegin - data[i * roi.NumberOfChannels + j]);
                    if (newErr < err)
                    {
                        err = newErr;
                        inliers[i] = data[i * roi.NumberOfChannels + j];
                    }
                }
            }
            if(!model.IsOneParModel)
            {
                int[] inliersEnd = new int[roi.Width];
                // Search for inliears to the second model parameter
                for (int i = 0; i < roi.Width; i++)
                {
                    double err = Math.Abs(model.DisparityEnd - data[i * roi.NumberOfChannels]);
                    inliersEnd[i] = data[i * roi.NumberOfChannels];
                    for (int j = 1; j < roi.NumberOfChannels; j++)
                    {
                        double newErr = Math.Abs(model.DisparityEnd - data[i * roi.NumberOfChannels + j]);
                        if (newErr < err)
                        {
                            err = newErr;
                            inliersEnd[i] = data[i * roi.NumberOfChannels + j];
                        }
                    }
                }
                // Try to find the optimal cut
                double cutError = double.MaxValue;
                double actError = 0;
                for (int i = 1; i < roi.Width; i++)
                {
                    actError = model.getModelError(inliers);
                    if (cutError < actError)
                    {
                        break;
                    }
                    cutError = actError;
                    inliers[roi.Width - i] = inliersEnd[roi.Width - i];
                }
            }
            return inliers;
        }

        List<int> getInliersOfModel(Model model, Mat roi)
        {
            int[] data = new int[roi.Cols * roi.Rows * roi.NumberOfChannels]; // for accessible data
            roi.CopyTo(data);

            List<int> inliers = new List<int>();
            // Search for inliears to the first model parameter
            for (int i = 0; i < roi.Width; i++)
            {
                double err = Math.Abs(model.DisparityBegin - data[i * roi.NumberOfChannels]);
                int j_max = 0;
                for (int j = 1; j < roi.NumberOfChannels; j++)
                {
                    double newErr = Math.Abs(model.DisparityBegin - data[i * roi.NumberOfChannels + j]);
                    if (newErr < err)
                    {
                        err = newErr;
                        j_max = j;
                    }
                }
                if (err < 4)
                    inliers.Add(data[i * roi.NumberOfChannels + j_max]);
            }
            if (!model.IsOneParModel)
            {
                for (int i = 0; i < roi.Width; i++)
                {
                    double err = Math.Abs(model.DisparityBegin - data[i * roi.NumberOfChannels]);
                    int j_max = 0;
                    for (int j = 1; j < roi.NumberOfChannels; j++)
                    {
                        double newErr = Math.Abs(model.DisparityBegin - data[i * roi.NumberOfChannels + j]);
                        if (newErr < err)
                        {
                            err = newErr;
                            j_max = j;
                        }
                    }
                    if (err < 4)
                        inliers.Add(data[i * roi.NumberOfChannels + j_max]);
                }
            }
            return inliers;
        }

        int[] selectMostLikelyMatch(Mat matchWindow)
        {
            // Check how good the first maximums match
            int[] bestInliers = new int[matchWindow.Width];
            Mat bestMatch = new Mat();
            CvInvoke.ExtractChannel(matchWindow, bestMatch, 0);
            bestMatch.CopyTo(bestInliers);

            Model bestModel = new Model(bestInliers);
            double bestError = bestModel.getModelError(bestInliers);

            // If the error is low, no need for RANSAC
            if (bestError < 1)
                return bestInliers;

            // Resources
            Random rndGen = new Random(); // for random selection
            int[] data = new int[matchWindow.Cols * matchWindow.Rows * matchWindow.NumberOfChannels]; // for accessible data
            matchWindow.CopyTo(data);

            // RANSAC variables

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
                int begintDisp = data[i_bCol * matchWindow.NumberOfChannels + i_bChoice];
                int endDisp = data[i_eCol * matchWindow.NumberOfChannels + i_eChoice];
                Model maybeModel = new Model(begintDisp, endDisp);

                List<int> alsoInliers = getInliersOfModel(maybeModel, matchWindow);
                if(alsoInliers.Count > 14)
                {
                    Model betterModel = new Model(alsoInliers.ToArray());
                    double thisError = betterModel.getModelError(alsoInliers.ToArray());
                    if (thisError < bestError)
                    {
                        bestModel = betterModel;
                        bestError = thisError;
                    }
                }
            }

            bestInliers = chooseInliersBasedOnModel(bestModel, matchWindow);
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
            dataImage = new Mat();
            referenceImage = new Mat();
            outBuffer.CopyTo(dataImage);
            outBuffer = new Mat(dataImage.Size, Emgu.CV.CvEnum.DepthType.Cv32S, 1);
            int[] result = new int[dataImage.Width * dataImage.Height];
            Parallel.For(0, threads, submat =>
              {
                  int startRow = submat * (dataImage.Rows / threads);
                  int endRow;
                  if ((submat + 1) * (dataImage.Rows / threads) > dataImage.Rows)
                  {
                      endRow = dataImage.Rows;
                  }
                  else
                  {
                      endRow = (submat + 1) * (dataImage.Rows / threads);
                  }
                  WindowSelector windowSelector = new WindowSelector(dataImage);
                  windowSelector.WindowArea = windowArea;
                  int[] selectedMax;
                  for (int y = startRow; y < endRow; y++)
                  {
                      for (int x = 0; x < dataImage.Width; x++)
                      {
                          Rectangle window = windowSelector.getWindow(x, y);
                          using (Mat matchWindow = new Mat(dataImage, window))
                          {
                              selectedMax = selectMostLikelyMatch(matchWindow);
                              selectedMax.CopyTo(result, (y * dataImage.Width + window.X));
                          }
                      }
                  }
              });
            outBuffer.SetTo<int>(result);
            return outBuffer;
        }
    }
}