using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _RasterAnalysis
{
    internal _RasterAnalysis() { }
}

public static class _RasterAnalysisExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.ra.{method}", args);
    }

    public static Code CalculateDensity(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code CalculateDistance(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code CalculateTravelCost(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code ClassifyObjectsUsingDeepLearning(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code ClassifyPixelsUsingDeepLearning(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code ConvertFeatureToRaster(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code ConvertRasterToFeature(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code CostPathAsPolyline(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code CreateViewshed(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code DetectObjectsUsingDeepLearning(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code DetermineOptimumTravelCostNetwork(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code DetermineTravelCostPathAsPolyline(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code DetermineTravelCostPathsToDestinations(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code DistanceAccumulation(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code DistanceAllocation(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code Fill(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code FlowAccumulation(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code FlowDirection(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code FlowDistance(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code InterpolatePoints(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code Nibble(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code OptimalPathAsLine(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code OptimalPathAsRaster(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code OptimalRegionConnections(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code StreamLink(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code SummarizeRasterWithin(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code SurfaceParameters(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code Watershed(this _RasterAnalysis _, params object?[] args) => Run(args);
    public static Code ZonalStatisticsAsTable(this _RasterAnalysis _, params object?[] args) => Run(args);
}
