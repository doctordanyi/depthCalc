using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DepthCalc.Util;
using System.ComponentModel;
using System.Threading;
using System.Drawing;
using Emgu.CV.Util;

namespace DepthCalc.Processing
{
    class DepthCalc
    {
        // Read/write/visualise images
        private ImageIO imageIO;

        // Processing Queues
        private ProcessingQueue preprocessingQueue;
        private ProcessingQueue depthprocessingQueue;
        private ProcessingQueue postprocessingQueue;

        // Image buffers
        private Mat rawReference;
        private Mat rawData;
        private Mat preprocReference;
        private Mat preprocData;
        private Mat rawDisparity;
        private Mat postprocDisparity;
        private Mat visualDisparity;

        private BufferStates bufferStates;
        private SourceFilePaths sourceFilePaths;
        private DepthprocessingConfig depthprocessingConfig;

        // Constructor begin
        public DepthCalc()
        {
            imageIO = new ImageIO();
            bufferStates = new BufferStates();
            sourceFilePaths = new SourceFilePaths();
            depthprocessingConfig = new DepthprocessingConfig();
            depthprocessingConfig.MatchMethod = TemplateMatchingType.CcoeffNormed;
            depthprocessingConfig.SampleArea = new Rectangle(0, 0, 7, 7);
            depthprocessingConfig.WindowArea = new Rectangle(0, 0, 100, 7);

            // Initialize processing queues
            preprocessingQueue = new ProcessingQueue();
            preprocessingQueue.addStep(new Preprocessing.Identity());
            preprocessingQueue.addStep(new Preprocessing.Normalize());
            depthprocessingQueue = new ProcessingQueue();
            depthprocessingQueue.addStep(new Depthprocessing.ImageDisparity(depthprocessingConfig));
            // depthprocessingQueue.addStep(new Depthprocessing.CumulateClustering(depthprocessingConfig));
            // depthprocessingQueue.addStep(new Depthprocessing.RansacMatchSelection());
            postprocessingQueue = new ProcessingQueue();
            postprocessingQueue.addStep(new Postprocessing.VisualizeDisparity());
        }
        // Constructor end

