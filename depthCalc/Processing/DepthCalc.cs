﻿using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Processing
{
    class DepthCalc
    {
        // Read/write/visualise images
        private Util.ImageIO imageIO;
        private Visualiser visualiser;

        // Container for user defined parameters
        private Util.ParamContainer paramContainer;

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

        public enum SupportedBuffers
        {
            rawData,
            rawReference,
            preprocessedData,
            preprocessedReference,
            Disparity,
            visalisedDispartiy,
            postprocessedDisparity
        }

        private Util.BufferStates bufferStates;
        private Util.SourceFilePaths sourceFilePaths;

        // Constructor begin
        public DepthCalc()
        {
            imageIO = new Util.ImageIO();
            bufferStates = new Util.BufferStates();
            sourceFilePaths = new Util.SourceFilePaths();
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
                    scale = size.Width / rawData.Width;
                    break;
                case SupportedBuffers.rawReference:
                    if (!bufferStates.rawReferenceReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = rawReference.ToImage<Rgb, Byte>();
                    scale = size.Width / rawReference.Width;
                    break;
                case SupportedBuffers.preprocessedData:
                    if (!bufferStates.preprocDataReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = preprocData.ToImage<Rgb, Byte>();
                    scale = size.Width / preprocData.Width;
                    break;
                case SupportedBuffers.preprocessedReference:
                    if (!bufferStates.preprocReferenceReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = preprocReference.ToImage<Rgb, Byte>();
                    scale = size.Width / preprocReference.Width;
                    break;
                case SupportedBuffers.Disparity:
                    if (!bufferStates.rawDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = rawDisparity.ToImage<Rgb, Byte>();
                    scale = size.Width / rawDisparity.Width;
                    break;
                case SupportedBuffers.visalisedDispartiy:
                    if (!bufferStates.visualDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = visualDisparity.ToImage<Rgb, Byte>();
                    scale = size.Width / visualDisparity.Width;
                    break;
                case SupportedBuffers.postprocessedDisparity:
                    if (!bufferStates.postprocDisparityReady)
                    {
                        throw new Exception("Buffer not available");
                    }
                    renderedImage = postprocDisparity.ToImage<Rgb, Byte>();
                    scale = size.Width / postprocDisparity.Width;
                    break;
                default:
                    throw new Exception("Unsupported buffer type");
            }

            renderedImage.Resize(scale, Emgu.CV.CvEnum.Inter.Linear);

            return renderedImage.ToBitmap();
        }

        // UI interface functions end

    }
}