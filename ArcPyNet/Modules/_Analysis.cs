using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Analysis
{
    internal _Analysis() { }
}

public static class _AnalysisExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.analysis.{method}", args);
    }

    public static Code ApportionPolygon(this _Analysis _, params object?[] args) => Run(args);
    public static Code Buffer(this _Analysis _, params object?[] args) => Run(args);
    public static Code Clip(this _Analysis _, params object?[] args) => Run(args);
    public static Code CountOverlappingFeatures(this _Analysis _, params object?[] args) => Run(args);
    public static Code CreateThiessenPolygons(this _Analysis _, params object?[] args) => Run(args);
    public static Code Enrich(this _Analysis _, params object?[] args) => Run(args);
    public static Code EnrichLayer(this _Analysis _, params object?[] args) => Run(args);
    public static Code Erase(this _Analysis _, params object?[] args) => Run(args);
    public static Code Frequency(this _Analysis _, params object?[] args) => Run(args);
    public static Code GenerateNearTable(this _Analysis _, params object?[] args) => Run(args);
    public static Code GenerateOriginDestinationLinks(this _Analysis _, params object?[] args) => Run(args);
    public static Code GeographicallyWeightedRegression(this _Analysis _, params object?[] args) => Run(args);
    public static Code GraphicBuffer(this _Analysis _, params object?[] args) => Run(args);
    public static Code Identity(this _Analysis _, params object?[] args) => Run(args);
    public static Code Intersect(this _Analysis _, params object?[] args) => Run(args);
    public static Code MultipleRingBuffer(this _Analysis _, params object?[] args) => Run(args);
    public static Code Near(this _Analysis _, params object?[] args) => Run(args);
    public static Code PairwiseBuffer(this _Analysis _, params object?[] args) => Run(args);
    public static Code PairwiseClip(this _Analysis _, params object?[] args) => Run(args);
    public static Code PairwiseDissolve(this _Analysis _, params object?[] args) => Run(args);
    public static Code PairwiseErase(this _Analysis _, params object?[] args) => Run(args);
    public static Code PairwiseIntegrate(this _Analysis _, params object?[] args) => Run(args);
    public static Code PairwiseIntersect(this _Analysis _, params object?[] args) => Run(args);
    public static Code PointDistance(this _Analysis _, params object?[] args) => Run(args);
    public static Code PolygonNeighbors(this _Analysis _, params object?[] args) => Run(args);
    public static Code RemoveOverlapMultiple(this _Analysis _, params object?[] args) => Run(args);
    public static Code Select(this _Analysis _, params object?[] args) => Run(args);
    public static Code SpatialJoin(this _Analysis _, params object?[] args) => Run(args);
    public static Code Split(this _Analysis _, params object?[] args) => Run(args);
    public static Code SplitByAttributes(this _Analysis _, params object?[] args) => Run(args);
    public static Code Statistics(this _Analysis _, params object?[] args) => Run(args);
    public static Code SummarizeNearby(this _Analysis _, params object?[] args) => Run(args);
    public static Code SummarizeWithin(this _Analysis _, params object?[] args) => Run(args);
    public static Code SymDiff(this _Analysis _, params object?[] args) => Run(args);
    public static Code TableSelect(this _Analysis _, params object?[] args) => Run(args);
    public static Code TabulateIntersection(this _Analysis _, params object?[] args) => Run(args);
    public static Code Union(this _Analysis _, params object?[] args) => Run(args);
    public static Code Update(this _Analysis _, params object?[] args) => Run(args);
}
