using System.Runtime.CompilerServices;

namespace ArcPyNet;

public static class Analysis
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Run($"arcpy.analysis.{method}", args);
    }

    public static Variable ApportionPolygon(params object?[] args) => Run(args);
    public static Variable Buffer(params object?[] args) => Run(args);
    public static Variable Clip(params object?[] args) => Run(args);
    public static Variable CountOverlappingFeatures(params object?[] args) => Run(args);
    public static Variable CreateThiessenPolygons(params object?[] args) => Run(args);
    public static Variable Enrich(params object?[] args) => Run(args);
    public static Variable EnrichLayer(params object?[] args) => Run(args);
    public static Variable Erase(params object?[] args) => Run(args);
    public static Variable Frequency(params object?[] args) => Run(args);
    public static Variable GenerateNearTable(params object?[] args) => Run(args);
    public static Variable GenerateOriginDestinationLinks(params object?[] args) => Run(args);
    public static Variable GeographicallyWeightedRegression(params object?[] args) => Run(args);
    public static Variable GraphicBuffer(params object?[] args) => Run(args);
    public static Variable Identity(params object?[] args) => Run(args);
    public static Variable Intersect(params object?[] args) => Run(args);
    public static Variable MultipleRingBuffer(params object?[] args) => Run(args);
    public static Variable Near(params object?[] args) => Run(args);
    public static Variable PairwiseBuffer(params object?[] args) => Run(args);
    public static Variable PairwiseClip(params object?[] args) => Run(args);
    public static Variable PairwiseDissolve(params object?[] args) => Run(args);
    public static Variable PairwiseErase(params object?[] args) => Run(args);
    public static Variable PairwiseIntegrate(params object?[] args) => Run(args);
    public static Variable PairwiseIntersect(params object?[] args) => Run(args);
    public static Variable PointDistance(params object?[] args) => Run(args);
    public static Variable PolygonNeighbors(params object?[] args) => Run(args);
    public static Variable RemoveOverlapMultiple(params object?[] args) => Run(args);
    public static Variable Select(params object?[] args) => Run(args);
    public static Variable SpatialJoin(params object?[] args) => Run(args);
    public static Variable Split(params object?[] args) => Run(args);
    public static Variable SplitByAttributes(params object?[] args) => Run(args);
    public static Variable Statistics(params object?[] args) => Run(args);
    public static Variable SummarizeNearby(params object?[] args) => Run(args);
    public static Variable SummarizeWithin(params object?[] args) => Run(args);
    public static Variable SymDiff(params object?[] args) => Run(args);
    public static Variable TableSelect(params object?[] args) => Run(args);
    public static Variable TabulateIntersection(params object?[] args) => Run(args);
    public static Variable Union(params object?[] args) => Run(args);
    public static Variable Update(params object?[] args) => Run(args);
}
