using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _GeostatisticalAnalyst
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.ga.{method}", args);
    }

    public Variable ArealInterpolationLayerToPolygons(params object?[] args) => Run(args);
    public Variable CompareGeostatisticalLayers(params object?[] args) => Run(args);
    public Variable CreateSpatiallyBalancedPoints(params object?[] args) => Run(args);
    public Variable CrossValidation(params object?[] args) => Run(args);
    public Variable CrossValidationResult(params object?[] args) => Run(args);
    public Variable DensifySamplingNetwork(params object?[] args) => Run(args);
    public Variable DiffusionInterpolationWithBarriers(params object?[] args) => Run(args);
    public Variable EBKRegressionPrediction(params object?[] args) => Run(args);
    public Variable EmpiricalBayesianKriging(params object?[] args) => Run(args);
    public Variable EmpiricalBayesianKriging3D(params object?[] args) => Run(args);
    public Variable ExploratoryInterpolation(params object?[] args) => Run(args);
    public Variable ExtractValuesToTable(params object?[] args) => Run(args);
    public Variable GACalculateZValue(params object?[] args) => Run(args);
    public Variable GACreateGeostatisticalLayer(params object?[] args) => Run(args);
    public Variable GAGetModelParameter(params object?[] args) => Run(args);
    public Variable GALayer3DToMultidimensionalRaster(params object?[] args) => Run(args);
    public Variable GALayer3DToNetCDF(params object?[] args) => Run(args);
    public Variable GALayerToContour(params object?[] args) => Run(args);
    public Variable GALayerToGrid(params object?[] args) => Run(args);
    public Variable GALayerToPoints(params object?[] args) => Run(args);
    public Variable GALayerToRasters(params object?[] args) => Run(args);
    public Variable GAMovingWindowKriging(params object?[] args) => Run(args);
    public Variable GANeighborhoodSelection(params object?[] args) => Run(args);
    public Variable GASemivariogramSensitivity(params object?[] args) => Run(args);
    public Variable GASetModelParameter(params object?[] args) => Run(args);
    public Variable GaussianGeostatisticalSimulations(params object?[] args) => Run(args);
    public Variable GenerateSubsetPolygons(params object?[] args) => Run(args);
    public Variable GeostatisticalDatasets(params object?[] args) => Run(args);
    public Variable GlobalPolynomialInterpolation(params object?[] args) => Run(args);
    public Variable IDW(params object?[] args) => Run(args);
    public Variable KernelInterpolationWithBarriers(params object?[] args) => Run(args);
    public Variable LocalPolynomialInterpolation(params object?[] args) => Run(args);
    public Variable NearestNeighbor3D(params object?[] args) => Run(args);
    public Variable RadialBasisFunctions(params object?[] args) => Run(args);
    public Variable SearchNeighborhoodSmooth(params object?[] args) => Run(args);
    public Variable SearchNeighborhoodSmoothCircular(params object?[] args) => Run(args);
    public Variable SearchNeighborhoodStandard(params object?[] args) => Run(args);
    public Variable SearchNeighborhoodStandard3D(params object?[] args) => Run(args);
    public Variable SearchNeighborhoodStandardCircular(params object?[] args) => Run(args);
    public Variable SubsetFeatures(params object?[] args) => Run(args);
}
