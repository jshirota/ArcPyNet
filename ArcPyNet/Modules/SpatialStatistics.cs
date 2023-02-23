using System.Runtime.CompilerServices;

namespace ArcPyNet;

public static class SpatialStatistics
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        var temp = ArcPy.GetTempName();

        ArcPy.Run($"""
            {temp} = arcpy.stats.{method}({ArcPy.Format(args)})
            """);

        return temp;
    }

    public static Variable AverageNearestNeighbor(params object?[] args) => Run(args);
    public static Variable BuildBalancedZones(params object?[] args) => Run(args);
    public static Variable CalculateAreas(params object?[] args) => Run(args);
    public static Variable CalculateDistanceBand(params object?[] args) => Run(args);
    public static Variable CentralFeature(params object?[] args) => Run(args);
    public static Variable ClustersOutliers(params object?[] args) => Run(args);
    public static Variable CollectEvents(params object?[] args) => Run(args);
    public static Variable ColocationAnalysis(params object?[] args) => Run(args);
    public static Variable ConvertSpatialWeightsMatrixtoTable(params object?[] args) => Run(args);
    public static Variable DensityBasedClustering(params object?[] args) => Run(args);
    public static Variable DimensionReduction(params object?[] args) => Run(args);
    public static Variable DirectionalDistribution(params object?[] args) => Run(args);
    public static Variable DirectionalMean(params object?[] args) => Run(args);
    public static Variable ExploratoryRegression(params object?[] args) => Run(args);
    public static Variable ExportXYv(params object?[] args) => Run(args);
    public static Variable Forest(params object?[] args) => Run(args);
    public static Variable GWR(params object?[] args) => Run(args);
    public static Variable GeneralizedLinearRegression(params object?[] args) => Run(args);
    public static Variable GenerateNetworkSWM(params object?[] args) => Run(args);
    public static Variable GenerateNetworkSpatialWeights(params object?[] args) => Run(args);
    public static Variable GenerateSpatialWeightsMatrix(params object?[] args) => Run(args);
    public static Variable GeographicallyWeightedRegression(params object?[] args) => Run(args);
    public static Variable GroupingAnalysis(params object?[] args) => Run(args);
    public static Variable HighLowClustering(params object?[] args) => Run(args);
    public static Variable HotSpots(params object?[] args) => Run(args);
    public static Variable IncrementalSpatialAutocorrelation(params object?[] args) => Run(args);
    public static Variable LocalBivariateRelationships(params object?[] args) => Run(args);
    public static Variable MGWR(params object?[] args) => Run(args);
    public static Variable MeanCenter(params object?[] args) => Run(args);
    public static Variable MedianCenter(params object?[] args) => Run(args);
    public static Variable MultiDistanceSpatialClustering(params object?[] args) => Run(args);
    public static Variable MultivariateClustering(params object?[] args) => Run(args);
    public static Variable NeighborhoodSummaryStatistics(params object?[] args) => Run(args);
    public static Variable OptimizedHotSpotAnalysis(params object?[] args) => Run(args);
    public static Variable OptimizedOutlierAnalysis(params object?[] args) => Run(args);
    public static Variable OrdinaryLeastSquares(params object?[] args) => Run(args);
    public static Variable PresenceOnlyPrediction(params object?[] args) => Run(args);
    public static Variable SimilaritySearch(params object?[] args) => Run(args);
    public static Variable SpatialAssociationBetweenZones(params object?[] args) => Run(args);
    public static Variable SpatialAutocorrelation(params object?[] args) => Run(args);
    public static Variable SpatialOutlierDetection(params object?[] args) => Run(args);
    public static Variable SpatiallyConstrainedMultivariateClustering(params object?[] args) => Run(args);
    public static Variable StandardDistance(params object?[] args) => Run(args);
    public static Variable TimeSeriesSmoothing(params object?[] args) => Run(args);
}
