using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class RasterAnalysis
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.ra.{method}", args);
    }

    public Variable CalculateDensity(params object?[] args) => Run(args);
    public Variable CalculateDistance(params object?[] args) => Run(args);
    public Variable CalculateTravelCost(params object?[] args) => Run(args);
    public Variable ClassifyObjectsUsingDeepLearning(params object?[] args) => Run(args);
    public Variable ClassifyPixelsUsingDeepLearning(params object?[] args) => Run(args);
    public Variable ConvertFeatureToRaster(params object?[] args) => Run(args);
    public Variable ConvertRasterToFeature(params object?[] args) => Run(args);
    public Variable CostPathAsPolyline(params object?[] args) => Run(args);
    public Variable CreateViewshed(params object?[] args) => Run(args);
    public Variable DetectObjectsUsingDeepLearning(params object?[] args) => Run(args);
    public Variable DetermineOptimumTravelCostNetwork(params object?[] args) => Run(args);
    public Variable DetermineTravelCostPathAsPolyline(params object?[] args) => Run(args);
    public Variable DetermineTravelCostPathsToDestinations(params object?[] args) => Run(args);
    public Variable DistanceAccumulation(params object?[] args) => Run(args);
    public Variable DistanceAllocation(params object?[] args) => Run(args);
    public Variable Fill(params object?[] args) => Run(args);
    public Variable FlowAccumulation(params object?[] args) => Run(args);
    public Variable FlowDirection(params object?[] args) => Run(args);
    public Variable FlowDistance(params object?[] args) => Run(args);
    public Variable InterpolatePoints(params object?[] args) => Run(args);
    public Variable Nibble(params object?[] args) => Run(args);
    public Variable OptimalPathAsLine(params object?[] args) => Run(args);
    public Variable OptimalPathAsRaster(params object?[] args) => Run(args);
    public Variable OptimalRegionConnections(params object?[] args) => Run(args);
    public Variable StreamLink(params object?[] args) => Run(args);
    public Variable SummarizeRasterWithin(params object?[] args) => Run(args);
    public Variable SurfaceParameters(params object?[] args) => Run(args);
    public Variable Watershed(params object?[] args) => Run(args);
    public Variable ZonalStatisticsAsTable(params object?[] args) => Run(args);
}
