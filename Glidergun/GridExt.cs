using ArcPyNet;

namespace Glidergun;

public static class GridExt
{
    private static readonly ArcPy arcpy = ArcPy.Instance;
    private static readonly _SpatialAnalyst spatialAnalyst = arcpy.sa;

    #region Conditional

    public static Grid Con(this Grid grid1, Grid grid2, Grid grid3)
        => CoreExt.Con(spatialAnalyst, grid1, grid2, grid3);

    public static Grid Con(this Grid grid1, Grid grid2, int n)
        => CoreExt.Con(spatialAnalyst, grid1, grid2, n);

    public static Grid Con(this Grid grid1, Grid grid2, double n)
        => CoreExt.Con(spatialAnalyst, grid1, grid2, n);

    public static Grid Con(this Grid grid1, int n, Grid grid2)
        => CoreExt.Con(spatialAnalyst, grid1, n, grid2);

    public static Grid Con(this Grid grid1, double n, Grid grid2)
        => CoreExt.Con(spatialAnalyst, grid1, n, grid2);

    public static Grid Con(this Grid grid, int n1, int n2)
        => CoreExt.Con(spatialAnalyst, grid, n1, n2);

    public static Grid Con(this Grid grid, double n1, double n2)
        => CoreExt.Con(spatialAnalyst, grid, n1, n2);

    public static Grid Pick(this Grid grid, params Grid[] grids)
        => CoreExt.Pick(spatialAnalyst, grid, grids);

    public static Grid SetNull(this Grid grid1, Grid grid2)
        => CoreExt.SetNull(spatialAnalyst, grid1, grid2);

    public static Grid SetNull(this Grid grid, int n)
        => CoreExt.SetNull(spatialAnalyst, grid, n);

    public static Grid SetNull(this Grid grid, double n)
        => CoreExt.SetNull(spatialAnalyst, grid, n);

    public static Grid SetNull(this Grid grid1, Grid grid2, string whereClause)
        => CoreExt.SetNull(spatialAnalyst, grid1, grid2, whereClause);

    public static Grid SetNull(this Grid grid, int n, string whereClause)
        => CoreExt.SetNull(spatialAnalyst, grid, n, whereClause);

    public static Grid SetNull(this Grid grid, double n, string whereClause)
        => CoreExt.SetNull(spatialAnalyst, grid, n, whereClause);

    #endregion

    #region Density

    public static Grid KernelDensity(FilePath inFeatures, string populationField, double? cellSize = null, double? searchRadius = null, string? areaUnitScaleFactor = null, string? outCellValues = null, string? method = null)
        => CoreExt.KernelDensity(spatialAnalyst, inFeatures, populationField, cellSize, searchRadius, areaUnitScaleFactor, outCellValues, method);

    public static Grid LineDensity(FilePath inPolylineFeatures, string populationField, double? cellSize = null, double? searchRadius = null, string? areaUnitScaleFactor = null)
        => CoreExt.LineDensity(spatialAnalyst, inPolylineFeatures, populationField, cellSize, searchRadius, areaUnitScaleFactor);

    public static Grid PointDensity(FilePath inPointFeatures, string populationField, double? cellSize = null, Nbr? neighborhood = null, string? areaUnitScaleFactor = null)
        => CoreExt.PointDensity(spatialAnalyst, inPointFeatures, populationField, cellSize, neighborhood, areaUnitScaleFactor);

    #endregion

    #region Distance

    public static Grid Corridor(this Grid inDistanceGrid1, Grid inDistanceGrid2)
        => CoreExt.Corridor(spatialAnalyst, inDistanceGrid1, inDistanceGrid2);

    public static Grid CostAllocation(this Grid inSourceData, Grid inCostGrid, double? maximumDistance = null, Grid? inValueGrid = null, string? sourceField = null, Grid? outDistanceGrid = null, Grid? outBacklinkGrid = null, double sourceCostMultiplier = 1, double sourceStartCost = 0, double sourceResistanceRate = 0, double? sourceCapacity = null, SourceDirection sourceDirection = SourceDirection.From_Source)
        => CoreExt.CostAllocation(spatialAnalyst, inSourceData, inCostGrid, maximumDistance, inValueGrid, sourceField, outDistanceGrid, outBacklinkGrid, sourceCostMultiplier, sourceStartCost, sourceResistanceRate, sourceCapacity, sourceDirection);

    public static Grid CostBackLink(this Grid inSourceData, Grid inCostGrid, double? maximumDistance = null, Grid? outDistanceGrid = null, double sourceCostMultiplier = 1, double sourceStartCost = 0, double sourceResistanceRate = 0, double? sourceCapacity = null, SourceDirection sourceDirection = SourceDirection.From_Source)
        => CoreExt.CostBackLink(spatialAnalyst, inSourceData, inCostGrid, maximumDistance, outDistanceGrid, sourceCostMultiplier, sourceStartCost, sourceResistanceRate, sourceCapacity, sourceDirection);

    public static void CostConnectivity(this Grid inRegions, Grid inCostGrid, FilePath outFeatureClass, string? outNeighborPaths = null)
        => CoreExt.CostConnectivity(spatialAnalyst, inRegions, inCostGrid, outFeatureClass, outNeighborPaths);

    public static Grid CostDistance(this Grid inSourceData, Grid inCostGrid, double? maximumDistance = null, Grid? outBacklinkGrid = null, double sourceCostMultiplier = 1, double sourceStartCost = 0, double sourceResistanceRate = 0, double? sourceCapacity = null, SourceDirection sourceDirection = SourceDirection.From_Source)
        => CoreExt.CostDistance(spatialAnalyst, inSourceData, inCostGrid, maximumDistance, outBacklinkGrid, sourceCostMultiplier, sourceStartCost, sourceResistanceRate, sourceCapacity, sourceDirection);

    public static Grid CostPath(this Grid inDestinationData, Grid inCostDistanceGrid, Grid inCostBacklinkGrid, string? pathType = null, string? destinationField = null, bool? forceFlowDirectionConvention = null)
        => CoreExt.CostPath(spatialAnalyst, inDestinationData, inCostDistanceGrid, inCostBacklinkGrid, pathType, destinationField, forceFlowDirectionConvention);

    public static void CostPathAsPolyline(this Grid inDestinationData, Grid inCostDistanceGrid, Grid inCostBacklinkGrid, FilePath outPolylineFeatures, string? pathType = null, string? destinationField = null, bool? forceFlowDirectionConvention = null)
        => CoreExt.CostPathAsPolyline(spatialAnalyst, inDestinationData, inCostDistanceGrid, inCostBacklinkGrid, outPolylineFeatures, pathType, destinationField, forceFlowDirectionConvention);

    public static Grid EucBackDirection(this Grid inSourceData, Grid? inBarrierData = null, double? maximumDistance = null, double? cellSize = null, string? distanceMethod = null)
        => CoreExt.EucBackDirection(spatialAnalyst, inSourceData, inBarrierData, maximumDistance, cellSize, distanceMethod);

    public static Grid EucDirection(this Grid inSourceData, double? maximumDistance = null, double? cellSize = null, Grid? outDistanceGrid = null, string? distanceMethod = null, Grid? inBarrierData = null, Grid? outBackDirectionGrid = null)
        => CoreExt.EucDirection(spatialAnalyst, inSourceData, maximumDistance, cellSize, outDistanceGrid, distanceMethod, inBarrierData, outBackDirectionGrid);

    public static Grid EucDistance(this Grid inSourceData, double? maximumDistance = null, double? cellSize = null, Grid? outDirectionGrid = null, string? distanceMethod = null, Grid? inBarrierData = null, Grid? outBackDirectionGrid = null)
        => CoreExt.EucDistance(spatialAnalyst, inSourceData, maximumDistance, cellSize, outDirectionGrid, distanceMethod, inBarrierData, outBackDirectionGrid);

    #endregion

    #region Extraction

    public static Grid ExtractByAttributes(this Grid inGrid, string whereClause)
        => CoreExt.ExtractByAttributes(spatialAnalyst, inGrid, whereClause);

