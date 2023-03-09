using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Analysis
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.analysis.{method}", args);
    }

    public Code ApportionPolygon(params object?[] args) => Run(args);
    public Code Buffer(params object?[] args) => Run(args);
    public Code Clip(params object?[] args) => Run(args);
    public Code CountOverlappingFeatures(params object?[] args) => Run(args);
    public Code CreateThiessenPolygons(params object?[] args) => Run(args);
    public Code Enrich(params object?[] args) => Run(args);
    public Code EnrichLayer(params object?[] args) => Run(args);
    public Code Erase(params object?[] args) => Run(args);
    public Code Frequency(params object?[] args) => Run(args);
    public Code GenerateNearTable(params object?[] args) => Run(args);
    public Code GenerateOriginDestinationLinks(params object?[] args) => Run(args);
    public Code GeographicallyWeightedRegression(params object?[] args) => Run(args);
    public Code GraphicBuffer(params object?[] args) => Run(args);
    public Code Identity(params object?[] args) => Run(args);
    public Code Intersect(params object?[] args) => Run(args);
    public Code MultipleRingBuffer(params object?[] args) => Run(args);
    public Code Near(params object?[] args) => Run(args);
    public Code PairwiseBuffer(params object?[] args) => Run(args);
    public Code PairwiseClip(params object?[] args) => Run(args);
    public Code PairwiseDissolve(params object?[] args) => Run(args);
    public Code PairwiseErase(params object?[] args) => Run(args);
    public Code PairwiseIntegrate(params object?[] args) => Run(args);
    public Code PairwiseIntersect(params object?[] args) => Run(args);
    public Code PointDistance(params object?[] args) => Run(args);
    public Code PolygonNeighbors(params object?[] args) => Run(args);
    public Code RemoveOverlapMultiple(params object?[] args) => Run(args);
    public Code Select(params object?[] args) => Run(args);
    public Code SpatialJoin(params object?[] args) => Run(args);
    public Code Split(params object?[] args) => Run(args);
    public Code SplitByAttributes(params object?[] args) => Run(args);
    public Code Statistics(params object?[] args) => Run(args);
    public Code SummarizeNearby(params object?[] args) => Run(args);
    public Code SummarizeWithin(params object?[] args) => Run(args);
    public Code SymDiff(params object?[] args) => Run(args);
    public Code TableSelect(params object?[] args) => Run(args);
    public Code TabulateIntersection(params object?[] args) => Run(args);
    public Code Union(params object?[] args) => Run(args);
    public Code Update(params object?[] args) => Run(args);
}
