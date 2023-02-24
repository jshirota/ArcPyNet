using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class SpatialStatistics
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.stats.{method}", args);
    }

    public Variable AverageNearestNeighbor(params object?[] args) => Run(args);
    public Variable BuildBalancedZones(params object?[] args) => Run(args);
    public Variable CalculateAreas(params object?[] args) => Run(args);
    public Variable CalculateDistanceBand(params object?[] args) => Run(args);
    public Variable CentralFeature(params object?[] args) => Run(args);
    public Variable ClustersOutliers(params object?[] args) => Run(args);
    public Variable CollectEvents(params object?[] args) => Run(args);
    public Variable ColocationAnalysis(params object?[] args) => Run(args);
    public Variable ConvertSpatialWeightsMatrixtoTable(params object?[] args) => Run(args);
    public Variable DensityBasedClustering(params object?[] args) => Run(args);
    public Variable DimensionReduction(params object?[] args) => Run(args);
    public Variable DirectionalDistribution(params object?[] args) => Run(args);
    public Variable DirectionalMean(params object?[] args) => Run(args);
    public Variable ExploratoryRegression(params object?[] args) => Run(args);
    public Variable ExportXYv(params object?[] args) => Run(args);
    public Variable Forest(params object?[] args) => Run(args);
    public Variable GWR(params object?[] args) => Run(args);
    public Variable GeneralizedLinearRegression(params object?[] args) => Run(args);
    public Variable GenerateNetworkSWM(params object?[] args) => Run(args);
    public Variable GenerateNetworkSpatialWeights(params object?[] args) => Run(args);
    public Variable GenerateSpatialWeightsMatrix(params object?[] args) => Run(args);
    public Variable GeographicallyWeightedRegression(params object?[] args) => Run(args);
    public Variable GroupingAnalysis(params object?[] args) => Run(args);
    public Variable HighLowClustering(params object?[] args) => Run(args);
    public Variable HotSpots(params object?[] args) => Run(args);
    public Variable IncrementalSpatialAutocorrelation(params object?[] args) => Run(args);
    public Variable LocalBivariateRelationships(params object?[] args) => Run(args);
    public Variable MGWR(params object?[] args) => Run(args);
    public Variable MeanCenter(params object?[] args) => Run(args);
    public Variable MedianCenter(params object?[] args) => Run(args);
    public Variable MultiDistanceSpatialClustering(params object?[] args) => Run(args);
    public Variable MultivariateClustering(params object?[] args) => Run(args);
    public Variable NeighborhoodSummaryStatistics(params object?[] args) => Run(args);
    public Variable OptimizedHotSpotAnalysis(params object?[] args) => Run(args);
    public Variable OptimizedOutlierAnalysis(params object?[] args) => Run(args);
    public Variable OrdinaryLeastSquares(params object?[] args) => Run(args);
    public Variable PresenceOnlyPrediction(params object?[] args) => Run(args);
    public Variable SimilaritySearch(params object?[] args) => Run(args);
    public Variable SpatialAssociationBetweenZones(params object?[] args) => Run(args);
    public Variable SpatialAutocorrelation(params object?[] args) => Run(args);
    public Variable SpatialOutlierDetection(params object?[] args) => Run(args);
    public Variable SpatiallyConstrainedMultivariateClustering(params object?[] args) => Run(args);
    public Variable StandardDistance(params object?[] args) => Run(args);
    public Variable TimeSeriesSmoothing(params object?[] args) => Run(args);
}
