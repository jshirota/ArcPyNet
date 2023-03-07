using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class Intelligence
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.intelligence.{method}", args);
    }

    public Variable BatchImportData(params object?[] args) => Run(args);
    public Variable ClassifyMovementEvents(params object?[] args) => Run(args);
    public Variable CompareAreas(params object?[] args) => Run(args);
    public Variable CreateLocationFileFromTextFile(params object?[] args) => Run(args);
    public Variable DOFToObstacleFeatures(params object?[] args) => Run(args);
    public Variable DropZones(params object?[] args) => Run(args);
    public Variable FindCotravelers(params object?[] args) => Run(args);
    public Variable FindFrequentedLocations(params object?[] args) => Run(args);
    public Variable FindMeetingLocations(params object?[] args) => Run(args);
    public Variable FindOverlaps(params object?[] args) => Run(args);
    public Variable GenerateBlindSpotAreas(params object?[] args) => Run(args);
    public Variable GenerateCoverageAreas(params object?[] args) => Run(args);
    public Variable GenerateHLZSuitability(params object?[] args) => Run(args);
    public Variable GenerateObstacleFeatures(params object?[] args) => Run(args);
    public Variable LeastCostPath(params object?[] args) => Run(args);
    public Variable PointsToTrackSegments(params object?[] args) => Run(args);
    public Variable SelectMovementTracks(params object?[] args) => Run(args);
}
