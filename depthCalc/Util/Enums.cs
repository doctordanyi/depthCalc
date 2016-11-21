namespace DepthCalc.Util
{
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

    public enum SupportedSteps
    {
        Identity,
        Scale,
        GaussianBlur,
        DifferenceOfGaussians,
        Normalize
    }
}
