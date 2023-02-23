using System.Runtime.CompilerServices;

namespace ArcPy;

public static class GeostatisticalAnalyst
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return Engine.Run($"arcpy.{method}_ga", args);
    }

    public static Variable ArealInterpolationLayerToPolygons(params object?[] args) => Run(args);
    public static Variable CompareGeostatisticalLayers(params object?[] args) => Run(args);
    public static Variable CreateSpatiallyBalancedPoints(params object?[] args) => Run(args);
    public static Variable CrossValidation(params object?[] args) => Run(args);
    public static Variable DensifySamplingNetwork(params object?[] args) => Run(args);
    public static Variable DiffusionInterpolationWithBarriers(params object?[] args) => Run(args);
    public static Variable EBKRegressionPrediction(params object?[] args) => Run(args);
    public static Variable EmpiricalBayesianKriging3D(params object?[] args) => Run(args);
    public static Variable EmpiricalBayesianKriging(params object?[] args) => Run(args);
    public static Variable ExploratoryInterpolation(params object?[] args) => Run(args);
    public static Variable ExtractValuesToTable(params object?[] args) => Run(args);
    public static Variable GACalculateZValue(params object?[] args) => Run(args);
    public static Variable GACreateGeostatisticalLayer(params object?[] args) => Run(args);
    public static Variable GAGetModelParameter(params object?[] args) => Run(args);
    public static Variable GALayer3DToMultidimensionalRaster(params object?[] args) => Run(args);
    public static Variable GALayer3DToNetCDF(params object?[] args) => Run(args);
    public static Variable GALayerToContour(params object?[] args) => Run(args);
    public static Variable GALayerToGrid(params object?[] args) => Run(args);
    public static Variable GALayerToPoints(params object?[] args) => Run(args);
    public static Variable GALayerToRasters(params object?[] args) => Run(args);
    public static Variable GAMovingWindowKriging(params object?[] args) => Run(args);
    public static Variable GANeighborhoodSelection(params object?[] args) => Run(args);
    public static Variable GASemivariogramSensitivity(params object?[] args) => Run(args);
    public static Variable GASetModelParameter(params object?[] args) => Run(args);
    public static Variable GaussianGeostatisticalSimulations(params object?[] args) => Run(args);
    public static Variable GenerateSubsetPolygons(params object?[] args) => Run(args);
    public static Variable GlobalPolynomialInterpolation(params object?[] args) => Run(args);
    public static Variable IDW(params object?[] args) => Run(args);
    public static Variable KernelInterpolationWithBarriers(params object?[] args) => Run(args);
    public static Variable LocalPolynomialInterpolation(params object?[] args) => Run(args);
    public static Variable RadialBasisFunctions(params object?[] args) => Run(args);
    public static Variable SubsetFeatures(params object?[] args) => Run(args);
}
