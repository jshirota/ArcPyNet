using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _SpatialStatistics
{
    internal _SpatialStatistics() { }
}

public static class _SpatialStatisticsExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.stats.{method}", args);
    }

    public static Code AverageNearestNeighbor(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code BuildBalancedZones(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code CalculateAreas(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code CalculateDistanceBand(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code CentralFeature(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code ClustersOutliers(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code CollectEvents(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code ColocationAnalysis(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code ConvertSpatialWeightsMatrixtoTable(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code DensityBasedClustering(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code DimensionReduction(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code DirectionalDistribution(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code DirectionalMean(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code ExploratoryRegression(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code ExportXYv(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code Forest(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code GWR(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code GeneralizedLinearRegression(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code GenerateNetworkSWM(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code GenerateNetworkSpatialWeights(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code GenerateSpatialWeightsMatrix(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code GeographicallyWeightedRegression(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code GroupingAnalysis(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code HighLowClustering(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code HotSpots(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code IncrementalSpatialAutocorrelation(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code LocalBivariateRelationships(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code MGWR(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code MeanCenter(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code MedianCenter(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code MultiDistanceSpatialClustering(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code MultivariateClustering(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code NeighborhoodSummaryStatistics(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code OptimizedHotSpotAnalysis(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code OptimizedOutlierAnalysis(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code OrdinaryLeastSquares(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code PresenceOnlyPrediction(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code SimilaritySearch(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code SpatialAssociationBetweenZones(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code SpatialAutocorrelation(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code SpatialOutlierDetection(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code SpatiallyConstrainedMultivariateClustering(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code StandardDistance(this _SpatialStatistics _, params object?[] args) => Run(args);
    public static Code TimeSeriesSmoothing(this _SpatialStatistics _, params object?[] args) => Run(args);
}