    public static Grid ExtractByCircle(this Grid inGrid, (double x, double y) centerPoint, double radius, ExtractionArea extractionArea = ExtractionArea.Inside)
        => CoreExt.ExtractByCircle(spatialAnalyst, inGrid, centerPoint, radius, extractionArea);

    public static Grid ExtractByPoints(this Grid inGrid, (double x, double y)[] points, ExtractionArea extractionArea = ExtractionArea.Inside)
        => CoreExt.ExtractByPoints(spatialAnalyst, inGrid, points, extractionArea);

    public static Grid ExtractByPolygon(this Grid inGrid, (double x, double y)[] points, ExtractionArea extractionArea = ExtractionArea.Inside)
        => CoreExt.ExtractByPolygon(spatialAnalyst, inGrid, points, extractionArea);

    public static Grid ExtractByRectangle(this Grid inGrid, Extent extent, ExtractionArea extractionArea = ExtractionArea.Inside)
        => CoreExt.ExtractByRectangle(spatialAnalyst, inGrid, extent, extractionArea);

    public static void ExtractMultiValuesToPoints(FilePath inPointFeatures, (Grid grid, string outputFieldName)[] inGrids, Interpolation bilinearInterpolateValues = Interpolation.None)
        => CoreExt.ExtractMultiValuesToPoints(spatialAnalyst, inPointFeatures, inGrids, bilinearInterpolateValues);

    public static void ExtractValuesToPoints(FilePath inPointFeatures, Grid inGrid, FilePath outPointFeatures, InterpolateValues interpolateValues = InterpolateValues.None, AddAttributes addAttributes = AddAttributes.Value_Only)
        => CoreExt.ExtractValuesToPoints(spatialAnalyst, inPointFeatures, inGrid, outPointFeatures, interpolateValues, addAttributes);

    public static void Sample(Grid[] inGrids, FilePath inLocationData, FilePath outTable, Resampling resamplingType = Resampling.Nearest, string? uniqueIdField = null, Slices processAsMultidimensional = Slices.Current_Slice)
        => CoreExt.Sample(spatialAnalyst, inGrids, inLocationData, outTable, resamplingType, uniqueIdField, processAsMultidimensional);

    #endregion

    #region Generalization

    public static Grid Aggregate(this Grid inGrid, int cellFactor, AggregationType aggregationType = AggregationType.Sum, ExtentHandling extentHandling = ExtentHandling.Expand, MissingValues ignoreNodata = MissingValues.Data)
        => CoreExt.Aggregate(spatialAnalyst, inGrid, cellFactor, aggregationType, extentHandling, ignoreNodata);

    public static Grid BoundaryClean(this Grid inGrid, string? sortType = null, bool? numberOfRuns = null)
        => CoreExt.BoundaryClean(spatialAnalyst, inGrid, sortType, numberOfRuns);

    public static Grid Expand(this Grid inGrid, int numberCells, params int[] zoneValues)
        => CoreExt.Expand(spatialAnalyst, inGrid, numberCells, zoneValues);

    public static Grid MajorityFilter(this Grid inGrid, string? numberNeighbors = null, FilePath? majorityDefinition = null)
        => CoreExt.MajorityFilter(spatialAnalyst, inGrid, numberNeighbors, majorityDefinition);

    public static Grid Nibble(this Grid inGrid, Grid inMaskGrid, bool? nibbleValues = null, bool? nibbleNodata = null, Grid? inZoneGrid = null)
        => CoreExt.Nibble(spatialAnalyst, inGrid, inMaskGrid, nibbleValues, nibbleNodata, inZoneGrid);

    public static Grid RegionGroup(this Grid inGrid, NumberNeighbors numberNeighbors = NumberNeighbors.Four, ZoneConnectivity zoneConnectivity = ZoneConnectivity.Within, AddLink addLink = AddLink.Add_Link, int? excludedValue = null)
        => CoreExt.RegionGroup(spatialAnalyst, inGrid, numberNeighbors, zoneConnectivity, addLink, excludedValue);

    public static Grid Shrink(this Grid inGrid, int numberCells, params int[] zoneValues)
        => CoreExt.Shrink(spatialAnalyst, inGrid, numberCells, zoneValues);

    public static Grid Thin(this Grid inGrid, string? backgroundValue = null, bool? filter = null, string? corners = null, double? maximumThickness = null)
        => CoreExt.Thin(spatialAnalyst, inGrid, backgroundValue, filter, corners, maximumThickness);

    #endregion

    #region Groundwater

    public static Grid DarcyFlow(this Grid inHeadGrid, Grid inPorosityGrid, Grid inThicknessGrid, Grid inTransmissivityGrid, Grid? outDirectionGrid = null, Grid? outMagnitudeGrid = null)
        => CoreExt.DarcyFlow(spatialAnalyst, inHeadGrid, inPorosityGrid, inThicknessGrid, inTransmissivityGrid, outDirectionGrid, outMagnitudeGrid);

    public static Grid DarcyVelocity(this Grid inHeadGrid, Grid inPorosityGrid, Grid inThicknessGrid, Grid inTransmissivityGrid, Grid outMagnitudeGrid)
        => CoreExt.DarcyVelocity(spatialAnalyst, inHeadGrid, inPorosityGrid, inThicknessGrid, inTransmissivityGrid, outMagnitudeGrid);

    public static void ParticleTrack(this Grid inDirectionGrid, Grid inMagnitudeGrid, (double x, double y) sourcePoint, FilePath outTrackFile, double? stepLength = null, double? trackingTime = null, FilePath? outTrackPolylineFeatures = null)
        => CoreExt.ParticleTrack(spatialAnalyst, inDirectionGrid, inMagnitudeGrid, sourcePoint, outTrackFile, stepLength, trackingTime, outTrackPolylineFeatures);

    public static Grid PorousPuff(FilePath inTrackFile, Grid inPorosityGrid, Grid inThicknessGrid, double mass, double? dispersionTime = null, double? longitudinalDispersivity = null, double? dispersivityRatio = null, double? retardationFactor = null, double? decayCoefficient = null)
        => CoreExt.PorousPuff(spatialAnalyst, inTrackFile, inPorosityGrid, inThicknessGrid, mass, dispersionTime, longitudinalDispersivity, dispersivityRatio, retardationFactor, decayCoefficient);

    #endregion

    #region Hydrology

    public static Grid Fill(this Grid inSurfaceGrid, double? zLimit = null)
        => CoreExt.Fill(spatialAnalyst, inSurfaceGrid, zLimit);

    public static Grid FlowAccumulation(this Grid inFlowDirectionGrid, Grid? inWeightGrid = null, string? dataType = null, string? flowDirectionType = null)
        => CoreExt.FlowAccumulation(spatialAnalyst, inFlowDirectionGrid, inWeightGrid, dataType, flowDirectionType);

    public static Grid FlowDirection(this Grid inSurfaceGrid, bool? forceFlow = null, Grid? outDropGrid = null, string? flowDirectionType = null)
        => CoreExt.FlowDirection(spatialAnalyst, inSurfaceGrid, forceFlow, outDropGrid, flowDirectionType);

    public static Grid FlowDistance(this Grid inStreamGrid, Grid inSurfaceGrid, Grid? inFlowDirectionGrid = null, string? distanceType = null, string? flowDirectionType = null, string? statisticsType = null)
        => CoreExt.FlowDistance(spatialAnalyst, inStreamGrid, inSurfaceGrid, inFlowDirectionGrid, distanceType, flowDirectionType, statisticsType);

    public static Grid FlowLength(this Grid inFlowDirectionGrid, string? directionMeasurement = null, Grid? inWeightGrid = null)
        => CoreExt.FlowLength(spatialAnalyst, inFlowDirectionGrid, directionMeasurement, inWeightGrid);

    public static Grid Sink(this Grid inFlowDirectionGrid)
        => CoreExt.Sink(spatialAnalyst, inFlowDirectionGrid);

    public static Grid SnapPourPoint(this Grid inPourPointData, Grid inAccumulationGrid, double snapDistance, string? pourPointField = null)
        => CoreExt.SnapPourPoint(spatialAnalyst, inPourPointData, inAccumulationGrid, snapDistance, pourPointField);

