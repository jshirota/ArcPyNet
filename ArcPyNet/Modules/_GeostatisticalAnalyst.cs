using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _GeostatisticalAnalyst
{
    internal _GeostatisticalAnalyst() { }
}

public static class _GeostatisticalAnalystExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.ga.{method}", args);
    }

    public static Code ArealInterpolationLayerToPolygons(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code CompareGeostatisticalLayers(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code CreateSpatiallyBalancedPoints(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code CrossValidation(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code CrossValidationResult(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code DensifySamplingNetwork(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code DiffusionInterpolationWithBarriers(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code EBKRegressionPrediction(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code EmpiricalBayesianKriging(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code EmpiricalBayesianKriging3D(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code ExploratoryInterpolation(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code ExtractValuesToTable(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GACalculateZValue(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GACreateGeostatisticalLayer(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GAGetModelParameter(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GALayer3DToMultidimensionalRaster(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GALayer3DToNetCDF(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GALayerToContour(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GALayerToGrid(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GALayerToPoints(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GALayerToRasters(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GAMovingWindowKriging(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GANeighborhoodSelection(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GASemivariogramSensitivity(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GASetModelParameter(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GaussianGeostatisticalSimulations(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GenerateSubsetPolygons(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GeostatisticalDatasets(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code GlobalPolynomialInterpolation(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code IDW(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code KernelInterpolationWithBarriers(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code LocalPolynomialInterpolation(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code NearestNeighbor3D(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code RadialBasisFunctions(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code SearchNeighborhoodSmooth(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code SearchNeighborhoodSmoothCircular(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code SearchNeighborhoodStandard(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code SearchNeighborhoodStandard3D(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code SearchNeighborhoodStandardCircular(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
    public static Code SubsetFeatures(this _GeostatisticalAnalyst _, params object?[] args) => Run(args);
}
