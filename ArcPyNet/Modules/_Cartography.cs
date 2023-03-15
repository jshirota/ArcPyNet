using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Cartography
{
    internal _Cartography() { }
}

public static class _CartographyExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.cartography.{method}", args);
    }

    public static Code AggregatePoints(this _Cartography _, params object?[] args) => Run(args);
    public static Code AggregatePolygons(this _Cartography _, params object?[] args) => Run(args);
    public static Code AlignMarkerToStrokeOrFill(this _Cartography _, params object?[] args) => Run(args);
    public static Code AnnotateSelectedFeatures(this _Cartography _, params object?[] args) => Run(args);
    public static Code CalculateAdjacentFields(this _Cartography _, params object?[] args) => Run(args);
    public static Code CalculateCentralMeridianAndParallels(this _Cartography _, params object?[] args) => Run(args);
    public static Code CalculateGridConvergenceAngle(this _Cartography _, params object?[] args) => Run(args);
    public static Code CalculateLineCaps(this _Cartography _, params object?[] args) => Run(args);
    public static Code CalculatePolygonMainAngle(this _Cartography _, params object?[] args) => Run(args);
    public static Code CalculateUTMZone(this _Cartography _, params object?[] args) => Run(args);
    public static Code CollapseHydroPolygon(this _Cartography _, params object?[] args) => Run(args);
    public static Code CollapseRoadDetail(this _Cartography _, params object?[] args) => Run(args);
    public static Code ContourAnnotation(this _Cartography _, params object?[] args) => Run(args);
    public static Code ConvertLabelsToAnnotation(this _Cartography _, params object?[] args) => Run(args);
    public static Code ConvertLabelsToGraphics(this _Cartography _, params object?[] args) => Run(args);
    public static Code CreateCartographicPartitions(this _Cartography _, params object?[] args) => Run(args);
    public static Code CreateOverpass(this _Cartography _, params object?[] args) => Run(args);
    public static Code CreateUnderpass(this _Cartography _, params object?[] args) => Run(args);
    public static Code CulDeSacMasks(this _Cartography _, params object?[] args) => Run(args);
    public static Code DelineateBuiltUpAreas(this _Cartography _, params object?[] args) => Run(args);
    public static Code DetectGraphicConflict(this _Cartography _, params object?[] args) => Run(args);
    public static Code DisperseMarkers(this _Cartography _, params object?[] args) => Run(args);
    public static Code FeatureOutlineMasks(this _Cartography _, params object?[] args) => Run(args);
    public static Code GenerateHachuresForDefinedSlopes(this _Cartography _, params object?[] args) => Run(args);
    public static Code GridIndexFeatures(this _Cartography _, params object?[] args) => Run(args);
    public static Code IntersectingLayersMasks(this _Cartography _, params object?[] args) => Run(args);
    public static Code MapServerCacheTilingSchemeToPolygons(this _Cartography _, params object?[] args) => Run(args);
    public static Code MergeDividedRoads(this _Cartography _, params object?[] args) => Run(args);
    public static Code PropagateDisplacement(this _Cartography _, params object?[] args) => Run(args);
    public static Code ResolveBuildingConflicts(this _Cartography _, params object?[] args) => Run(args);
    public static Code ResolveRoadConflicts(this _Cartography _, params object?[] args) => Run(args);
    public static Code SetControlPointAtIntersect(this _Cartography _, params object?[] args) => Run(args);
    public static Code SetControlPointByAngle(this _Cartography _, params object?[] args) => Run(args);
    public static Code SimplifyBuilding(this _Cartography _, params object?[] args) => Run(args);
    public static Code SimplifyLine(this _Cartography _, params object?[] args) => Run(args);
    public static Code SimplifyPolygon(this _Cartography _, params object?[] args) => Run(args);
    public static Code SimplifySharedEdges(this _Cartography _, params object?[] args) => Run(args);
    public static Code SmoothLine(this _Cartography _, params object?[] args) => Run(args);
    public static Code SmoothPolygon(this _Cartography _, params object?[] args) => Run(args);
    public static Code SmoothSharedEdges(this _Cartography _, params object?[] args) => Run(args);
    public static Code StripMapIndexFeatures(this _Cartography _, params object?[] args) => Run(args);
    public static Code ThinRoadNetwork(this _Cartography _, params object?[] args) => Run(args);
    public static Code TiledLabelsToAnnotation(this _Cartography _, params object?[] args) => Run(args);
    public static Code UpdateAnnotationReferenceScale(this _Cartography _, params object?[] args) => Run(args);
}