    public static Grid StreamLink(this Grid inStreamGrid, Grid inFlowDirectionGrid)
        => CoreExt.StreamLink(spatialAnalyst, inStreamGrid, inFlowDirectionGrid);

    public static Grid StreamOrder(this Grid inStreamGrid, Grid inFlowDirectionGrid, string? orderMethod = null)
        => CoreExt.StreamOrder(spatialAnalyst, inStreamGrid, inFlowDirectionGrid, orderMethod);

    public static void StreamToFeature(this Grid inStreamGrid, Grid inFlowDirectionGrid, FilePath outPolylineFeatures, bool? simplify = null)
        => CoreExt.StreamToFeature(spatialAnalyst, inStreamGrid, inFlowDirectionGrid, outPolylineFeatures, simplify);

    public static Grid Watershed(this Grid inFlowDirectionGrid, Grid inPourPointData)
        => CoreExt.Watershed(spatialAnalyst, inFlowDirectionGrid, inPourPointData);

    public static Grid Watershed(this Grid inFlowDirectionGrid, FilePath inPourPointData, string pourPointField)
        => CoreExt.Watershed(spatialAnalyst, inFlowDirectionGrid, inPourPointData, pourPointField);

    #endregion

    #region Interpolation

    public static Grid Idw(FilePath inPointFeatures, string zField, double? cellSize = null, double power = 2, Radius? searchRadius = null, FilePath? inBarrierPolylineFeatures = null)
        => CoreExt.Idw(spatialAnalyst, inPointFeatures, zField, cellSize, power, searchRadius, inBarrierPolylineFeatures);

    public static Grid Kriging(FilePath inPointFeatures, string zField, KrigingModel krigingModel, double? cellSize = null, Radius? searchRadius = null, FilePath? outVariancePredictionGrid = null)
        => CoreExt.Kriging(spatialAnalyst, inPointFeatures, zField, krigingModel, cellSize, searchRadius, outVariancePredictionGrid);

    public static Grid NaturalNeighbor(FilePath inPointFeatures, string zField, double? cellSize = null)
        => CoreExt.NaturalNeighbor(spatialAnalyst, inPointFeatures, zField, cellSize);

    public static Grid Spline(FilePath inPointFeatures, string zField, double? cellSize = null, SplineType splineType = SplineType.Regularized, double weight = 0.1, int numberPoints = 12)
        => CoreExt.Spline(spatialAnalyst, inPointFeatures, zField, cellSize, splineType, weight, numberPoints);

    public static Grid SplineWithBarriers(FilePath inPointFeatures, string zValueField, FilePath? InputBarrierFeatures = null, double? cellSize = null, double? Smoothing_Factor = null)
        => CoreExt.SplineWithBarriers(spatialAnalyst, inPointFeatures, zValueField, InputBarrierFeatures, cellSize, Smoothing_Factor);

    public static Grid TopoToGridByFile(FilePath inParameterFile, FilePath? outStreamFeatures = null, FilePath? outSinkFeatures = null, FilePath? outResidualFeature = null, FilePath? outStreamCliffErrorFeature = null, FilePath? outContourErrorFeature = null)
        => CoreExt.TopoToGridByFile(spatialAnalyst, inParameterFile, outStreamFeatures, outSinkFeatures, outResidualFeature, outStreamCliffErrorFeature, outContourErrorFeature);

    public static Grid Trend(FilePath inPointFeatures, string zField, double? cellSize = null, int order = 1, RegressionType regressionType = RegressionType.Linear, FilePath? outRmsFile = null)
        => CoreExt.Trend(spatialAnalyst, inPointFeatures, zField, cellSize, order, regressionType, outRmsFile);

    #endregion

    #region Local

    public static Grid CellStatistics(Grid[] inGrids, string? statisticsType = null, MissingValues ignoreNodata = MissingValues.Data)
        => CoreExt.CellStatistics(spatialAnalyst, inGrids, statisticsType, ignoreNodata);

    public static Grid Combine(params Grid[] inGrids)
        => CoreExt.Combine(spatialAnalyst, inGrids);

    public static Grid EqualToFrequency(this Grid inValueGrid, params Grid[] inGrids)
        => CoreExt.EqualToFrequency(spatialAnalyst, inValueGrid, inGrids);

    public static Grid GreaterThanFrequency(this Grid inValueGrid, params Grid[] inGrids)
        => CoreExt.GreaterThanFrequency(spatialAnalyst, inValueGrid, inGrids);

    public static Grid HighestPosition(params Grid[] inGrids)
        => CoreExt.HighestPosition(spatialAnalyst, inGrids);

    public static Grid LessThanFrequency(this Grid inValueGrid, params Grid[] inGrids)
        => CoreExt.LessThanFrequency(spatialAnalyst, inValueGrid, inGrids);

    public static Grid LowestPosition(params Grid[] inGrids)
        => CoreExt.LowestPosition(spatialAnalyst, inGrids);

    public static Grid Popularity(this Grid inPopularityGridOrConstant, params Grid[] inGrids)
        => CoreExt.Popularity(spatialAnalyst, inPopularityGridOrConstant, inGrids);

    public static Grid Rank(this Grid inRankGridOrConstant, params Grid[] inGrids)
        => CoreExt.Rank(spatialAnalyst, inRankGridOrConstant, inGrids);

    #endregion

    #region Math

    public static Grid Abs(this Grid grid)
        => CoreExt.Abs(spatialAnalyst, grid);

    public static Grid Divide(this Grid grid1, Grid grid2)
        => CoreExt.Divide(spatialAnalyst, grid1, grid2);

    public static Grid Divide(this Grid grid, int n)
        => CoreExt.Divide(spatialAnalyst, grid, n);

    public static Grid Divide(int n, Grid grid)
        => CoreExt.Divide(spatialAnalyst, n, grid);

    public static Grid Divide(this Grid grid, double n)
        => CoreExt.Divide(spatialAnalyst, grid, n);

    public static Grid Divide(double n, Grid grid)
        => CoreExt.Divide(spatialAnalyst, n, grid);

    public static Grid Exp(this Grid grid)
        => CoreExt.Exp(spatialAnalyst, grid);

    public static Grid Exp10(this Grid grid)
        => CoreExt.Exp10(spatialAnalyst, grid);

    public static Grid Exp2(this Grid grid)
        => CoreExt.Exp2(spatialAnalyst, grid);

    public static Grid Float(this Grid grid)
        => CoreExt.Float(spatialAnalyst, grid);

    public static Grid Int(this Grid grid)
        => CoreExt.Int(spatialAnalyst, grid);

    public static Grid Ln(this Grid grid)
        => CoreExt.Ln(spatialAnalyst, grid);

    public static Grid Log10(this Grid grid)
        => CoreExt.Log10(spatialAnalyst, grid);

    public static Grid Log2(this Grid grid)
        => CoreExt.Log2(spatialAnalyst, grid);

    public static Grid Minus(this Grid grid1, Grid grid2)
        => CoreExt.Minus(spatialAnalyst, grid1, grid2);

    public static Grid Minus(this Grid grid, int n)
        => CoreExt.Minus(spatialAnalyst, grid, n);

    public static Grid Minus(int n, Grid grid)
        => CoreExt.Minus(spatialAnalyst, n, grid);

    public static Grid Minus(this Grid grid, double n)
        => CoreExt.Minus(spatialAnalyst, grid, n);

    public static Grid Minus(double n, Grid grid)
        => CoreExt.Minus(spatialAnalyst, n, grid);

    public static Grid Mod(this Grid grid1, Grid grid2)
        => CoreExt.Mod(spatialAnalyst, grid1, grid2);

    public static Grid Mod(this Grid grid, int n)
        => CoreExt.Mod(spatialAnalyst, grid, n);

    public static Grid Mod(int n, Grid grid)
        => CoreExt.Mod(spatialAnalyst, n, grid);

    public static Grid Mod(this Grid grid, double n)
        => CoreExt.Mod(spatialAnalyst, grid, n);

