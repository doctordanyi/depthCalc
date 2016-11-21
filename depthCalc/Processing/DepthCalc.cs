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

namespace DepthCalc.Processing
{
    class DepthCalc
    {
        // Read/write/visualise images
        private ImageIO imageIO;
        private Visualiser visualiser;

        // Container for user defined parameters
        private ParamContainer paramContainer;

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

        // Constructor begin
        public DepthCalc()
        {
            imageIO = new ImageIO();
            bufferStates = new BufferStates();
            sourceFilePaths = new SourceFilePaths();

            // Initialize processing queues
            preprocessingQueue = new ProcessingQueue();
            preprocessingQueue.addStep(new Preprocessing.Identity());
            depthprocessingQueue = new ProcessingQueue();
            postprocessingQueue = new ProcessingQueue();
        }
        // Constructor end

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

        public System.Drawing.Bitmap ui_image_renderBuffer(System.Drawing.Size size, SupportedBuffers buffer)
        {
            Image<Rgb, Byte> renderedImage;
            double scale;
            switch (buffer)
            {
                case SupportedBuffers.rawData:
                    if (!bufferStates.rawDataReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = rawData.ToImage<Rgb, Byte>();
                    scale = (double)size.Width / rawData.Width;
                    break;
                case SupportedBuffers.rawReference:
                    if (!bufferStates.rawReferenceReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = rawReference.ToImage<Rgb, Byte>();
                    scale = (double)size.Width / rawReference.Width;
                    break;
                case SupportedBuffers.preprocessedData:
                    if (!bufferStates.preprocDataReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = preprocData.ToImage<Rgb, Byte>();
                    scale = (double)size.Width / preprocData.Width;
                    break;
                case SupportedBuffers.preprocessedReference:
                    if (!bufferStates.preprocReferenceReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = preprocReference.ToImage<Rgb, Byte>();
                    scale = (double)size.Width / preprocReference.Width;
                    break;
                case SupportedBuffers.Disparity:
                    if (!bufferStates.rawDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = rawDisparity.ToImage<Rgb, Byte>();
                    scale = (double)size.Width / rawDisparity.Width;
                    break;
                case SupportedBuffers.visalisedDispartiy:
                    if (!bufferStates.visualDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = visualDisparity.ToImage<Rgb, Byte>();
                    scale = (double)size.Width / visualDisparity.Width;
                    break;
                case SupportedBuffers.postprocessedDisparity:
                    if (!bufferStates.postprocDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = postprocDisparity.ToImage<Rgb, Byte>();
                    scale = (double)size.Width / postprocDisparity.Width;
                    break;
                default:
                    throw new Exception("Unsupported buffer type");
            }

            return renderedImage.Resize(scale, Inter.Linear).ToBitmap();
        }

        public BufferStates ui_state_getBufferStates()
        {
            return bufferStates;
        }

        public int ui_conf_setMatchMethod(TemplateMatchingType matchMethod)
        {
            return 0;
        }

        public void ui_run_preProcessingQueue(object o, DoWorkEventArgs args)
        {
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
        }

        public void ui_run_postProcessingQueue(object o, DoWorkEventArgs args) 
        {
        }

        public void ui_run_allQueues(object o, DoWorkEventArgs args) 
        {
        }
        // UI interface functions end

    }
}
