using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Intelligence
{
    internal _Intelligence() { }
}

public static class _IntelligenceExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.intelligence.{method}", args);
    }

    public static Code BatchImportData(this _Intelligence _, params object?[] args) => Run(args);
    public static Code ClassifyMovementEvents(this _Intelligence _, params object?[] args) => Run(args);
    public static Code CompareAreas(this _Intelligence _, params object?[] args) => Run(args);
    public static Code CreateLocationFileFromTextFile(this _Intelligence _, params object?[] args) => Run(args);
    public static Code DOFToObstacleFeatures(this _Intelligence _, params object?[] args) => Run(args);
    public static Code DropZones(this _Intelligence _, params object?[] args) => Run(args);
    public static Code FindCotravelers(this _Intelligence _, params object?[] args) => Run(args);
    public static Code FindFrequentedLocations(this _Intelligence _, params object?[] args) => Run(args);
    public static Code FindMeetingLocations(this _Intelligence _, params object?[] args) => Run(args);
    public static Code FindOverlaps(this _Intelligence _, params object?[] args) => Run(args);
    public static Code GenerateBlindSpotAreas(this _Intelligence _, params object?[] args) => Run(args);
    public static Code GenerateCoverageAreas(this _Intelligence _, params object?[] args) => Run(args);
    public static Code GenerateHLZSuitability(this _Intelligence _, params object?[] args) => Run(args);
    public static Code GenerateObstacleFeatures(this _Intelligence _, params object?[] args) => Run(args);
    public static Code LeastCostPath(this _Intelligence _, params object?[] args) => Run(args);
    public static Code PointsToTrackSegments(this _Intelligence _, params object?[] args) => Run(args);
    public static Code SelectMovementTracks(this _Intelligence _, params object?[] args) => Run(args);
}