    public static Grid Mod(double n, Grid grid)
        => CoreExt.Mod(spatialAnalyst, n, grid);

    public static Grid Negate(this Grid grid)
        => CoreExt.Negate(spatialAnalyst, grid);

    public static Grid Plus(this Grid grid1, Grid grid2)
        => CoreExt.Plus(spatialAnalyst, grid1, grid2);

    public static Grid Plus(this Grid grid, int n)
        => CoreExt.Plus(spatialAnalyst, grid, n);

    public static Grid Plus(int n, Grid grid)
        => CoreExt.Plus(spatialAnalyst, n, grid);

    public static Grid Plus(this Grid grid, double n)
        => CoreExt.Plus(spatialAnalyst, grid, n);

    public static Grid Plus(double n, Grid grid)
        => CoreExt.Plus(spatialAnalyst, n, grid);

    public static Grid Power(this Grid grid1, Grid grid2)
        => CoreExt.Power(spatialAnalyst, grid1, grid2);

    public static Grid Power(this Grid grid, int n)
        => CoreExt.Power(spatialAnalyst, grid, n);

    public static Grid Power(int n, Grid grid)
        => CoreExt.Power(spatialAnalyst, n, grid);

    public static Grid Power(this Grid grid, double n)
        => CoreExt.Power(spatialAnalyst, grid, n);

    public static Grid Power(double n, Grid grid)
        => CoreExt.Power(spatialAnalyst, n, grid);

    public static Grid RoundDown(this Grid grid)
        => CoreExt.RoundDown(spatialAnalyst, grid);

    public static Grid RoundUp(this Grid grid)
        => CoreExt.RoundUp(spatialAnalyst, grid);

    public static Grid Square(this Grid grid)
        => CoreExt.Square(spatialAnalyst, grid);

    public static Grid SquareRoot(this Grid grid)
        => CoreExt.SquareRoot(spatialAnalyst, grid);

    public static Grid Times(this Grid grid1, Grid grid2)
        => CoreExt.Times(spatialAnalyst, grid1, grid2);

    public static Grid Times(this Grid grid, int n)
        => CoreExt.Times(spatialAnalyst, grid, n);

    public static Grid Times(int n, Grid grid)
        => CoreExt.Times(spatialAnalyst, n, grid);

    public static Grid Times(this Grid grid, double n)
        => CoreExt.Times(spatialAnalyst, grid, n);

    public static Grid Times(double n, Grid grid)
        => CoreExt.Times(spatialAnalyst, n, grid);

    #region Bitwise

    public static Grid BitwiseAnd(this Grid grid1, Grid grid2)
        => CoreExt.BitwiseAnd(spatialAnalyst, grid1, grid2);

    public static Grid BitwiseAnd(this Grid grid, int n)
        => CoreExt.BitwiseAnd(spatialAnalyst, grid, n);

    public static Grid BitwiseAnd(int n, Grid grid)
        => CoreExt.BitwiseAnd(spatialAnalyst, n, grid);

    public static Grid BitwiseAnd(this Grid grid, double n)
        => CoreExt.BitwiseAnd(spatialAnalyst, grid, n);

    public static Grid BitwiseAnd(double n, Grid grid)
        => CoreExt.BitwiseAnd(spatialAnalyst, n, grid);

    public static Grid BitwiseLeftShift(this Grid grid1, Grid grid2)
        => CoreExt.BitwiseLeftShift(spatialAnalyst, grid1, grid2);

    public static Grid BitwiseLeftShift(this Grid grid, int n)
        => CoreExt.BitwiseLeftShift(spatialAnalyst, grid, n);

    public static Grid BitwiseLeftShift(int n, Grid grid)
        => CoreExt.BitwiseLeftShift(spatialAnalyst, n, grid);

    public static Grid BitwiseLeftShift(this Grid grid, double n)
        => CoreExt.BitwiseLeftShift(spatialAnalyst, grid, n);

    public static Grid BitwiseLeftShift(double n, Grid grid)
        => CoreExt.BitwiseLeftShift(spatialAnalyst, n, grid);

    public static Grid BitwiseNot(this Grid grid)
        => CoreExt.BitwiseNot(spatialAnalyst, grid);

    public static Grid BitwiseOr(this Grid grid1, Grid grid2)
        => CoreExt.BitwiseOr(spatialAnalyst, grid1, grid2);

    public static Grid BitwiseOr(this Grid grid, int n)
        => CoreExt.BitwiseOr(spatialAnalyst, grid, n);

    public static Grid BitwiseOr(int n, Grid grid)
        => CoreExt.BitwiseOr(spatialAnalyst, n, grid);

    public static Grid BitwiseOr(this Grid grid, double n)
        => CoreExt.BitwiseOr(spatialAnalyst, grid, n);

    public static Grid BitwiseOr(double n, Grid grid)
        => CoreExt.BitwiseOr(spatialAnalyst, n, grid);

    public static Grid BitwiseRightShift(this Grid grid1, Grid grid2)
        => CoreExt.BitwiseRightShift(spatialAnalyst, grid1, grid2);

    public static Grid BitwiseRightShift(this Grid grid, int n)
        => CoreExt.BitwiseRightShift(spatialAnalyst, grid, n);

    public static Grid BitwiseRightShift(int n, Grid grid)
        => CoreExt.BitwiseRightShift(spatialAnalyst, n, grid);

    public static Grid BitwiseRightShift(this Grid grid, double n)
        => CoreExt.BitwiseRightShift(spatialAnalyst, grid, n);

    public static Grid BitwiseRightShift(double n, Grid grid)
        => CoreExt.BitwiseRightShift(spatialAnalyst, n, grid);

    public static Grid BitwiseXOr(this Grid grid1, Grid grid2)
        => CoreExt.BitwiseXOr(spatialAnalyst, grid1, grid2);

    public static Grid BitwiseXOr(this Grid grid, int n)
        => CoreExt.BitwiseXOr(spatialAnalyst, grid, n);

    public static Grid BitwiseXOr(int n, Grid grid)
        => CoreExt.BitwiseXOr(spatialAnalyst, n, grid);

    public static Grid BitwiseXOr(this Grid grid, double n)
        => CoreExt.BitwiseXOr(spatialAnalyst, grid, n);

    public static Grid BitwiseXOr(double n, Grid grid)
        => CoreExt.BitwiseXOr(spatialAnalyst, n, grid);

    #endregion

    #region Logical

    public static Grid BooleanAnd(this Grid grid1, Grid grid2)
        => CoreExt.BooleanAnd(spatialAnalyst, grid1, grid2);

    public static Grid BooleanAnd(this Grid grid, int n)
        => CoreExt.BooleanAnd(spatialAnalyst, grid, n);

    public static Grid BooleanAnd(int n, Grid grid)
        => CoreExt.BooleanAnd(spatialAnalyst, n, grid);

    public static Grid BooleanAnd(this Grid grid, double n)
        => CoreExt.BooleanAnd(spatialAnalyst, grid, n);

    public static Grid BooleanAnd(double n, Grid grid)
        => CoreExt.BooleanAnd(spatialAnalyst, n, grid);

    public static Grid BooleanNot(this Grid grid)
        => CoreExt.BooleanNot(spatialAnalyst, grid);

    public static Grid BooleanOr(this Grid grid1, Grid grid2)
        => CoreExt.BooleanOr(spatialAnalyst, grid1, grid2);

    public static Grid BooleanOr(this Grid grid, int n)
        => CoreExt.BooleanOr(spatialAnalyst, grid, n);

    public static Grid BooleanOr(int n, Grid grid)
        => CoreExt.BooleanOr(spatialAnalyst, n, grid);

    public static Grid BooleanOr(this Grid grid, double n)
        => CoreExt.BooleanOr(spatialAnalyst, grid, n);

    public static Grid BooleanOr(double n, Grid grid)
        => CoreExt.BooleanOr(spatialAnalyst, n, grid);

    public static Grid BooleanXOr(this Grid grid1, Grid grid2)
        => CoreExt.BooleanXOr(spatialAnalyst, grid1, grid2);

