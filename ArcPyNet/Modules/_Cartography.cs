using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Cartography
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.cartography.{method}", args);
    }

    public Variable AggregatePoints(params object?[] args) => Run(args);
    public Variable AggregatePolygons(params object?[] args) => Run(args);
    public Variable AlignMarkerToStrokeOrFill(params object?[] args) => Run(args);
    public Variable AnnotateSelectedFeatures(params object?[] args) => Run(args);
    public Variable CalculateAdjacentFields(params object?[] args) => Run(args);
    public Variable CalculateCentralMeridianAndParallels(params object?[] args) => Run(args);
    public Variable CalculateGridConvergenceAngle(params object?[] args) => Run(args);
    public Variable CalculateLineCaps(params object?[] args) => Run(args);
    public Variable CalculatePolygonMainAngle(params object?[] args) => Run(args);
    public Variable CalculateUTMZone(params object?[] args) => Run(args);
    public Variable CollapseHydroPolygon(params object?[] args) => Run(args);
    public Variable CollapseRoadDetail(params object?[] args) => Run(args);
    public Variable ContourAnnotation(params object?[] args) => Run(args);
    public Variable ConvertLabelsToAnnotation(params object?[] args) => Run(args);
    public Variable ConvertLabelsToGraphics(params object?[] args) => Run(args);
    public Variable CreateCartographicPartitions(params object?[] args) => Run(args);
    public Variable CreateOverpass(params object?[] args) => Run(args);
    public Variable CreateUnderpass(params object?[] args) => Run(args);
    public Variable CulDeSacMasks(params object?[] args) => Run(args);
    public Variable DelineateBuiltUpAreas(params object?[] args) => Run(args);
    public Variable DetectGraphicConflict(params object?[] args) => Run(args);
    public Variable DisperseMarkers(params object?[] args) => Run(args);
    public Variable FeatureOutlineMasks(params object?[] args) => Run(args);
    public Variable GenerateHachuresForDefinedSlopes(params object?[] args) => Run(args);
    public Variable GridIndexFeatures(params object?[] args) => Run(args);
    public Variable IntersectingLayersMasks(params object?[] args) => Run(args);
    public Variable MapServerCacheTilingSchemeToPolygons(params object?[] args) => Run(args);
    public Variable MergeDividedRoads(params object?[] args) => Run(args);
    public Variable PropagateDisplacement(params object?[] args) => Run(args);
    public Variable ResolveBuildingConflicts(params object?[] args) => Run(args);
    public Variable ResolveRoadConflicts(params object?[] args) => Run(args);
    public Variable SetControlPointAtIntersect(params object?[] args) => Run(args);
    public Variable SetControlPointByAngle(params object?[] args) => Run(args);
    public Variable SimplifyBuilding(params object?[] args) => Run(args);
    public Variable SimplifyLine(params object?[] args) => Run(args);
    public Variable SimplifyPolygon(params object?[] args) => Run(args);
    public Variable SimplifySharedEdges(params object?[] args) => Run(args);
    public Variable SmoothLine(params object?[] args) => Run(args);
    public Variable SmoothPolygon(params object?[] args) => Run(args);
    public Variable SmoothSharedEdges(params object?[] args) => Run(args);
    public Variable StripMapIndexFeatures(params object?[] args) => Run(args);
    public Variable ThinRoadNetwork(params object?[] args) => Run(args);
    public Variable TiledLabelsToAnnotation(params object?[] args) => Run(args);
    public Variable UpdateAnnotationReferenceScale(params object?[] args) => Run(args);
}
