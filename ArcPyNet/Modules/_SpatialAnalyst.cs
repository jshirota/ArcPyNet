﻿using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _SpatialAnalyst
{
    internal _SpatialAnalyst() { }
}

public static class _SpatialAnalystExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.sa.{method}", args);
    }

    public static Code ACos(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ACosH(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ASin(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ASinH(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ATan(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ATan2(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ATanH(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Abs(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code AddSurfaceInformation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Aggregate(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code AggregateMultidimensionalRaster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Anomaly(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Apply(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ApplyEnvironment(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code AreaSolarRadiation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ArgStatistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Arithmetic(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Aspect(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code AspectSlope(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BAI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BandArithmetic(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BandCollectionStats(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Basin(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BitwiseAnd(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BitwiseLeftShift(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BitwiseNot(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BitwiseOr(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BitwiseRightShift(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BitwiseXOr(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BlockStatistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BooleanAnd(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BooleanNot(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BooleanOr(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BooleanXOr(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code BoundaryClean(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CIg(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CIre(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CalculateKernelDensityRatio(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CellStatistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ClassProbability(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Classify(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ClassifyRaster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ClayMinerals(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Colormap(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ColormapToRGB(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ColorspaceConversion(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CombinatorialAnd(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CombinatorialOr(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CombinatorialXOr(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Combine(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Complex(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CompositeBand(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CompoundParameter(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ComputeConfusionMatrix(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ComputeSegmentAttributes(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Con(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Contour(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ContourList(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ContourWithBarriers(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ContrastBrightness(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Convolution(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Corridor(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Cos(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CosH(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CostAllocation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CostBackLink(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CostConnectivity(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CostDistance(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CostPath(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CostPathAsPolyline(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CreateAccuracyAssessmentPoints(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CreateConstantRaster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CreateNormalRaster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CreateRandomRaster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CreateSignatures(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Curvature(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code CutFill(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DarcyFlow(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DarcyVelocity(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DeepLearningModelToEcd(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Dendrogram(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DeriveContinuousFlow(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DeriveStreamAsLine(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DeriveStreamAsRaster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Diff(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DimensionalMovingStatistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DistanceAccumulation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code DistanceAllocation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Divide(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code EVI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code EditSignatures(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ElevationVoidFill(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code EqualTo(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code EqualToFrequency(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code EucAllocation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code EucBackDirection(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code EucDirection(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code EucDistance(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Exp(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Exp10(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Exp2(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Expand(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExportTrainingDataForDeepLearning(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Extent(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractBand(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractByAttributes(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractByCircle(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractByMask(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractByPoints(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractByPolygon(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractByRectangle(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractMultiValuesToPoints(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ExtractValuesToPoints(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FerrousMinerals(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Fill(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Filter(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Float(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FloatDivide(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FloorDivide(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FlowAccumulation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FlowDirection(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FlowDistance(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FlowLength(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FocalFlow(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FocalStatistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Foreach(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Functions(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzyGaussian(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzyLarge(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzyLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzyMSLarge(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzyMSSmall(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzyMembership(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzyNear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzyOverlay(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code FuzzySmall(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code GEMI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code GNDVI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code GVITM(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code GenerateMultidimensionalAnomaly(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code GenerateTrainingSamplesFromSeedPoints(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Grayscale(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code GreaterThan(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code GreaterThanEqual(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code GreaterThanFrequency(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code HeatIndex(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code HfBinary(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code HfForward(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code HfInverseLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code HfLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code HfTable(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code HighestPosition(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Hillshade(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Idw(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code InList(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code InspectTrainingSamples(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Int(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code InterpolateShape(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code IronOxide(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code IsNull(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code IsoCluster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code IsoClusterUnsupervisedClassification(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code KernelDensity(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Kriging(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code KrigingModelOrdinary(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code KrigingModelUniversal(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LessThan(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LessThanEqual(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LessThanFrequency(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LineDensity(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LineStatistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LinearSpectralUnmixing(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LinearUnmixing(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Ln(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LocateRegions(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Log10(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Log2(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Lookup(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code LowestPosition(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code MLClassify(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code MSAVI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code MTVI2(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code MajorityFilter(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Mask(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Minus(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Mod(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NBR(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NDBI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NDMI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NDSI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NDVI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NDVIre(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NDWI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NaturalNeighbor(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NbrAnnulus(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NbrCircle(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NbrIrregular(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NbrRectangle(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NbrWedge(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NbrWeight(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Negate(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Nibble(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code NotEqual(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ObserverPoints(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code OptimalPathAsLine(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code OptimalPathAsRaster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code OptimalRegionConnections(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Over(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PVI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Pansharpen(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ParameterClasses(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ParticleTrack(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PathAllocation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PathBackLink(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PathDistance(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Pick(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Plus(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Point(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PointDensity(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PointStatistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PointsSolarRadiation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Popularity(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PorousPuff(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Power(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code PrincipalComponents(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RTVICore(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RadiusFixed(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RadiusVariable(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Rank(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Raster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RasterCalculator(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RasterCellIterator(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RasterInfo(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RasterizeFeatures(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ReclassByASCIIFile(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ReclassByTable(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Reclassify(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RegionGroup(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RegionGrow(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Remap(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RemapRange(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RemapValue(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RemoveRasterSegmentTilingArtifacts(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Render(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Resample(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RescaleByFunction(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RoundDown(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code RoundUp(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SAVI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SRre(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Sample(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SegMeanShift(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SegmentMeanShift(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SetNull(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ShadedRelief(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Shrink(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Sin(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SinH(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Sink(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Slice(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Slope(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SnapPourPoint(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SolarRadiationGraphics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Speckle(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SpectralConversion(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Spline(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SplineWithBarriers(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Square(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SquareRoot(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Statistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code StatisticsHistogram(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code StorageCapacity(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code StreamLink(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code StreamOrder(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code StreamToFeature(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Stretch(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Subset(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Sultan(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code SurfaceParameters(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TSAVI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TabulateArea(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Tan(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TanH(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TasseledCap(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Test(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfExponential(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfGaussian(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfLarge(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfLogarithm(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfLogisticDecay(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfLogisticGrowth(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfMSLarge(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfMSSmall(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfNear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfPower(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfSmall(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TfSymmetricLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Thin(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Threshold(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TimeMultipleDays(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TimeSpecialDays(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TimeWholeYear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TimeWithinDay(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Times(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoBoundary(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoCliff(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoCoast(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoContour(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoExclusion(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoLake(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoPointElevation(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoSink(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoStream(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoToRaster(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TopoToRasterByFile(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TrainIsoClusterClassifier(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TrainKNearestNeighborClassifier(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TrainMaximumLikelihoodClassifier(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TrainRandomTreesClassifier(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TrainSupportVectorMachineClassifier(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code TransposeBits(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Trend(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code UnitConversion(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code UpdateAccuracyAssessmentPoints(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Utils(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VARI(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VectorField(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VectorFieldRenderer(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfBinary(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfCos(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfCosSec(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfInverseLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfSec(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfSecCos(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfSymInverseLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfSymLinear(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code VfTable(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Viewshed(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Viewshed2(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Visibility(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code WOTable(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code WSTable(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code Watershed(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code WeightedOverlay(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code WeightedSum(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code WindChill(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ZonalFill(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ZonalGeometry(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ZonalGeometryAsTable(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ZonalHistogram(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ZonalRemap(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ZonalStatistics(this _SpatialAnalyst  _, params object?[] args) => Run(args);
    public static Code ZonalStatisticsAsTable(this _SpatialAnalyst  _, params object?[] args) => Run(args);
}