    public static Grid BooleanXOr(this Grid grid, int n)
        => CoreExt.BooleanXOr(spatialAnalyst, grid, n);

    public static Grid BooleanXOr(int n, Grid grid)
        => CoreExt.BooleanXOr(spatialAnalyst, n, grid);

    public static Grid BooleanXOr(this Grid grid, double n)
        => CoreExt.BooleanXOr(spatialAnalyst, grid, n);

    public static Grid BooleanXOr(double n, Grid grid)
        => CoreExt.BooleanXOr(spatialAnalyst, n, grid);

    public static Grid CombinatorialAnd(this Grid grid1, Grid grid2)
        => CoreExt.CombinatorialAnd(spatialAnalyst, grid1, grid2);

    public static Grid CombinatorialAnd(this Grid grid, int n)
        => CoreExt.CombinatorialAnd(spatialAnalyst, grid, n);

    public static Grid CombinatorialAnd(int n, Grid grid)
        => CoreExt.CombinatorialAnd(spatialAnalyst, n, grid);

    public static Grid CombinatorialOr(this Grid grid1, Grid grid2)
        => CoreExt.CombinatorialOr(spatialAnalyst, grid1, grid2);

    public static Grid CombinatorialOr(this Grid grid, int n)
        => CoreExt.CombinatorialOr(spatialAnalyst, grid, n);

    public static Grid CombinatorialOr(int n, Grid grid)
        => CoreExt.CombinatorialOr(spatialAnalyst, n, grid);

    public static Grid CombinatorialXOr(this Grid grid1, Grid grid2)
        => CoreExt.CombinatorialXOr(spatialAnalyst, grid1, grid2);

    public static Grid CombinatorialXOr(this Grid grid, int n)
        => CoreExt.CombinatorialXOr(spatialAnalyst, grid, n);

    public static Grid CombinatorialXOr(int n, Grid grid)
        => CoreExt.CombinatorialXOr(spatialAnalyst, n, grid);

    public static Grid Diff(this Grid grid1, Grid grid2)
        => CoreExt.Diff(spatialAnalyst, grid1, grid2);

    public static Grid Diff(this Grid grid, int n)
        => CoreExt.Diff(spatialAnalyst, grid, n);

    public static Grid Diff(int n, Grid grid)
        => CoreExt.Diff(spatialAnalyst, n, grid);

    public static Grid Diff(this Grid grid, double n)
        => CoreExt.Diff(spatialAnalyst, grid, n);

    public static Grid Diff(double n, Grid grid)
        => CoreExt.Diff(spatialAnalyst, n, grid);

    public static Grid EqualTo(this Grid grid1, Grid grid2)
        => CoreExt.EqualTo(spatialAnalyst, grid1, grid2);

    public static Grid EqualTo(this Grid grid, int n)
        => CoreExt.EqualTo(spatialAnalyst, grid, n);

    public static Grid EqualTo(int n, Grid grid)
        => CoreExt.EqualTo(spatialAnalyst, n, grid);

    public static Grid EqualTo(this Grid grid, double n)
        => CoreExt.EqualTo(spatialAnalyst, grid, n);

    public static Grid EqualTo(double n, Grid grid)
        => CoreExt.EqualTo(spatialAnalyst, n, grid);

    public static Grid GreaterThan(this Grid grid1, Grid grid2)
        => CoreExt.GreaterThan(spatialAnalyst, grid1, grid2);

    public static Grid GreaterThan(this Grid grid, int n)
        => CoreExt.GreaterThan(spatialAnalyst, grid, n);

    public static Grid GreaterThan(int n, Grid grid)
        => CoreExt.GreaterThan(spatialAnalyst, n, grid);

    public static Grid GreaterThan(this Grid grid, double n)
        => CoreExt.GreaterThan(spatialAnalyst, grid, n);

    public static Grid GreaterThan(double n, Grid grid)
        => CoreExt.GreaterThan(spatialAnalyst, n, grid);

    public static Grid GreaterThanEqual(this Grid grid1, Grid grid2)
        => CoreExt.GreaterThanEqual(spatialAnalyst, grid1, grid2);

    public static Grid GreaterThanEqual(this Grid grid, int n)
        => CoreExt.GreaterThanEqual(spatialAnalyst, grid, n);

    public static Grid GreaterThanEqual(int n, Grid grid)
        => CoreExt.GreaterThanEqual(spatialAnalyst, n, grid);

    public static Grid GreaterThanEqual(this Grid grid, double n)
        => CoreExt.GreaterThanEqual(spatialAnalyst, grid, n);

    public static Grid GreaterThanEqual(double n, Grid grid)
        => CoreExt.GreaterThanEqual(spatialAnalyst, n, grid);

    public static Grid InList(this Grid grid, params Grid[] list)
        => CoreExt.InList(spatialAnalyst, grid, list);

    public static Grid InList(this Grid grid, params int[] list)
        => CoreExt.InList(spatialAnalyst, grid, list);

    public static Grid InList(int n, params Grid[] list)
        => CoreExt.InList(spatialAnalyst, n, list);

    public static Grid InList(this Grid grid, params double[] list)
        => CoreExt.InList(spatialAnalyst, grid, list);

    public static Grid InList(double n, params Grid[] list)
        => CoreExt.InList(spatialAnalyst, n, list);

    public static Grid IsNull(this Grid grid)
        => CoreExt.IsNull(spatialAnalyst, grid);

    public static Grid LessThan(this Grid grid1, Grid grid2)
        => CoreExt.LessThan(spatialAnalyst, grid1, grid2);

    public static Grid LessThan(this Grid grid, int n)
        => CoreExt.LessThan(spatialAnalyst, grid, n);

    public static Grid LessThan(int n, Grid grid)
        => CoreExt.LessThan(spatialAnalyst, n, grid);

    public static Grid LessThan(this Grid grid, double n)
        => CoreExt.LessThan(spatialAnalyst, grid, n);

    public static Grid LessThan(double n, Grid grid)
        => CoreExt.LessThan(spatialAnalyst, n, grid);

    public static Grid LessThanEqual(this Grid grid1, Grid grid2)
        => CoreExt.LessThanEqual(spatialAnalyst, grid1, grid2);

    public static Grid LessThanEqual(this Grid grid, int n)
        => CoreExt.LessThanEqual(spatialAnalyst, grid, n);

    public static Grid LessThanEqual(int n, Grid grid)
        => CoreExt.LessThanEqual(spatialAnalyst, n, grid);

    public static Grid LessThanEqual(this Grid grid, double n)
        => CoreExt.LessThanEqual(spatialAnalyst, grid, n);

    public static Grid LessThanEqual(double n, Grid grid)
        => CoreExt.LessThanEqual(spatialAnalyst, n, grid);

    public static Grid NotEqual(this Grid grid1, Grid grid2)
        => CoreExt.NotEqual(spatialAnalyst, grid1, grid2);

    public static Grid NotEqual(this Grid grid, int n)
        => CoreExt.NotEqual(spatialAnalyst, grid, n);

    public static Grid NotEqual(int n, Grid grid)
        => CoreExt.NotEqual(spatialAnalyst, n, grid);

    public static Grid NotEqual(this Grid grid, double n)
        => CoreExt.NotEqual(spatialAnalyst, grid, n);

    public static Grid NotEqual(double n, Grid grid)
        => CoreExt.NotEqual(spatialAnalyst, n, grid);

    public static Grid Over(this Grid grid1, Grid grid2)
        => CoreExt.Over(spatialAnalyst, grid1, grid2);

    public static Grid Over(this Grid grid, int n)
        => CoreExt.Over(spatialAnalyst, grid, n);

    public static Grid Over(int n, Grid grid)
        => CoreExt.Over(spatialAnalyst, n, grid);

    public static Grid Over(this Grid grid, double n)
        => CoreExt.Over(spatialAnalyst, grid, n);

    public static Grid Over(double n, Grid grid)
        => CoreExt.Over(spatialAnalyst, n, grid);

