using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _RasterAnalysis
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.ra.{method}", args);
    }

    internal _RasterAnalysis() { }

    public Code CalculateDensity(params object?[] args) => Run(args);
    public Code CalculateDistance(params object?[] args) => Run(args);
    public Code CalculateTravelCost(params object?[] args) => Run(args);
    public Code ClassifyObjectsUsingDeepLearning(params object?[] args) => Run(args);
    public Code ClassifyPixelsUsingDeepLearning(params object?[] args) => Run(args);
    public Code ConvertFeatureToRaster(params object?[] args) => Run(args);
    public Code ConvertRasterToFeature(params object?[] args) => Run(args);
    public Code CostPathAsPolyline(params object?[] args) => Run(args);
    public Code CreateViewshed(params object?[] args) => Run(args);
    public Code DetectObjectsUsingDeepLearning(params object?[] args) => Run(args);
    public Code DetermineOptimumTravelCostNetwork(params object?[] args) => Run(args);
    public Code DetermineTravelCostPathAsPolyline(params object?[] args) => Run(args);
    public Code DetermineTravelCostPathsToDestinations(params object?[] args) => Run(args);
    public Code DistanceAccumulation(params object?[] args) => Run(args);
    public Code DistanceAllocation(params object?[] args) => Run(args);
    public Code Fill(params object?[] args) => Run(args);
    public Code FlowAccumulation(params object?[] args) => Run(args);
    public Code FlowDirection(params object?[] args) => Run(args);
    public Code FlowDistance(params object?[] args) => Run(args);
    public Code InterpolatePoints(params object?[] args) => Run(args);
    public Code Nibble(params object?[] args) => Run(args);
    public Code OptimalPathAsLine(params object?[] args) => Run(args);
    public Code OptimalPathAsRaster(params object?[] args) => Run(args);
    public Code OptimalRegionConnections(params object?[] args) => Run(args);
    public Code StreamLink(params object?[] args) => Run(args);
    public Code SummarizeRasterWithin(params object?[] args) => Run(args);
    public Code SurfaceParameters(params object?[] args) => Run(args);
    public Code Watershed(params object?[] args) => Run(args);
    public Code ZonalStatisticsAsTable(params object?[] args) => Run(args);
}
