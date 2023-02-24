﻿using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class SpatialAnalyst
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.sa.{method}", args);
    }

    public Variable ACos(params object?[] args) => Run(args);
    public Variable ACosH(params object?[] args) => Run(args);
    public Variable ASin(params object?[] args) => Run(args);
    public Variable ASinH(params object?[] args) => Run(args);
    public Variable ATan(params object?[] args) => Run(args);
    public Variable ATan2(params object?[] args) => Run(args);
    public Variable ATanH(params object?[] args) => Run(args);
    public Variable Abs(params object?[] args) => Run(args);
    public Variable AddSurfaceInformation(params object?[] args) => Run(args);
    public Variable Aggregate(params object?[] args) => Run(args);
    public Variable AggregateMultidimensionalRaster(params object?[] args) => Run(args);
    public Variable Anomaly(params object?[] args) => Run(args);
    public Variable Apply(params object?[] args) => Run(args);
    public Variable ApplyEnvironment(params object?[] args) => Run(args);
    public Variable AreaSolarRadiation(params object?[] args) => Run(args);
    public Variable ArgStatistics(params object?[] args) => Run(args);
    public Variable Arithmetic(params object?[] args) => Run(args);
    public Variable Aspect(params object?[] args) => Run(args);
    public Variable AspectSlope(params object?[] args) => Run(args);
    public Variable BAI(params object?[] args) => Run(args);
    public Variable BandArithmetic(params object?[] args) => Run(args);
    public Variable BandCollectionStats(params object?[] args) => Run(args);
    public Variable Basin(params object?[] args) => Run(args);
    public Variable BitwiseAnd(params object?[] args) => Run(args);
    public Variable BitwiseLeftShift(params object?[] args) => Run(args);
    public Variable BitwiseNot(params object?[] args) => Run(args);
    public Variable BitwiseOr(params object?[] args) => Run(args);
    public Variable BitwiseRightShift(params object?[] args) => Run(args);
    public Variable BitwiseXOr(params object?[] args) => Run(args);
    public Variable BlockStatistics(params object?[] args) => Run(args);
    public Variable BooleanAnd(params object?[] args) => Run(args);
    public Variable BooleanNot(params object?[] args) => Run(args);
    public Variable BooleanOr(params object?[] args) => Run(args);
    public Variable BooleanXOr(params object?[] args) => Run(args);
    public Variable BoundaryClean(params object?[] args) => Run(args);
    public Variable CIg(params object?[] args) => Run(args);
    public Variable CIre(params object?[] args) => Run(args);
    public Variable CalculateKernelDensityRatio(params object?[] args) => Run(args);
    public Variable CellStatistics(params object?[] args) => Run(args);
    public Variable ClassProbability(params object?[] args) => Run(args);
    public Variable Classify(params object?[] args) => Run(args);
    public Variable ClassifyRaster(params object?[] args) => Run(args);
    public Variable ClayMinerals(params object?[] args) => Run(args);
    public Variable Colormap(params object?[] args) => Run(args);
    public Variable ColormapToRGB(params object?[] args) => Run(args);
    public Variable ColorspaceConversion(params object?[] args) => Run(args);
    public Variable CombinatorialAnd(params object?[] args) => Run(args);
    public Variable CombinatorialOr(params object?[] args) => Run(args);
    public Variable CombinatorialXOr(params object?[] args) => Run(args);
    public Variable Combine(params object?[] args) => Run(args);
    public Variable Complex(params object?[] args) => Run(args);
    public Variable CompositeBand(params object?[] args) => Run(args);
    public Variable CompoundParameter(params object?[] args) => Run(args);
    public Variable ComputeConfusionMatrix(params object?[] args) => Run(args);
    public Variable ComputeSegmentAttributes(params object?[] args) => Run(args);
    public Variable Con(params object?[] args) => Run(args);
    public Variable Contour(params object?[] args) => Run(args);
    public Variable ContourList(params object?[] args) => Run(args);
    public Variable ContourWithBarriers(params object?[] args) => Run(args);
    public Variable ContrastBrightness(params object?[] args) => Run(args);
    public Variable Convolution(params object?[] args) => Run(args);
    public Variable Corridor(params object?[] args) => Run(args);
    public Variable Cos(params object?[] args) => Run(args);
    public Variable CosH(params object?[] args) => Run(args);
    public Variable CostAllocation(params object?[] args) => Run(args);
    public Variable CostBackLink(params object?[] args) => Run(args);
    public Variable CostConnectivity(params object?[] args) => Run(args);
    public Variable CostDistance(params object?[] args) => Run(args);
    public Variable CostPath(params object?[] args) => Run(args);
    public Variable CostPathAsPolyline(params object?[] args) => Run(args);
    public Variable CreateAccuracyAssessmentPoints(params object?[] args) => Run(args);
    public Variable CreateConstantRaster(params object?[] args) => Run(args);
    public Variable CreateNormalRaster(params object?[] args) => Run(args);
    public Variable CreateRandomRaster(params object?[] args) => Run(args);
    public Variable CreateSignatures(params object?[] args) => Run(args);
    public Variable Curvature(params object?[] args) => Run(args);
    public Variable CutFill(params object?[] args) => Run(args);
    public Variable DarcyFlow(params object?[] args) => Run(args);
    public Variable DarcyVelocity(params object?[] args) => Run(args);
    public Variable DeepLearningModelToEcd(params object?[] args) => Run(args);
    public Variable Dendrogram(params object?[] args) => Run(args);
    public Variable DeriveContinuousFlow(params object?[] args) => Run(args);
    public Variable DeriveStreamAsLine(params object?[] args) => Run(args);
    public Variable DeriveStreamAsRaster(params object?[] args) => Run(args);
    public Variable Diff(params object?[] args) => Run(args);
    public Variable DimensionalMovingStatistics(params object?[] args) => Run(args);
    public Variable DistanceAccumulation(params object?[] args) => Run(args);
    public Variable DistanceAllocation(params object?[] args) => Run(args);
    public Variable Divide(params object?[] args) => Run(args);
    public Variable EVI(params object?[] args) => Run(args);
    public Variable EditSignatures(params object?[] args) => Run(args);
    public Variable ElevationVoidFill(params object?[] args) => Run(args);
    public Variable EqualTo(params object?[] args) => Run(args);
    public Variable EqualToFrequency(params object?[] args) => Run(args);
    public Variable EucAllocation(params object?[] args) => Run(args);
    public Variable EucBackDirection(params object?[] args) => Run(args);
    public Variable EucDirection(params object?[] args) => Run(args);
    public Variable EucDistance(params object?[] args) => Run(args);
    public Variable Exp(params object?[] args) => Run(args);
    public Variable Exp10(params object?[] args) => Run(args);
    public Variable Exp2(params object?[] args) => Run(args);
    public Variable Expand(params object?[] args) => Run(args);
    public Variable ExportTrainingDataForDeepLearning(params object?[] args) => Run(args);
    public Variable Extent(params object?[] args) => Run(args);
    public Variable ExtractBand(params object?[] args) => Run(args);
    public Variable ExtractByAttributes(params object?[] args) => Run(args);
    public Variable ExtractByCircle(params object?[] args) => Run(args);
    public Variable ExtractByMask(params object?[] args) => Run(args);
    public Variable ExtractByPoints(params object?[] args) => Run(args);
    public Variable ExtractByPolygon(params object?[] args) => Run(args);
    public Variable ExtractByRectangle(params object?[] args) => Run(args);
    public Variable ExtractMultiValuesToPoints(params object?[] args) => Run(args);
    public Variable ExtractValuesToPoints(params object?[] args) => Run(args);
    public Variable FerrousMinerals(params object?[] args) => Run(args);
    public Variable Fill(params object?[] args) => Run(args);
    public Variable Filter(params object?[] args) => Run(args);
    public Variable Float(params object?[] args) => Run(args);
    public Variable FloatDivide(params object?[] args) => Run(args);
    public Variable FloorDivide(params object?[] args) => Run(args);
    public Variable FlowAccumulation(params object?[] args) => Run(args);
    public Variable FlowDirection(params object?[] args) => Run(args);
    public Variable FlowDistance(params object?[] args) => Run(args);
    public Variable FlowLength(params object?[] args) => Run(args);
    public Variable FocalFlow(params object?[] args) => Run(args);
    public Variable FocalStatistics(params object?[] args) => Run(args);
    public Variable Foreach(params object?[] args) => Run(args);
    public Variable Functions(params object?[] args) => Run(args);
    public Variable FuzzyGaussian(params object?[] args) => Run(args);
    public Variable FuzzyLarge(params object?[] args) => Run(args);
    public Variable FuzzyLinear(params object?[] args) => Run(args);
    public Variable FuzzyMSLarge(params object?[] args) => Run(args);
    public Variable FuzzyMSSmall(params object?[] args) => Run(args);
    public Variable FuzzyMembership(params object?[] args) => Run(args);
    public Variable FuzzyNear(params object?[] args) => Run(args);
    public Variable FuzzyOverlay(params object?[] args) => Run(args);
    public Variable FuzzySmall(params object?[] args) => Run(args);
    public Variable GEMI(params object?[] args) => Run(args);
    public Variable GNDVI(params object?[] args) => Run(args);
    public Variable GVITM(params object?[] args) => Run(args);
    public Variable GenerateMultidimensionalAnomaly(params object?[] args) => Run(args);
    public Variable GenerateTrainingSamplesFromSeedPoints(params object?[] args) => Run(args);
    public Variable Grayscale(params object?[] args) => Run(args);
    public Variable GreaterThan(params object?[] args) => Run(args);
    public Variable GreaterThanEqual(params object?[] args) => Run(args);
    public Variable GreaterThanFrequency(params object?[] args) => Run(args);
    public Variable HeatIndex(params object?[] args) => Run(args);
    public Variable HfBinary(params object?[] args) => Run(args);
    public Variable HfForward(params object?[] args) => Run(args);
    public Variable HfInverseLinear(params object?[] args) => Run(args);
    public Variable HfLinear(params object?[] args) => Run(args);
    public Variable HfTable(params object?[] args) => Run(args);
    public Variable HighestPosition(params object?[] args) => Run(args);
    public Variable Hillshade(params object?[] args) => Run(args);
    public Variable Idw(params object?[] args) => Run(args);
    public Variable InList(params object?[] args) => Run(args);
    public Variable InspectTrainingSamples(params object?[] args) => Run(args);
    public Variable Int(params object?[] args) => Run(args);
    public Variable InterpolateShape(params object?[] args) => Run(args);
    public Variable IronOxide(params object?[] args) => Run(args);
    public Variable IsNull(params object?[] args) => Run(args);
    public Variable IsoCluster(params object?[] args) => Run(args);
    public Variable IsoClusterUnsupervisedClassification(params object?[] args) => Run(args);
    public Variable KernelDensity(params object?[] args) => Run(args);
    public Variable Kriging(params object?[] args) => Run(args);
    public Variable KrigingModelOrdinary(params object?[] args) => Run(args);
    public Variable KrigingModelUniversal(params object?[] args) => Run(args);
    public Variable LessThan(params object?[] args) => Run(args);
    public Variable LessThanEqual(params object?[] args) => Run(args);
    public Variable LessThanFrequency(params object?[] args) => Run(args);
    public Variable LineDensity(params object?[] args) => Run(args);
    public Variable LineStatistics(params object?[] args) => Run(args);
    public Variable LinearSpectralUnmixing(params object?[] args) => Run(args);
    public Variable LinearUnmixing(params object?[] args) => Run(args);
    public Variable Ln(params object?[] args) => Run(args);
    public Variable LocateRegions(params object?[] args) => Run(args);
    public Variable Log10(params object?[] args) => Run(args);
    public Variable Log2(params object?[] args) => Run(args);
    public Variable Lookup(params object?[] args) => Run(args);
    public Variable LowestPosition(params object?[] args) => Run(args);
    public Variable MLClassify(params object?[] args) => Run(args);
    public Variable MSAVI(params object?[] args) => Run(args);
    public Variable MTVI2(params object?[] args) => Run(args);
    public Variable MajorityFilter(params object?[] args) => Run(args);
    public Variable Mask(params object?[] args) => Run(args);
    public Variable Minus(params object?[] args) => Run(args);
    public Variable Mod(params object?[] args) => Run(args);
    public Variable NBR(params object?[] args) => Run(args);
    public Variable NDBI(params object?[] args) => Run(args);
    public Variable NDMI(params object?[] args) => Run(args);
    public Variable NDSI(params object?[] args) => Run(args);
    public Variable NDVI(params object?[] args) => Run(args);
    public Variable NDVIre(params object?[] args) => Run(args);
    public Variable NDWI(params object?[] args) => Run(args);
    public Variable NaturalNeighbor(params object?[] args) => Run(args);
    public Variable NbrAnnulus(params object?[] args) => Run(args);
    public Variable NbrCircle(params object?[] args) => Run(args);
    public Variable NbrIrregular(params object?[] args) => Run(args);
    public Variable NbrRectangle(params object?[] args) => Run(args);
    public Variable NbrWedge(params object?[] args) => Run(args);
    public Variable NbrWeight(params object?[] args) => Run(args);
    public Variable Negate(params object?[] args) => Run(args);
    public Variable Nibble(params object?[] args) => Run(args);
    public Variable NotEqual(params object?[] args) => Run(args);
    public Variable ObserverPoints(params object?[] args) => Run(args);
    public Variable OptimalPathAsLine(params object?[] args) => Run(args);
    public Variable OptimalPathAsRaster(params object?[] args) => Run(args);
    public Variable OptimalRegionConnections(params object?[] args) => Run(args);
    public Variable Over(params object?[] args) => Run(args);
    public Variable PVI(params object?[] args) => Run(args);
    public Variable Pansharpen(params object?[] args) => Run(args);
    public Variable ParameterClasses(params object?[] args) => Run(args);
    public Variable ParticleTrack(params object?[] args) => Run(args);
    public Variable PathAllocation(params object?[] args) => Run(args);
    public Variable PathBackLink(params object?[] args) => Run(args);
    public Variable PathDistance(params object?[] args) => Run(args);
    public Variable Pick(params object?[] args) => Run(args);
    public Variable Plus(params object?[] args) => Run(args);
    public Variable Point(params object?[] args) => Run(args);
    public Variable PointDensity(params object?[] args) => Run(args);
    public Variable PointStatistics(params object?[] args) => Run(args);
    public Variable PointsSolarRadiation(params object?[] args) => Run(args);
    public Variable Popularity(params object?[] args) => Run(args);
    public Variable PorousPuff(params object?[] args) => Run(args);
    public Variable Power(params object?[] args) => Run(args);
    public Variable PrincipalComponents(params object?[] args) => Run(args);
    public Variable RTVICore(params object?[] args) => Run(args);
    public Variable RadiusFixed(params object?[] args) => Run(args);
    public Variable RadiusVariable(params object?[] args) => Run(args);
    public Variable Rank(params object?[] args) => Run(args);
    public Variable Raster(params object?[] args) => Run(args);
    public Variable RasterCalculator(params object?[] args) => Run(args);
    public Variable RasterCellIterator(params object?[] args) => Run(args);
    public Variable RasterInfo(params object?[] args) => Run(args);
    public Variable RasterizeFeatures(params object?[] args) => Run(args);
    public Variable ReclassByASCIIFile(params object?[] args) => Run(args);
    public Variable ReclassByTable(params object?[] args) => Run(args);
    public Variable Reclassify(params object?[] args) => Run(args);
    public Variable RegionGroup(params object?[] args) => Run(args);
    public Variable RegionGrow(params object?[] args) => Run(args);
    public Variable Remap(params object?[] args) => Run(args);
    public Variable RemapRange(params object?[] args) => Run(args);
    public Variable RemapValue(params object?[] args) => Run(args);
    public Variable RemoveRasterSegmentTilingArtifacts(params object?[] args) => Run(args);
    public Variable Render(params object?[] args) => Run(args);
    public Variable Resample(params object?[] args) => Run(args);
    public Variable RescaleByFunction(params object?[] args) => Run(args);
    public Variable RoundDown(params object?[] args) => Run(args);
    public Variable RoundUp(params object?[] args) => Run(args);
    public Variable SAVI(params object?[] args) => Run(args);
    public Variable SRre(params object?[] args) => Run(args);
    public Variable Sample(params object?[] args) => Run(args);
    public Variable SegMeanShift(params object?[] args) => Run(args);
    public Variable SegmentMeanShift(params object?[] args) => Run(args);
    public Variable SetNull(params object?[] args) => Run(args);
    public Variable ShadedRelief(params object?[] args) => Run(args);
    public Variable Shrink(params object?[] args) => Run(args);
    public Variable Sin(params object?[] args) => Run(args);
    public Variable SinH(params object?[] args) => Run(args);
    public Variable Sink(params object?[] args) => Run(args);
    public Variable Slice(params object?[] args) => Run(args);
    public Variable Slope(params object?[] args) => Run(args);
    public Variable SnapPourPoint(params object?[] args) => Run(args);
    public Variable SolarRadiationGraphics(params object?[] args) => Run(args);
    public Variable Speckle(params object?[] args) => Run(args);
    public Variable SpectralConversion(params object?[] args) => Run(args);
    public Variable Spline(params object?[] args) => Run(args);
    public Variable SplineWithBarriers(params object?[] args) => Run(args);
    public Variable Square(params object?[] args) => Run(args);
    public Variable SquareRoot(params object?[] args) => Run(args);
    public Variable Statistics(params object?[] args) => Run(args);
    public Variable StatisticsHistogram(params object?[] args) => Run(args);
    public Variable StorageCapacity(params object?[] args) => Run(args);
    public Variable StreamLink(params object?[] args) => Run(args);
    public Variable StreamOrder(params object?[] args) => Run(args);
    public Variable StreamToFeature(params object?[] args) => Run(args);
    public Variable Stretch(params object?[] args) => Run(args);
    public Variable Subset(params object?[] args) => Run(args);
    public Variable Sultan(params object?[] args) => Run(args);
    public Variable SurfaceParameters(params object?[] args) => Run(args);
    public Variable TSAVI(params object?[] args) => Run(args);
    public Variable TabulateArea(params object?[] args) => Run(args);
    public Variable Tan(params object?[] args) => Run(args);
    public Variable TanH(params object?[] args) => Run(args);
    public Variable TasseledCap(params object?[] args) => Run(args);
    public Variable Test(params object?[] args) => Run(args);
    public Variable TfExponential(params object?[] args) => Run(args);
    public Variable TfGaussian(params object?[] args) => Run(args);
    public Variable TfLarge(params object?[] args) => Run(args);
    public Variable TfLinear(params object?[] args) => Run(args);
    public Variable TfLogarithm(params object?[] args) => Run(args);
    public Variable TfLogisticDecay(params object?[] args) => Run(args);
    public Variable TfLogisticGrowth(params object?[] args) => Run(args);
    public Variable TfMSLarge(params object?[] args) => Run(args);
    public Variable TfMSSmall(params object?[] args) => Run(args);
    public Variable TfNear(params object?[] args) => Run(args);
    public Variable TfPower(params object?[] args) => Run(args);
    public Variable TfSmall(params object?[] args) => Run(args);
    public Variable TfSymmetricLinear(params object?[] args) => Run(args);
    public Variable Thin(params object?[] args) => Run(args);
    public Variable Threshold(params object?[] args) => Run(args);
    public Variable TimeMultipleDays(params object?[] args) => Run(args);
    public Variable TimeSpecialDays(params object?[] args) => Run(args);
    public Variable TimeWholeYear(params object?[] args) => Run(args);
    public Variable TimeWithinDay(params object?[] args) => Run(args);
    public Variable Times(params object?[] args) => Run(args);
    public Variable TopoBoundary(params object?[] args) => Run(args);
    public Variable TopoCliff(params object?[] args) => Run(args);
    public Variable TopoCoast(params object?[] args) => Run(args);
    public Variable TopoContour(params object?[] args) => Run(args);
    public Variable TopoExclusion(params object?[] args) => Run(args);
    public Variable TopoLake(params object?[] args) => Run(args);
    public Variable TopoPointElevation(params object?[] args) => Run(args);
    public Variable TopoSink(params object?[] args) => Run(args);
    public Variable TopoStream(params object?[] args) => Run(args);
    public Variable TopoToRaster(params object?[] args) => Run(args);
    public Variable TopoToRasterByFile(params object?[] args) => Run(args);
    public Variable TrainIsoClusterClassifier(params object?[] args) => Run(args);
    public Variable TrainKNearestNeighborClassifier(params object?[] args) => Run(args);
    public Variable TrainMaximumLikelihoodClassifier(params object?[] args) => Run(args);
    public Variable TrainRandomTreesClassifier(params object?[] args) => Run(args);
    public Variable TrainSupportVectorMachineClassifier(params object?[] args) => Run(args);
    public Variable TransposeBits(params object?[] args) => Run(args);
    public Variable Trend(params object?[] args) => Run(args);
    public Variable UnitConversion(params object?[] args) => Run(args);
    public Variable UpdateAccuracyAssessmentPoints(params object?[] args) => Run(args);
    public Variable Utils(params object?[] args) => Run(args);
    public Variable VARI(params object?[] args) => Run(args);
    public Variable VectorField(params object?[] args) => Run(args);
    public Variable VectorFieldRenderer(params object?[] args) => Run(args);
    public Variable VfBinary(params object?[] args) => Run(args);
    public Variable VfCos(params object?[] args) => Run(args);
    public Variable VfCosSec(params object?[] args) => Run(args);
    public Variable VfInverseLinear(params object?[] args) => Run(args);
    public Variable VfLinear(params object?[] args) => Run(args);
    public Variable VfSec(params object?[] args) => Run(args);
    public Variable VfSecCos(params object?[] args) => Run(args);
    public Variable VfSymInverseLinear(params object?[] args) => Run(args);
    public Variable VfSymLinear(params object?[] args) => Run(args);
    public Variable VfTable(params object?[] args) => Run(args);
    public Variable Viewshed(params object?[] args) => Run(args);
    public Variable Viewshed2(params object?[] args) => Run(args);
    public Variable Visibility(params object?[] args) => Run(args);
    public Variable WOTable(params object?[] args) => Run(args);
    public Variable WSTable(params object?[] args) => Run(args);
    public Variable Watershed(params object?[] args) => Run(args);
    public Variable WeightedOverlay(params object?[] args) => Run(args);
    public Variable WeightedSum(params object?[] args) => Run(args);
    public Variable WindChill(params object?[] args) => Run(args);
    public Variable ZonalFill(params object?[] args) => Run(args);
    public Variable ZonalGeometry(params object?[] args) => Run(args);
    public Variable ZonalGeometryAsTable(params object?[] args) => Run(args);
    public Variable ZonalHistogram(params object?[] args) => Run(args);
    public Variable ZonalRemap(params object?[] args) => Run(args);
    public Variable ZonalStatistics(params object?[] args) => Run(args);
    public Variable ZonalStatisticsAsTable(params object?[] args) => Run(args);
}