    public static Grid Test(this Grid grid, string whereClause)
        => CoreExt.Test(spatialAnalyst, grid, whereClause);

    #endregion

    #region Trigonometric

    public static Grid ACos(this Grid grid)
        => CoreExt.ACos(spatialAnalyst, grid);

    public static Grid ACosH(this Grid grid)
        => CoreExt.ACosH(spatialAnalyst, grid);

    public static Grid ASin(this Grid grid)
        => CoreExt.ASin(spatialAnalyst, grid);

    public static Grid ASinH(this Grid grid)
        => CoreExt.ASinH(spatialAnalyst, grid);

    public static Grid ATan(this Grid grid)
        => CoreExt.ATan(spatialAnalyst, grid);

    public static Grid ATan2(this Grid grid1, Grid grid2)
        => CoreExt.ATan2(spatialAnalyst, grid1, grid2);

    public static Grid ATan2(this Grid grid, int n)
        => CoreExt.ATan2(spatialAnalyst, grid, n);

    public static Grid ATan2(this Grid grid, double n)
        => CoreExt.ATan2(spatialAnalyst, grid, n);

    public static Grid ATan2(int n, Grid grid)
        => CoreExt.ATan2(spatialAnalyst, n, grid);

    public static Grid ATan2(double n, Grid grid)
        => CoreExt.ATan2(spatialAnalyst, n, grid);

    public static Grid ATanH(this Grid grid)
        => CoreExt.ATanH(spatialAnalyst, grid);

    public static Grid Cos(this Grid grid)
        => CoreExt.Cos(spatialAnalyst, grid);

    public static Grid CosH(this Grid grid)
        => CoreExt.CosH(spatialAnalyst, grid);

    public static Grid Sin(this Grid grid)
        => CoreExt.Sin(spatialAnalyst, grid);

    public static Grid SinH(this Grid grid)
        => CoreExt.SinH(spatialAnalyst, grid);

    public static Grid Tan(this Grid grid)
        => CoreExt.Tan(spatialAnalyst, grid);

    public static Grid TanH(this Grid grid)
        => CoreExt.TanH(spatialAnalyst, grid);

    #endregion

    #endregion

    #region Multivariate

    public static void BandCollectionStats(Grid[] inGridBands, FilePath outStatFile, bool? computeMatrices = null)
        => CoreExt.BandCollectionStats(spatialAnalyst, inGridBands, outStatFile, computeMatrices);

    public static Grid ClassProbability(Grid[] inGridBands, FilePath inSignatureFile, int? maximumOutputValue = null, APriori aPrioriProbabilities = APriori.Equal, FilePath? inAPrioriFile = null)
        => CoreExt.ClassProbability(spatialAnalyst, inGridBands, inSignatureFile, maximumOutputValue, aPrioriProbabilities, inAPrioriFile);

    public static void CreateSignatures(Grid[] inGridBands, Grid inSampleData, FilePath outSignatureFile, ComputeCovariance computeCovariance = ComputeCovariance.Covariance, string? sampleField = null)
        => CoreExt.CreateSignatures(spatialAnalyst, inGridBands, inSampleData, outSignatureFile, computeCovariance, sampleField);

    public static void Dendrogram(FilePath inSignatureFile, FilePath outDendrogramFile, DistanceCalculation distanceCalculation = DistanceCalculation.Variance, int lineWidth = 78)
        => CoreExt.Dendrogram(spatialAnalyst, inSignatureFile, outDendrogramFile, distanceCalculation, lineWidth);

    public static void EditSignatures(Grid[] inGridBands, FilePath inSignatureFile, FilePath inSignatureRemapFile, FilePath outSignatureFile, int sampleInterval = 10)
        => CoreExt.EditSignatures(spatialAnalyst, inGridBands, inSignatureFile, inSignatureRemapFile, outSignatureFile, sampleInterval);

    public static void IsoCluster(Grid[] inGridBands, FilePath outSignatureFile, int numberClasses, int numberIterations = 20, int minClassSize = 20, int sampleInterval = 10)
        => CoreExt.IsoCluster(spatialAnalyst, inGridBands, outSignatureFile, numberClasses, numberIterations, minClassSize, sampleInterval);

    public static Grid IsoClusterUnsupervisedClassification(Grid[] inGridBands, int numberOfClasses, int minimumClassSize = 20, int sampleInterval = 10, FilePath? outSignatureFile = null)
        => CoreExt.IsoClusterUnsupervisedClassification(spatialAnalyst, inGridBands, numberOfClasses, minimumClassSize, sampleInterval, outSignatureFile);

    public static Grid MLClassify(Grid[] inGridBands, FilePath inSignatureFile, string? rejectFraction = null, string? aPrioriProbabilities = null, FilePath? inAPrioriFile = null, Grid? outConfidenceGrid = null)
        => CoreExt.MLClassify(spatialAnalyst, inGridBands, inSignatureFile, rejectFraction, aPrioriProbabilities, inAPrioriFile, outConfidenceGrid);

    public static Grid PrincipalComponents(Grid[] inGridBands, int? numberComponents = null, FilePath? outDataFile = null)
        => CoreExt.PrincipalComponents(spatialAnalyst, inGridBands, numberComponents, outDataFile);

    #endregion

    #region Neighborhood

    public static Grid BlockStatistics(this Grid inGrid, Nbr? neighborhood = null, StatisticsType statisticsType = StatisticsType.Mean, MissingValues ignoreNodata = MissingValues.Data)
        => CoreExt.BlockStatistics(spatialAnalyst, inGrid, neighborhood ?? Nbr.Rectangle(3, 3, NeighborhoodUnit.Cell), statisticsType, ignoreNodata);

    public static Grid Filter(this Grid inGrid, FilterType filterType = FilterType.Low, MissingValues ignoreNodata = MissingValues.Data)
        => CoreExt.Filter(spatialAnalyst, inGrid, filterType, ignoreNodata);

    public static Grid FocalFlow(this Grid inSurfaceGrid, double? thresholdValue = null)
        => CoreExt.FocalFlow(spatialAnalyst, inSurfaceGrid, thresholdValue);

    public static Grid FocalStatistics(this Grid inGrid, Nbr? neighborhood = null, StatisticsType statisticsType = StatisticsType.Mean, MissingValues ignoreNodata = MissingValues.Data)
        => CoreExt.FocalStatistics(spatialAnalyst, inGrid, neighborhood ?? Nbr.Rectangle(3, 3, NeighborhoodUnit.Cell), statisticsType, ignoreNodata);

    public static Grid LineStatistics(FilePath inPolylineFeatures, string field, double? cellSize = null, double? searchRadius = null, StatisticsType statisticsType = StatisticsType.Mean)
        => CoreExt.LineStatistics(spatialAnalyst, inPolylineFeatures, field, cellSize, searchRadius, statisticsType);

    public static Grid PointStatistics(FilePath inPointFeatures, string field, double? cellSize = null, Nbr? neighborhood = null, StatisticsType statisticsType = StatisticsType.Mean)
        => CoreExt.PointStatistics(spatialAnalyst, inPointFeatures, field, cellSize, neighborhood ?? Nbr.Rectangle(3, 3, NeighborhoodUnit.Cell), statisticsType);

    #endregion

    #region Overlay

    public static Grid FuzzyMembership(this Grid inGrid, Fuzzy? fuzzyFunction = null, string? hedge = null)
        => CoreExt.FuzzyMembership(spatialAnalyst, inGrid, fuzzyFunction, hedge);

    public static Grid FuzzyOverlay(Grid[] inGrids, string? overlayType = null, double? gamma = null)
        => CoreExt.FuzzyOverlay(spatialAnalyst, inGrids, overlayType, gamma);

    public static Grid WeightedOverlay(FilePath inWeightedOverlayTable)
        => CoreExt.WeightedOverlay(spatialAnalyst, inWeightedOverlayTable);

    #endregion

    #region Creation

    public static Grid CreateConstantGrid(int constantValue, double? cellSize = null, Extent? extent = null)
        => CoreExt.CreateConstantGrid(spatialAnalyst, constantValue, cellSize, extent);

