using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _SpatialStatistics
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.stats.{method}", args);
    }

    internal _SpatialStatistics() { }

    public Code AverageNearestNeighbor(params object?[] args) => Run(args);
    public Code BuildBalancedZones(params object?[] args) => Run(args);
    public Code CalculateAreas(params object?[] args) => Run(args);
    public Code CalculateDistanceBand(params object?[] args) => Run(args);
    public Code CentralFeature(params object?[] args) => Run(args);
    public Code ClustersOutliers(params object?[] args) => Run(args);
    public Code CollectEvents(params object?[] args) => Run(args);
    public Code ColocationAnalysis(params object?[] args) => Run(args);
    public Code ConvertSpatialWeightsMatrixtoTable(params object?[] args) => Run(args);
    public Code DensityBasedClustering(params object?[] args) => Run(args);
    public Code DimensionReduction(params object?[] args) => Run(args);
    public Code DirectionalDistribution(params object?[] args) => Run(args);
    public Code DirectionalMean(params object?[] args) => Run(args);
    public Code ExploratoryRegression(params object?[] args) => Run(args);
    public Code ExportXYv(params object?[] args) => Run(args);
    public Code Forest(params object?[] args) => Run(args);
    public Code GWR(params object?[] args) => Run(args);
    public Code GeneralizedLinearRegression(params object?[] args) => Run(args);
    public Code GenerateNetworkSWM(params object?[] args) => Run(args);
    public Code GenerateNetworkSpatialWeights(params object?[] args) => Run(args);
    public Code GenerateSpatialWeightsMatrix(params object?[] args) => Run(args);
    public Code GeographicallyWeightedRegression(params object?[] args) => Run(args);
    public Code GroupingAnalysis(params object?[] args) => Run(args);
    public Code HighLowClustering(params object?[] args) => Run(args);
    public Code HotSpots(params object?[] args) => Run(args);
    public Code IncrementalSpatialAutocorrelation(params object?[] args) => Run(args);
    public Code LocalBivariateRelationships(params object?[] args) => Run(args);
    public Code MGWR(params object?[] args) => Run(args);
    public Code MeanCenter(params object?[] args) => Run(args);
    public Code MedianCenter(params object?[] args) => Run(args);
    public Code MultiDistanceSpatialClustering(params object?[] args) => Run(args);
    public Code MultivariateClustering(params object?[] args) => Run(args);
    public Code NeighborhoodSummaryStatistics(params object?[] args) => Run(args);
    public Code OptimizedHotSpotAnalysis(params object?[] args) => Run(args);
    public Code OptimizedOutlierAnalysis(params object?[] args) => Run(args);
    public Code OrdinaryLeastSquares(params object?[] args) => Run(args);
    public Code PresenceOnlyPrediction(params object?[] args) => Run(args);
    public Code SimilaritySearch(params object?[] args) => Run(args);
    public Code SpatialAssociationBetweenZones(params object?[] args) => Run(args);
    public Code SpatialAutocorrelation(params object?[] args) => Run(args);
    public Code SpatialOutlierDetection(params object?[] args) => Run(args);
    public Code SpatiallyConstrainedMultivariateClustering(params object?[] args) => Run(args);
    public Code StandardDistance(params object?[] args) => Run(args);
    public Code TimeSeriesSmoothing(params object?[] args) => Run(args);
}
