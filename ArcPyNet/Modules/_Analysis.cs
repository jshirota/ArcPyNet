using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Analysis
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.analysis.{method}", args);
    }

    public Variable ApportionPolygon(params object?[] args) => Run(args);
    public Variable Buffer(params object?[] args) => Run(args);
    public Variable Clip(params object?[] args) => Run(args);
    public Variable CountOverlappingFeatures(params object?[] args) => Run(args);
    public Variable CreateThiessenPolygons(params object?[] args) => Run(args);
    public Variable Enrich(params object?[] args) => Run(args);
    public Variable EnrichLayer(params object?[] args) => Run(args);
    public Variable Erase(params object?[] args) => Run(args);
    public Variable Frequency(params object?[] args) => Run(args);
    public Variable GenerateNearTable(params object?[] args) => Run(args);
    public Variable GenerateOriginDestinationLinks(params object?[] args) => Run(args);
    public Variable GeographicallyWeightedRegression(params object?[] args) => Run(args);
    public Variable GraphicBuffer(params object?[] args) => Run(args);
    public Variable Identity(params object?[] args) => Run(args);
    public Variable Intersect(params object?[] args) => Run(args);
    public Variable MultipleRingBuffer(params object?[] args) => Run(args);
    public Variable Near(params object?[] args) => Run(args);
    public Variable PairwiseBuffer(params object?[] args) => Run(args);
    public Variable PairwiseClip(params object?[] args) => Run(args);
    public Variable PairwiseDissolve(params object?[] args) => Run(args);
    public Variable PairwiseErase(params object?[] args) => Run(args);
    public Variable PairwiseIntegrate(params object?[] args) => Run(args);
    public Variable PairwiseIntersect(params object?[] args) => Run(args);
    public Variable PointDistance(params object?[] args) => Run(args);
    public Variable PolygonNeighbors(params object?[] args) => Run(args);
    public Variable RemoveOverlapMultiple(params object?[] args) => Run(args);
    public Variable Select(params object?[] args) => Run(args);
    public Variable SpatialJoin(params object?[] args) => Run(args);
    public Variable Split(params object?[] args) => Run(args);
    public Variable SplitByAttributes(params object?[] args) => Run(args);
    public Variable Statistics(params object?[] args) => Run(args);
    public Variable SummarizeNearby(params object?[] args) => Run(args);
    public Variable SummarizeWithin(params object?[] args) => Run(args);
    public Variable SymDiff(params object?[] args) => Run(args);
    public Variable TableSelect(params object?[] args) => Run(args);
    public Variable TabulateIntersection(params object?[] args) => Run(args);
    public Variable Union(params object?[] args) => Run(args);
    public Variable Update(params object?[] args) => Run(args);
}
