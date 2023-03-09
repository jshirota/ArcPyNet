using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Cartography
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.cartography.{method}", args);
    }

    public Code AggregatePoints(params object?[] args) => Run(args);
    public Code AggregatePolygons(params object?[] args) => Run(args);
    public Code AlignMarkerToStrokeOrFill(params object?[] args) => Run(args);
    public Code AnnotateSelectedFeatures(params object?[] args) => Run(args);
    public Code CalculateAdjacentFields(params object?[] args) => Run(args);
    public Code CalculateCentralMeridianAndParallels(params object?[] args) => Run(args);
    public Code CalculateGridConvergenceAngle(params object?[] args) => Run(args);
    public Code CalculateLineCaps(params object?[] args) => Run(args);
    public Code CalculatePolygonMainAngle(params object?[] args) => Run(args);
    public Code CalculateUTMZone(params object?[] args) => Run(args);
    public Code CollapseHydroPolygon(params object?[] args) => Run(args);
    public Code CollapseRoadDetail(params object?[] args) => Run(args);
    public Code ContourAnnotation(params object?[] args) => Run(args);
    public Code ConvertLabelsToAnnotation(params object?[] args) => Run(args);
    public Code ConvertLabelsToGraphics(params object?[] args) => Run(args);
    public Code CreateCartographicPartitions(params object?[] args) => Run(args);
    public Code CreateOverpass(params object?[] args) => Run(args);
    public Code CreateUnderpass(params object?[] args) => Run(args);
    public Code CulDeSacMasks(params object?[] args) => Run(args);
    public Code DelineateBuiltUpAreas(params object?[] args) => Run(args);
    public Code DetectGraphicConflict(params object?[] args) => Run(args);
    public Code DisperseMarkers(params object?[] args) => Run(args);
    public Code FeatureOutlineMasks(params object?[] args) => Run(args);
    public Code GenerateHachuresForDefinedSlopes(params object?[] args) => Run(args);
    public Code GridIndexFeatures(params object?[] args) => Run(args);
    public Code IntersectingLayersMasks(params object?[] args) => Run(args);
    public Code MapServerCacheTilingSchemeToPolygons(params object?[] args) => Run(args);
    public Code MergeDividedRoads(params object?[] args) => Run(args);
    public Code PropagateDisplacement(params object?[] args) => Run(args);
    public Code ResolveBuildingConflicts(params object?[] args) => Run(args);
    public Code ResolveRoadConflicts(params object?[] args) => Run(args);
    public Code SetControlPointAtIntersect(params object?[] args) => Run(args);
    public Code SetControlPointByAngle(params object?[] args) => Run(args);
    public Code SimplifyBuilding(params object?[] args) => Run(args);
    public Code SimplifyLine(params object?[] args) => Run(args);
    public Code SimplifyPolygon(params object?[] args) => Run(args);
    public Code SimplifySharedEdges(params object?[] args) => Run(args);
    public Code SmoothLine(params object?[] args) => Run(args);
    public Code SmoothPolygon(params object?[] args) => Run(args);
    public Code SmoothSharedEdges(params object?[] args) => Run(args);
    public Code StripMapIndexFeatures(params object?[] args) => Run(args);
    public Code ThinRoadNetwork(params object?[] args) => Run(args);
    public Code TiledLabelsToAnnotation(params object?[] args) => Run(args);
    public Code UpdateAnnotationReferenceScale(params object?[] args) => Run(args);
}