        // Private methods
        private Mat getSelectedBuffer(SupportedBuffers buffer)
        {
            switch (buffer)
            {
                case SupportedBuffers.rawData:
                    if (!bufferStates.rawDataReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    return rawData;
                case SupportedBuffers.rawReference:
                    if (!bufferStates.rawReferenceReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    return rawReference;
                case SupportedBuffers.preprocessedData:
                    if (!bufferStates.preprocDataReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    return preprocData;
                case SupportedBuffers.preprocessedReference:
                    if (!bufferStates.preprocReferenceReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    return preprocReference;
                case SupportedBuffers.Disparity:
                    if (!bufferStates.rawDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    return rawDisparity;
                case SupportedBuffers.visalisedDispartiy:
                    if (!bufferStates.visualDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    return visualDisparity;
                case SupportedBuffers.postprocessedDisparity:
                    if (!bufferStates.postprocDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    return postprocDisparity;
                default:
                    throw new Exception("Unsupported buffer type");
            }
        }

        // UI interface functions begin

        public int ui_file_openDataImage(string path)
        {
            if (rawData != null)
            {
                rawData.Dispose();
            }
            rawData = new Mat();
            imageIO.read(path, out rawData);
            bufferStates.rawDataReady = true;
            sourceFilePaths.data = path;
            return 0;
        }

        public int ui_file_openReferenceImage(string path)
        {
            if (rawReference != null)
            {
                rawReference.Dispose();
            }
            rawReference = new Mat();
            imageIO.read(path, out rawReference);
            bufferStates.rawReferenceReady = true;
            sourceFilePaths.reference = path;
            return 0;
        }

        public int ui_file_saveVisualResult(string path)
        {
            if (bufferStates.visualDisparityReady)
            {
                imageIO.write(path, visualDisparity);
            }
            else
            {
                throw new Exception("Requested buffer not available");
            }
            return 0;
        }

        public Bitmap ui_image_renderBuffer(Size size, SupportedBuffers buffer)
        {
            Image<Rgb, Byte> renderedImage;
            Mat selectedBuffer = getSelectedBuffer(buffer);
            double scale;
            renderedImage = selectedBuffer.ToImage<Rgb, Byte>();
            scale = (double)size.Width / selectedBuffer.Width;
            return renderedImage.Resize(scale, Inter.Linear).ToBitmap();
        }

        public Bitmap ui_image_renderScaledBuffer(
            Size canvasSize,
            double x, double y,
            SupportedBuffers buffer,
            double scale)
        {
            Image<Rgb, Byte> renderedImage;
            Mat selectedBuffer = getSelectedBuffer(buffer);
            WindowSelector windowSelector = new WindowSelector(selectedBuffer);
            windowSelector.WindowArea = new System.Drawing.Rectangle(0, 0, (int)(canvasSize.Width / scale), (int)(canvasSize.Height / scale));
            Mat selectedRegion = new Mat(selectedBuffer, windowSelector.getWindow((int)(selectedBuffer.Width*x), (int)(selectedBuffer.Height * y)));
            renderedImage = selectedRegion.ToImage<Rgb, Byte>();
            return renderedImage.Resize(scale, Inter.Nearest).ToBitmap();
        }

        public List<Bitmap> ui_image_getVisualizedMatchResult(double x, double y, int width, Size canvasSize, TemplateMatchingType matchMethod)
        {
            if(!bufferStates.preprocDataReady || !bufferStates.preprocReferenceReady)
            {
                throw new Exception("Required buffer unavailable");
            }
            
            List<Bitmap> matchMapList = new List<Bitmap>();
            WindowSelector windowSelector = new WindowSelector(preprocData);
            windowSelector.WindowArea = new Rectangle(0, 0, width, 1);
            Rectangle ROI = windowSelector.getWindow((int)(x * preprocData.Width), (int)(y * preprocData.Height));
            bool markMin = false;
            if (matchMethod == TemplateMatchingType.Sqdiff || matchMethod == TemplateMatchingType.SqdiffNormed)
            {
                markMin = true;
            }

            using (Depthprocessing.MaximaFind imageDisparity = new Depthprocessing.MaximaFind(depthprocessingConfig))
            using (Depthprocessing.CumulateClustering cumulative = new Depthprocessing.CumulateClustering(depthprocessingConfig))
            using (Postprocessing.DrawMatchMap drawMatchMap = new Postprocessing.DrawMatchMap())
            {
                imageDisparity.setDataImage(preprocData);
                imageDisparity.setReferenceImage(preprocReference);
                cumulative.setDataImage(preprocData);
                cumulative.setReferenceImage(preprocReference);
                imageDisparity.matchMethod = matchMethod;
                drawMatchMap.CanvasSize = canvasSize;
                Mat matchMap = new Mat();
                int[] peaks;
                for (int X = ROI.Left; X < (ROI.Right - 1); X++)
                {
                    matchMap = imageDisparity.blockMatch(X, ROI.Y);
                    peaks = imageDisparity.getDominantPeaks(matchMap);
                    drawMatchMap.setDataImage(matchMap);
                    matchMapList.Add(drawMatchMap.visualiseMatchMap(peaks, markMin).ToBitmap());
                }
                    matchMap = cumulative.getCumulativeMatch(ROI);
                    peaks = imageDisparity.getDominantPeaks(matchMap);
                    drawMatchMap.setDataImage(matchMap);
                    matchMapList.Add(drawMatchMap.visualiseMatchMap(peaks, markMin).Flip(FlipType.Vertical).ToBitmap());
            }
            return matchMapList;
        }

        public BufferStates ui_state_getBufferStates()
        {
            return bufferStates;
        }

        public List<String> ui_state_getPreprocessorSteps()
        {
            return preprocessingQueue.stepsToStringList();
        }

        public List<String> ui_state_getDepthprocessorSteps()
        {
            return depthprocessingQueue.stepsToStringList();
        }

        public List<String> ui_state_getPostprocessorSteps()
        {
            return postprocessingQueue.stepsToStringList();
        }

        public DepthprocessingConfig ui_state_getDepthprocessingConfig()
        {
            return depthprocessingConfig;
        }

        public int ui_conf_addPreprocessingStep(ProcessingStep newStep)
        {
            preprocessingQueue.addStep(newStep);
            return 0;
        }

        public int ui_conf_clearPreprocessingSteps()
        {
            preprocessingQueue.clear();
            preprocessingQueue.addStep(new Preprocessing.Identity());
            return 0;
        }

        public int ui_conf_addDepthprocessingStep(ProcessingStep newStep)
        {
            depthprocessingQueue.addStep(newStep);
            return 0;
        }

        public int ui_conf_clearDepthprocessingSteps()
        {
            depthprocessingQueue.clear();
            return 0;
        }

        public int ui_conf_setDepthprocessingConfig(DepthprocessingConfig config)
        {
            depthprocessingConfig = config;
            return 0;
        }

        public void ui_run_preProcessingQueue(object o, DoWorkEventArgs args)
        {
            preprocessingQueue.Bw = o as BackgroundWorker;
            if(!bufferStates.rawDataReady || !bufferStates.rawReferenceReady)
            {
                throw new Exception("Buffer not available");
            }
            // Run the queue on the reference image
            if(preprocReference != null)
            {
                preprocReference.Dispose();
            }
            preprocReference = new Mat();
            preprocessingQueue.run(rawReference, ref preprocReference);
            bufferStates.preprocReferenceReady = true;

            // Run the queue on the data image
            if(preprocData != null)
            {
                preprocData.Dispose();
            }
            preprocData = new Mat();
            preprocessingQueue.run(rawData, ref preprocData);
            bufferStates.preprocDataReady = true;
        }

        public void ui_run_depthProcessingQueue(object o, DoWorkEventArgs args)
        {
            depthprocessingQueue.Bw = o as BackgroundWorker;
            if(!bufferStates.preprocDataReady || !bufferStates.preprocReferenceReady)
            {
                throw new Exception("Buffer not available");
            }
            if(rawDisparity != null)
            {
                rawDisparity.Dispose();
            }
            rawDisparity = new Mat();
            depthprocessingQueue.run(preprocData, preprocReference, ref rawDisparity);
            bufferStates.rawDisparityReady = true;
        }

        public void ui_run_postProcessingQueue(object o, DoWorkEventArgs args) 
        {
            postprocessingQueue.Bw = o as BackgroundWorker;
            if(!bufferStates.rawDisparityReady)
            {
                throw new Exception("Buffer not available");
            }
            if(visualDisparity != null)
            {
                visualDisparity.Dispose();
            }
            visualDisparity = new Mat();
            postprocessingQueue.run(rawDisparity, ref visualDisparity);
            bufferStates.visualDisparityReady = true;
        }

        public void ui_run_allQueues(object o, DoWorkEventArgs args) 
        {
            ui_run_preProcessingQueue(o, args);
            ui_run_depthProcessingQueue(o, args);
            ui_run_postProcessingQueue(o, args);
        }
        // UI interface functions end

    }
}
