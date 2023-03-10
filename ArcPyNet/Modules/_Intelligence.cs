using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Intelligence
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.intelligence.{method}", args);
    }

    internal _Intelligence() { }

    public Code BatchImportData(params object?[] args) => Run(args);
    public Code ClassifyMovementEvents(params object?[] args) => Run(args);
    public Code CompareAreas(params object?[] args) => Run(args);
    public Code CreateLocationFileFromTextFile(params object?[] args) => Run(args);
    public Code DOFToObstacleFeatures(params object?[] args) => Run(args);
    public Code DropZones(params object?[] args) => Run(args);
    public Code FindCotravelers(params object?[] args) => Run(args);
    public Code FindFrequentedLocations(params object?[] args) => Run(args);
    public Code FindMeetingLocations(params object?[] args) => Run(args);
    public Code FindOverlaps(params object?[] args) => Run(args);
    public Code GenerateBlindSpotAreas(params object?[] args) => Run(args);
    public Code GenerateCoverageAreas(params object?[] args) => Run(args);
    public Code GenerateHLZSuitability(params object?[] args) => Run(args);
    public Code GenerateObstacleFeatures(params object?[] args) => Run(args);
    public Code LeastCostPath(params object?[] args) => Run(args);
    public Code PointsToTrackSegments(params object?[] args) => Run(args);
    public Code SelectMovementTracks(params object?[] args) => Run(args);
}