    public static Grid CreateConstantGrid(double constantValue, double? cellSize = null, Extent? extent = null)
        => CoreExt.CreateConstantGrid(spatialAnalyst, constantValue, cellSize, extent);

    public static Grid CreateNormalGrid(double? cellSize = null, Extent? extent = null)
        => CoreExt.CreateNormalGrid(spatialAnalyst, cellSize, extent);

    public static Grid CreateRandomGrid(double? seedValue = null, double? cellSize = null, Extent? extent = null)
        => CoreExt.CreateRandomGrid(spatialAnalyst, seedValue, cellSize, extent);

    #endregion

    #region Reclass

    public static Grid Lookup(this Grid inGrid, string lookupField)
        => CoreExt.Lookup(spatialAnalyst, inGrid, lookupField);

    public static Grid ReclassByASCIIFile(this Grid inGrid, FilePath inRemapFile, MissingValues missingValues = MissingValues.Data)
        => CoreExt.ReclassByASCIIFile(spatialAnalyst, inGrid, inRemapFile, missingValues);

    public static Grid ReclassByTable(this Grid inGrid, FilePath inRemapTable, string fromValueField, string toValueField, string outputValueField, MissingValues missingValues = MissingValues.Data)
        => CoreExt.ReclassByTable(spatialAnalyst, inGrid, inRemapTable, fromValueField, toValueField, outputValueField, missingValues);

    public static Grid Reclassify(this Grid inGrid, string reclassField, Remap remap, MissingValues missingValues = MissingValues.Data)
        => CoreExt.Reclassify(spatialAnalyst, inGrid, reclassField, remap, missingValues);

    public static Grid RescaleByFunction(this Grid inGrid, Tf? transformationFunction = null, double fromScale = 1, double toScale = 10)
        => CoreExt.RescaleByFunction(spatialAnalyst, inGrid, transformationFunction, fromScale, toScale);

    public static Grid Slice(this Grid inGrid, int numberZones, SliceType sliceType = SliceType.Equal_Interval, int baseOutputZone = 1)
        => CoreExt.Slice(spatialAnalyst, inGrid, numberZones, sliceType, baseOutputZone);

    #endregion

    #region Segmentation and Classification

    public static Grid ClassifyGrid(this Grid inGrid, FilePath inClassifierDefinition, Grid? inAdditionalGrid = null)
        => CoreExt.ClassifyGrid(spatialAnalyst, inGrid, inClassifierDefinition, inAdditionalGrid);

    public static void ComputeConfusionMatrix(FilePath inAccuracyAssessmentPoints, FilePath outConfusionMatrix)
        => CoreExt.ComputeConfusionMatrix(spatialAnalyst, inAccuracyAssessmentPoints, outConfusionMatrix);

    public static Grid ComputeSegmentAttributes(this Grid inSegmentedGrid, Grid? inAdditionalGrid = null, string? usedAttributes = null)
        => CoreExt.ComputeSegmentAttributes(spatialAnalyst, inSegmentedGrid, inAdditionalGrid, usedAttributes);

    public static void CreateAccuracyAssessmentPoints(this Grid inClassData, FilePath outPoints, string? targetField = null, int numRandomPoints = 500, string? sampling = null)
        => CoreExt.CreateAccuracyAssessmentPoints(spatialAnalyst, inClassData, outPoints, targetField, numRandomPoints, sampling);

    public static void GenerateTrainingSamplesFromSeedPoints(this Grid inClassData, FilePath inSeedPoints, FilePath outTrainingFeatureClass, double? minSampleArea = null, double? maxSampleRadius = null)
        => CoreExt.GenerateTrainingSamplesFromSeedPoints(spatialAnalyst, inClassData, inSeedPoints, outTrainingFeatureClass, minSampleArea, maxSampleRadius);

    public static Grid InspectTrainingSamples(this Grid inGrid, FilePath inTrainingFeatures, FilePath inClassifierDefinition, FilePath outTrainingFeatureClass, Grid? inAdditionalGrid = null)
        => CoreExt.InspectTrainingSamples(spatialAnalyst, inGrid, inTrainingFeatures, inClassifierDefinition, outTrainingFeatureClass, inAdditionalGrid);

    public static Grid RemoveGridSegmentTilingArtifacts(this Grid inSegmentedGrid, int tileSizeX = 512, int tileSizeY = 512)
        => CoreExt.RemoveGridSegmentTilingArtifacts(spatialAnalyst, inSegmentedGrid, tileSizeX, tileSizeY);

    public static Grid SegmentMeanShift(this Grid inGrid, double? spectralDetail = null, double? spatialDetail = null, int? minSegmentSize = null, string? bandIndexes = null)
        => CoreExt.SegmentMeanShift(spatialAnalyst, inGrid, spectralDetail, spatialDetail, minSegmentSize, bandIndexes);

    public static void TrainIsoClusterClassifier(this Grid inGrid, int maxClasses, FilePath outClassifierDefinition, Grid? inAdditionalGrid = null, int? maxIterations = null, int? minSamplesPerCluster = null, int? skipFactor = null, string? usedAttributes = null, int? maxMergePerIter = null, double? maxMergeDistance = null)
        => CoreExt.TrainIsoClusterClassifier(spatialAnalyst, inGrid, maxClasses, outClassifierDefinition, inAdditionalGrid, maxIterations, minSamplesPerCluster, skipFactor, usedAttributes, maxMergePerIter, maxMergeDistance);

    public static void TrainMaximumLikelihoodClassifier(this Grid inGrid, FilePath inTrainingFeatures, FilePath outClassifierDefinition, Grid? inAdditionalGrid = null, string[]? usedAttributes = null)
        => CoreExt.TrainMaximumLikelihoodClassifier(spatialAnalyst, inGrid, inTrainingFeatures, outClassifierDefinition, inAdditionalGrid, usedAttributes);

    public static void TrainRandomTreesClassifier(this Grid inGrid, FilePath inTrainingFeatures, FilePath outClassifierDefinition, Grid? inAdditionalGrid = null, int? maxNumTrees = null, int? maxTreeDepth = null, int? maxSamplesPerClass = null, string? usedAttributes = null)
        => CoreExt.TrainRandomTreesClassifier(spatialAnalyst, inGrid, inTrainingFeatures, outClassifierDefinition, inAdditionalGrid, maxNumTrees, maxTreeDepth, maxSamplesPerClass, usedAttributes);

    public static void TrainSupportVectorMachineClassifier(this Grid inGrid, FilePath inTrainingFeatures, FilePath outClassifierDefinition, Grid? inAdditionalGrid = null, int? maxSamplesPerClass = null, string? usedAttributes = null)
        => CoreExt.TrainSupportVectorMachineClassifier(spatialAnalyst, inGrid, inTrainingFeatures, outClassifierDefinition, inAdditionalGrid, maxSamplesPerClass, usedAttributes);

    public static void UpdateAccuracyAssessmentPoints(this Grid inClassData, FilePath inPoints, FilePath outPoints, string? targetField = null)
        => CoreExt.UpdateAccuracyAssessmentPoints(spatialAnalyst, inClassData, inPoints, outPoints, targetField);

    #endregion

    #region Solar Radiation

    #endregion

    #region Surface

    public static Grid Aspect(this Grid inGrid, bool geodesic = false, ZUnit zUnit = ZUnit.Meter)
        => CoreExt.Aspect(spatialAnalyst, inGrid, geodesic, zUnit);

    public static void Contour(this Grid inGrid, FilePath outPolylineFeatures, double contourInterval, double baseContour = 0, double zFactor = 1)
        => CoreExt.Contour(spatialAnalyst, inGrid, outPolylineFeatures, contourInterval, baseContour, zFactor);

    public static void ContourList(this Grid inGrid, FilePath outPolylineFeatures, params double[] contourValue)
        => CoreExt.ContourList(spatialAnalyst, inGrid, outPolylineFeatures, contourValue);

