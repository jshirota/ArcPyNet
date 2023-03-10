using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _GeostatisticalAnalyst
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.ga.{method}", args);
    }

    internal _GeostatisticalAnalyst() { }

    public Code ArealInterpolationLayerToPolygons(params object?[] args) => Run(args);
    public Code CompareGeostatisticalLayers(params object?[] args) => Run(args);
    public Code CreateSpatiallyBalancedPoints(params object?[] args) => Run(args);
    public Code CrossValidation(params object?[] args) => Run(args);
    public Code CrossValidationResult(params object?[] args) => Run(args);
    public Code DensifySamplingNetwork(params object?[] args) => Run(args);
    public Code DiffusionInterpolationWithBarriers(params object?[] args) => Run(args);
    public Code EBKRegressionPrediction(params object?[] args) => Run(args);
    public Code EmpiricalBayesianKriging(params object?[] args) => Run(args);
    public Code EmpiricalBayesianKriging3D(params object?[] args) => Run(args);
    public Code ExploratoryInterpolation(params object?[] args) => Run(args);
    public Code ExtractValuesToTable(params object?[] args) => Run(args);
    public Code GACalculateZValue(params object?[] args) => Run(args);
    public Code GACreateGeostatisticalLayer(params object?[] args) => Run(args);
    public Code GAGetModelParameter(params object?[] args) => Run(args);
    public Code GALayer3DToMultidimensionalRaster(params object?[] args) => Run(args);
    public Code GALayer3DToNetCDF(params object?[] args) => Run(args);
    public Code GALayerToContour(params object?[] args) => Run(args);
    public Code GALayerToGrid(params object?[] args) => Run(args);
    public Code GALayerToPoints(params object?[] args) => Run(args);
    public Code GALayerToRasters(params object?[] args) => Run(args);
    public Code GAMovingWindowKriging(params object?[] args) => Run(args);
    public Code GANeighborhoodSelection(params object?[] args) => Run(args);
    public Code GASemivariogramSensitivity(params object?[] args) => Run(args);
    public Code GASetModelParameter(params object?[] args) => Run(args);
    public Code GaussianGeostatisticalSimulations(params object?[] args) => Run(args);
    public Code GenerateSubsetPolygons(params object?[] args) => Run(args);
    public Code GeostatisticalDatasets(params object?[] args) => Run(args);
    public Code GlobalPolynomialInterpolation(params object?[] args) => Run(args);
    public Code IDW(params object?[] args) => Run(args);
    public Code KernelInterpolationWithBarriers(params object?[] args) => Run(args);
    public Code LocalPolynomialInterpolation(params object?[] args) => Run(args);
    public Code NearestNeighbor3D(params object?[] args) => Run(args);
    public Code RadialBasisFunctions(params object?[] args) => Run(args);
    public Code SearchNeighborhoodSmooth(params object?[] args) => Run(args);
    public Code SearchNeighborhoodSmoothCircular(params object?[] args) => Run(args);
    public Code SearchNeighborhoodStandard(params object?[] args) => Run(args);
    public Code SearchNeighborhoodStandard3D(params object?[] args) => Run(args);
    public Code SearchNeighborhoodStandardCircular(params object?[] args) => Run(args);
    public Code SubsetFeatures(params object?[] args) => Run(args);
}