    public static void ContourWithBarriers(this Grid inGrid, FilePath outContourFeatureClass, FilePath? inBarrierFeatures = null, ContourType inContourType = ContourType.Contour, FilePath? inContourValuesFile = null, bool explicitOnly = false, double inBaseContour = 0, double? inContourInterval = null, double? inIndexedContourInterval = null, double[]? inExplicitContour = null, double inZFactor = 1)
        => CoreExt.ContourWithBarriers(spatialAnalyst, inGrid, outContourFeatureClass, inBarrierFeatures, inContourType, inContourValuesFile, explicitOnly, inBaseContour, inContourInterval, inIndexedContourInterval, inExplicitContour, inZFactor);

    public static Grid Curvature(this Grid inGrid, double zFactor = 1, Grid? outProfileCurveGrid = null, FilePath? outPlanCurveGrid = null)
        => CoreExt.Curvature(spatialAnalyst, inGrid, zFactor, outProfileCurveGrid, outPlanCurveGrid);

    public static Grid CutFill(this Grid inBeforeSurface, Grid inAfterSurface, double zFactor = 1)
        => CoreExt.CutFill(spatialAnalyst, inBeforeSurface, inAfterSurface, zFactor);

    public static Grid Hillshade(this Grid inGrid, double azimuth = 315, double altitude = 45, bool modelShadows = false, double zFactor = 1)
        => CoreExt.Hillshade(spatialAnalyst, inGrid, azimuth, altitude, modelShadows, zFactor);

    public static Grid ObserverPoints(this Grid inGrid, FilePath inObserverPointFeatures, double zFactor = 1, bool curvatureCorrection = false, double refractivityCoefficient = 0.13, FilePath? outAglGrid = null)
        => CoreExt.ObserverPoints(spatialAnalyst, inGrid, inObserverPointFeatures, zFactor, curvatureCorrection, refractivityCoefficient, outAglGrid);

    public static Grid Slope(this Grid inGrid, SlopeMeasurement outputMeasurement = SlopeMeasurement.Degree, double zFactor = 1, bool geodesic = false, ZUnit zUnit = ZUnit.Meter)
        => CoreExt.Slope(spatialAnalyst, inGrid, outputMeasurement, zFactor, geodesic, zUnit);

    public static Grid Viewshed(this Grid inGrid, FilePath inObserverFeatures, double zFactor = 1, bool? curvatureCorrection = null, double? refractivityCoefficient = null, FilePath? outAglGrid = null)
        => CoreExt.Viewshed(spatialAnalyst, inGrid, inObserverFeatures, zFactor, curvatureCorrection, refractivityCoefficient, outAglGrid);

    #endregion

    #region Zonal

    public static void TabulateArea(this Grid inZoneData, string zoneField, Grid inClassData, string classField, FilePath outTable, double? processingCellSize = null)
        => CoreExt.TabulateArea(spatialAnalyst, inZoneData, zoneField, inClassData, classField, outTable, processingCellSize);

    public static Grid ZonalFill(this Grid inZoneGrid, Grid inWeightGrid)
        => CoreExt.ZonalFill(spatialAnalyst, inZoneGrid, inWeightGrid);

    public static Grid ZonalGeometry(this Grid inZoneData, string zoneField, string? geometryType = null, double? cellSize = null)
        => CoreExt.ZonalGeometry(spatialAnalyst, inZoneData, zoneField, geometryType, cellSize);

    public static void ZonalGeometryAsTable(this Grid inZoneData, string zoneField, FilePath outTable, double? processingCellSize = null)
        => CoreExt.ZonalGeometryAsTable(spatialAnalyst, inZoneData, zoneField, outTable, processingCellSize);

    public static void ZonalHistogram(this Grid inZoneData, string zoneField, Grid inValueGrid, FilePath outTable, string? outGraph = null)
        => CoreExt.ZonalHistogram(spatialAnalyst, inZoneData, zoneField, inValueGrid, outTable, outGraph);

    public static Grid ZonalStatistics(this Grid inZoneData, string zoneField, Grid inValueGrid, string? statisticsType = null, MissingValues ignoreNodata = MissingValues.Data)
        => CoreExt.ZonalStatistics(spatialAnalyst, inZoneData, zoneField, inValueGrid, statisticsType, ignoreNodata);

    public static void ZonalStatisticsAsTable(this Grid inZoneData, string zoneField, Grid inValueGrid, FilePath outTable, MissingValues ignoreNodata = MissingValues.Data, string? statisticsType = null)
        => CoreExt.ZonalStatisticsAsTable(spatialAnalyst, inZoneData, zoneField, inValueGrid, outTable, ignoreNodata, statisticsType);

    #endregion

    #region Extra

    public static Grid Color(this Grid grid, ColorRamp colorRamp)
    {
        var temp1 = ArcPy.GetTempName();
        var temp2 = ArcPy.GetTempName();

        var result = arcpy.Run($"""
            arcpy.management.MakeRasterLayer(arcpy.sa.Colormap({grid.Name}, {ArcPy.Format(colorRamp)}), "{temp1}")
            arcpy.management.CopyRaster("{temp1}", "{temp2}")
            """, $"""arcpy.sa.Raster("{temp2}")""");

        return result;
    }

    private static string SaveToASCII(this Grid grid)
    {
        var path = $@"{arcpy.Workspace}\{ArcPy.GetTempName()}.txt";
        arcpy.conversion.RasterToASCII(grid, path);
        return path;
    }

    public static string ToASCII(this Grid grid)
    {
        var path = grid.SaveToASCII();
        return File.ReadAllText(path);
    }

    private static IEnumerable<string[]> ReadStringRows(this Grid grid)
    {
        var path = SaveToASCII(grid);

        using StreamReader reader = new(path);

        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine()!;
            var values = line.Split(' ');

            if (values.Length < grid.Width)
                continue;

            yield return values.Where(x => x != "").ToArray();
        }
    }

    public static IEnumerable<T?[]> ReadRows<T>(this Grid grid)
    {
        var noDataValue = grid.NoDataValue?.ToString();
        var type = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);

        foreach (var row in grid.ReadStringRows())
            yield return row.Select(x => x == noDataValue ? default : (T)Convert.ChangeType(x, type)).ToArray();
    }

    public static double[] GetXCoordinates(this Grid grid)
    {
        var xmin = grid.Extent.Xmin + grid.MeanCellWidth / 2;
        return Enumerable.Range(0, grid.Width).Select(n => xmin + grid.MeanCellWidth * n).ToArray();
    }

    public static double[] GetYCoordinates(this Grid grid)
    {
        var ymin = grid.Extent.Ymin + grid.MeanCellHeight / 2;
        return Enumerable.Range(0, grid.Height).Select(n => ymin + grid.MeanCellHeight * n).ToArray();
    }

    public static IEnumerable<(double x, double y, T? value)> ReadPoints<T>(this Grid grid)
    {
        var rows = grid.ReadRows<T?>();
        var xCoordinates = grid.GetXCoordinates();
        var yCoordinates = grid.GetYCoordinates();

        return yCoordinates
            .Reverse()
            .Zip(rows, (y, values) => new { y, values })
            .SelectMany(row => xCoordinates.Zip(row.values, (x, z) => (x, row.y, z)));
    }

    public static Grid Composite(params Grid[] grids)
    {
        return arcpy.Run($"arcpy.ia.CompositeBand({ArcPy.Format(grids)})");
    }

    public static Grid[] Extract(this Grid grid, params int[] bands)
    {
        return bands.Select(x => (Grid)arcpy.Run($"arcpy.ia.ExtractBand({grid}, [{x}])")).ToArray();
    }

    public static Grid[] Extract(this Grid grid)
    {
        return Extract(grid, Enumerable.Range(1, grid.BandCount).ToArray());
    }

    public static Grid Extract(this Grid grid, int band)
    {
        return Extract(grid, new[] { band })[0];
    }

    public static Grid Project(this Grid grid, int outWkid)
    {
        var path = $@"{arcpy.Workspace}\{ArcPy.GetTempName()}";
        arcpy.management.ProjectRaster(grid, path, (Code)$"arcpy.SpatialReference({outWkid})");
        return new Grid(path);
    }

    #endregion
}
