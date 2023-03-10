using ArcPyNet;

namespace Glidergun;

public static class CoreExt
{
    #region Conditional

    public static Grid Con(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2, Grid grid3)
        => spatialAnalyst.Con(grid1, grid2, grid3);

    public static Grid Con(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2, int n)
        => spatialAnalyst.Con(grid1, grid2, n);

    public static Grid Con(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2, double n)
        => spatialAnalyst.Con(grid1, grid2, n);

    public static Grid Con(this _SpatialAnalyst spatialAnalyst, Grid grid1, int n, Grid grid2)
        => spatialAnalyst.Con(grid1, n, grid2);

    public static Grid Con(this _SpatialAnalyst spatialAnalyst, Grid grid1, double n, Grid grid2)
        => spatialAnalyst.Con(grid1, n, grid2);

    public static Grid Con(this _SpatialAnalyst spatialAnalyst, Grid grid, int n1, int n2)
        => spatialAnalyst.Con(grid, n1, n2);

    public static Grid Con(this _SpatialAnalyst spatialAnalyst, Grid grid, double n1, double n2)
        => spatialAnalyst.Con(grid, n1, n2);

    public static Grid Pick(this _SpatialAnalyst spatialAnalyst, Grid grid, params Grid[] grids)
        => spatialAnalyst.Pick(grid, grids);

    public static Grid SetNull(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.SetNull(grid1, grid2);

    public static Grid SetNull(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.SetNull(grid, n);

    public static Grid SetNull(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.SetNull(grid, n);

    public static Grid SetNull(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2, string whereClause)
        => spatialAnalyst.SetNull(grid1, grid2, whereClause);

    public static Grid SetNull(this _SpatialAnalyst spatialAnalyst, Grid grid, int n, string whereClause)
        => spatialAnalyst.SetNull(grid, n, whereClause);

    public static Grid SetNull(this _SpatialAnalyst spatialAnalyst, Grid grid, double n, string whereClause)
        => spatialAnalyst.SetNull(grid, n, whereClause);

    #endregion

    #region Density

    public static Grid KernelDensity(this _SpatialAnalyst spatialAnalyst, FilePath inFeatures, string populationField, double? cellSize = null, double? searchRadius = null, string? areaUnitScaleFactor = null, string? outCellValues = null, string? method = null)
        => spatialAnalyst.KernelDensity(inFeatures, populationField, cellSize, searchRadius, areaUnitScaleFactor, outCellValues, method);

    public static Grid LineDensity(this _SpatialAnalyst spatialAnalyst, FilePath inPolylineFeatures, string populationField, double? cellSize = null, double? searchRadius = null, string? areaUnitScaleFactor = null)
        => spatialAnalyst.LineDensity(inPolylineFeatures, populationField, cellSize, searchRadius, areaUnitScaleFactor);

    public static Grid PointDensity(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, string populationField, double? cellSize = null, Nbr? neighborhood = null, string? areaUnitScaleFactor = null)
        => spatialAnalyst.PointDensity(inPointFeatures, populationField, cellSize, neighborhood, areaUnitScaleFactor);

    #endregion

    #region Distance

    public static Grid Corridor(this _SpatialAnalyst spatialAnalyst, Grid inDistanceGrid1, Grid inDistanceGrid2)
        => spatialAnalyst.Corridor(inDistanceGrid1, inDistanceGrid2);

    public static Grid CostAllocation(this _SpatialAnalyst spatialAnalyst, Grid inSourceData, Grid inCostGrid, double? maximumDistance = null, Grid? inValueGrid = null, string? sourceField = null, Grid? outDistanceGrid = null, Grid? outBacklinkGrid = null, double sourceCostMultiplier = 1, double sourceStartCost = 0, double sourceResistanceRate = 0, double? sourceCapacity = null, SourceDirection sourceDirection = SourceDirection.From_Source)
        => spatialAnalyst.CostAllocation(inSourceData, inCostGrid, maximumDistance, inValueGrid, sourceField, outDistanceGrid, outBacklinkGrid, sourceCostMultiplier, sourceStartCost, sourceResistanceRate, sourceCapacity, sourceDirection);

    public static Grid CostBackLink(this _SpatialAnalyst spatialAnalyst, Grid inSourceData, Grid inCostGrid, double? maximumDistance = null, Grid? outDistanceGrid = null, double sourceCostMultiplier = 1, double sourceStartCost = 0, double sourceResistanceRate = 0, double? sourceCapacity = null, SourceDirection sourceDirection = SourceDirection.From_Source)
        => spatialAnalyst.CostBackLink(inSourceData, inCostGrid, maximumDistance, outDistanceGrid, sourceCostMultiplier, sourceStartCost, sourceResistanceRate, sourceCapacity, sourceDirection);

    public static void CostConnectivity(this _SpatialAnalyst spatialAnalyst, Grid inRegions, Grid inCostGrid, FilePath outFeatureClass, string? outNeighborPaths = null)
        => spatialAnalyst.CostConnectivity(inRegions, inCostGrid, outFeatureClass, outNeighborPaths);

    public static Grid CostDistance(this _SpatialAnalyst spatialAnalyst, Grid inSourceData, Grid inCostGrid, double? maximumDistance = null, Grid? outBacklinkGrid = null, double sourceCostMultiplier = 1, double sourceStartCost = 0, double sourceResistanceRate = 0, double? sourceCapacity = null, SourceDirection sourceDirection = SourceDirection.From_Source)
        => spatialAnalyst.CostDistance(inSourceData, inCostGrid, maximumDistance, outBacklinkGrid, sourceCostMultiplier, sourceStartCost, sourceResistanceRate, sourceCapacity, sourceDirection);

    public static Grid CostPath(this _SpatialAnalyst spatialAnalyst, Grid inDestinationData, Grid inCostDistanceGrid, Grid inCostBacklinkGrid, string? pathType = null, string? destinationField = null, bool? forceFlowDirectionConvention = null)
        => spatialAnalyst.CostPath(inDestinationData, inCostDistanceGrid, inCostBacklinkGrid, pathType, destinationField, forceFlowDirectionConvention);

    public static void CostPathAsPolyline(this _SpatialAnalyst spatialAnalyst, Grid inDestinationData, Grid inCostDistanceGrid, Grid inCostBacklinkGrid, FilePath outPolylineFeatures, string? pathType = null, string? destinationField = null, bool? forceFlowDirectionConvention = null)
        => spatialAnalyst.CostPathAsPolyline(inDestinationData, inCostDistanceGrid, inCostBacklinkGrid, outPolylineFeatures, pathType, destinationField, forceFlowDirectionConvention);

    public static Grid EucBackDirection(this _SpatialAnalyst spatialAnalyst, Grid inSourceData, Grid? inBarrierData = null, double? maximumDistance = null, double? cellSize = null, string? distanceMethod = null)
        => spatialAnalyst.EucBackDirection(inSourceData, inBarrierData, maximumDistance, cellSize, distanceMethod);

    public static Grid EucDirection(this _SpatialAnalyst spatialAnalyst, Grid inSourceData, double? maximumDistance = null, double? cellSize = null, Grid? outDistanceGrid = null, string? distanceMethod = null, Grid? inBarrierData = null, Grid? outBackDirectionGrid = null)
        => spatialAnalyst.EucDirection(inSourceData, maximumDistance, cellSize, outDistanceGrid, distanceMethod, inBarrierData, outBackDirectionGrid);

    public static Grid EucDistance(this _SpatialAnalyst spatialAnalyst, Grid inSourceData, double? maximumDistance = null, double? cellSize = null, Grid? outDirectionGrid = null, string? distanceMethod = null, Grid? inBarrierData = null, Grid? outBackDirectionGrid = null)
        => spatialAnalyst.EucDistance(inSourceData, maximumDistance, cellSize, outDirectionGrid, distanceMethod, inBarrierData, outBackDirectionGrid);

    #endregion

    #region Extraction

    public static Grid ExtractByAttributes(this _SpatialAnalyst spatialAnalyst, Grid inGrid, string whereClause)
        => spatialAnalyst.ExtractByAttributes(inGrid, whereClause);

    public static Grid ExtractByCircle(this _SpatialAnalyst spatialAnalyst, Grid inGrid, (double x, double y) centerPoint, double radius, ExtractionArea extractionArea = ExtractionArea.Inside)
        => spatialAnalyst.ExtractByCircle(inGrid, centerPoint, radius, extractionArea);

    public static Grid ExtractByPoints(this _SpatialAnalyst spatialAnalyst, Grid inGrid, (double x, double y)[] points, ExtractionArea extractionArea = ExtractionArea.Inside)
        => spatialAnalyst.ExtractByPoints(inGrid, points, extractionArea);

    public static Grid ExtractByPolygon(this _SpatialAnalyst spatialAnalyst, Grid inGrid, (double x, double y)[] points, ExtractionArea extractionArea = ExtractionArea.Inside)
        => spatialAnalyst.ExtractByPolygon(inGrid, points, extractionArea);

    public static Grid ExtractByRectangle(this _SpatialAnalyst spatialAnalyst, Grid inGrid, Extent extent, ExtractionArea extractionArea = ExtractionArea.Inside)
        => spatialAnalyst.ExtractByRectangle(inGrid, extent, extractionArea);

    public static void ExtractMultiValuesToPoints(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, (Grid grid, string outputFieldName)[] inGrids, Interpolation bilinearInterpolateValues = Interpolation.None)
        => spatialAnalyst.ExtractMultiValuesToPoints(inPointFeatures, inGrids, bilinearInterpolateValues);

    public static void ExtractValuesToPoints(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, Grid inGrid, FilePath outPointFeatures, InterpolateValues interpolateValues = InterpolateValues.None, AddAttributes addAttributes = AddAttributes.Value_Only)
        => spatialAnalyst.ExtractValuesToPoints(inPointFeatures, inGrid, outPointFeatures, interpolateValues, addAttributes);

    public static void Sample(this _SpatialAnalyst spatialAnalyst, Grid[] inGrids, FilePath inLocationData, FilePath outTable, Resampling resamplingType = Resampling.Nearest, string? uniqueIdField = null, Slices processAsMultidimensional = Slices.Current_Slice)
        => spatialAnalyst.Sample(inGrids, inLocationData, outTable, resamplingType, uniqueIdField, processAsMultidimensional);

    #endregion

    #region Generalization

    public static Grid Aggregate(this _SpatialAnalyst spatialAnalyst, Grid inGrid, int cellFactor, AggregationType aggregationType = AggregationType.Sum, ExtentHandling extentHandling = ExtentHandling.Expand, MissingValues ignoreNodata = MissingValues.Data)
        => spatialAnalyst.Aggregate(inGrid, cellFactor, aggregationType, extentHandling, ignoreNodata);

    public static Grid BoundaryClean(this _SpatialAnalyst spatialAnalyst, Grid inGrid, string? sortType = null, bool? numberOfRuns = null)
        => spatialAnalyst.BoundaryClean(inGrid, sortType, numberOfRuns);

    public static Grid Expand(this _SpatialAnalyst spatialAnalyst, Grid inGrid, int numberCells, params int[] zoneValues)
        => spatialAnalyst.Expand(inGrid, numberCells, zoneValues);

    public static Grid MajorityFilter(this _SpatialAnalyst spatialAnalyst, Grid inGrid, string? numberNeighbors = null, FilePath? majorityDefinition = null)
        => spatialAnalyst.MajorityFilter(inGrid, numberNeighbors, majorityDefinition);

    public static Grid Nibble(this _SpatialAnalyst spatialAnalyst, Grid inGrid, Grid inMaskGrid, bool? nibbleValues = null, bool? nibbleNodata = null, Grid? inZoneGrid = null)
        => spatialAnalyst.Nibble(inGrid, inMaskGrid, nibbleValues, nibbleNodata, inZoneGrid);

    public static Grid RegionGroup(this _SpatialAnalyst spatialAnalyst, Grid inGrid, NumberNeighbors numberNeighbors = NumberNeighbors.Four, ZoneConnectivity zoneConnectivity = ZoneConnectivity.Within, AddLink addLink = AddLink.Add_Link, int? excludedValue = null)
        => spatialAnalyst.RegionGroup(inGrid, numberNeighbors, zoneConnectivity, addLink, excludedValue);

    public static Grid Shrink(this _SpatialAnalyst spatialAnalyst, Grid inGrid, int numberCells, params int[] zoneValues)
        => spatialAnalyst.Shrink(inGrid, numberCells, zoneValues);

    public static Grid Thin(this _SpatialAnalyst spatialAnalyst, Grid inGrid, string? backgroundValue = null, bool? filter = null, string? corners = null, double? maximumThickness = null)
        => spatialAnalyst.Thin(inGrid, backgroundValue, filter, corners, maximumThickness);

    #endregion

    #region Groundwater

    public static Grid DarcyFlow(this _SpatialAnalyst spatialAnalyst, Grid inHeadGrid, Grid inPorosityGrid, Grid inThicknessGrid, Grid inTransmissivityGrid, Grid? outDirectionGrid = null, Grid? outMagnitudeGrid = null)
        => spatialAnalyst.DarcyFlow(inHeadGrid, inPorosityGrid, inThicknessGrid, inTransmissivityGrid, outDirectionGrid, outMagnitudeGrid);

    public static Grid DarcyVelocity(this _SpatialAnalyst spatialAnalyst, Grid inHeadGrid, Grid inPorosityGrid, Grid inThicknessGrid, Grid inTransmissivityGrid, Grid outMagnitudeGrid)
        => spatialAnalyst.DarcyVelocity(inHeadGrid, inPorosityGrid, inThicknessGrid, inTransmissivityGrid, outMagnitudeGrid);

    public static void ParticleTrack(this _SpatialAnalyst spatialAnalyst, Grid inDirectionGrid, Grid inMagnitudeGrid, (double x, double y) sourcePoint, FilePath outTrackFile, double? stepLength = null, double? trackingTime = null, FilePath? outTrackPolylineFeatures = null)
        => spatialAnalyst.ParticleTrack(inDirectionGrid, inMagnitudeGrid, sourcePoint, outTrackFile, stepLength, trackingTime, outTrackPolylineFeatures);

    public static Grid PorousPuff(this _SpatialAnalyst spatialAnalyst, FilePath inTrackFile, Grid inPorosityGrid, Grid inThicknessGrid, double mass, double? dispersionTime = null, double? longitudinalDispersivity = null, double? dispersivityRatio = null, double? retardationFactor = null, double? decayCoefficient = null)
        => spatialAnalyst.PorousPuff(inTrackFile, inPorosityGrid, inThicknessGrid, mass, dispersionTime, longitudinalDispersivity, dispersivityRatio, retardationFactor, decayCoefficient);

    #endregion

    #region Hydrology

    public static Grid Fill(this _SpatialAnalyst spatialAnalyst, Grid inSurfaceGrid, double? zLimit = null)
        => spatialAnalyst.Fill(inSurfaceGrid, zLimit);

    public static Grid FlowAccumulation(this _SpatialAnalyst spatialAnalyst, Grid inFlowDirectionGrid, Grid? inWeightGrid = null, string? dataType = null, string? flowDirectionType = null)
        => spatialAnalyst.FlowAccumulation(inFlowDirectionGrid, inWeightGrid, dataType, flowDirectionType);

    public static Grid FlowDirection(this _SpatialAnalyst spatialAnalyst, Grid inSurfaceGrid, bool? forceFlow = null, Grid? outDropGrid = null, string? flowDirectionType = null)
        => spatialAnalyst.FlowDirection(inSurfaceGrid, forceFlow, outDropGrid, flowDirectionType);

    public static Grid FlowDistance(this _SpatialAnalyst spatialAnalyst, Grid inStreamGrid, Grid inSurfaceGrid, Grid? inFlowDirectionGrid = null, string? distanceType = null, string? flowDirectionType = null, string? statisticsType = null)
        => spatialAnalyst.FlowDistance(inStreamGrid, inSurfaceGrid, inFlowDirectionGrid, distanceType, flowDirectionType, statisticsType);

    public static Grid FlowLength(this _SpatialAnalyst spatialAnalyst, Grid inFlowDirectionGrid, string? directionMeasurement = null, Grid? inWeightGrid = null)
        => spatialAnalyst.FlowLength(inFlowDirectionGrid, directionMeasurement, inWeightGrid);

    public static Grid Sink(this _SpatialAnalyst spatialAnalyst, Grid inFlowDirectionGrid)
        => spatialAnalyst.Sink(inFlowDirectionGrid);

    public static Grid SnapPourPoint(this _SpatialAnalyst spatialAnalyst, Grid inPourPointData, Grid inAccumulationGrid, double snapDistance, string? pourPointField = null)
        => spatialAnalyst.SnapPourPoint(inPourPointData, inAccumulationGrid, snapDistance, pourPointField);

    public static Grid StreamLink(this _SpatialAnalyst spatialAnalyst, Grid inStreamGrid, Grid inFlowDirectionGrid)
        => spatialAnalyst.StreamLink(inStreamGrid, inFlowDirectionGrid);

    public static Grid StreamOrder(this _SpatialAnalyst spatialAnalyst, Grid inStreamGrid, Grid inFlowDirectionGrid, string? orderMethod = null)
        => spatialAnalyst.StreamOrder(inStreamGrid, inFlowDirectionGrid, orderMethod);

    public static void StreamToFeature(this _SpatialAnalyst spatialAnalyst, Grid inStreamGrid, Grid inFlowDirectionGrid, FilePath outPolylineFeatures, bool? simplify = null)
        => spatialAnalyst.StreamToFeature(inStreamGrid, inFlowDirectionGrid, outPolylineFeatures, simplify);

    public static Grid Watershed(this _SpatialAnalyst spatialAnalyst, Grid inFlowDirectionGrid, Grid inPourPointData)
        => spatialAnalyst.Watershed(inFlowDirectionGrid, inPourPointData);

    public static Grid Watershed(this _SpatialAnalyst spatialAnalyst, Grid inFlowDirectionGrid, FilePath inPourPointData, string pourPointField)
        => spatialAnalyst.Watershed(inFlowDirectionGrid, inPourPointData, pourPointField);

    #endregion

    #region Interpolation

    public static Grid Idw(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, string zField, double? cellSize = null, double power = 2, Radius? searchRadius = null, FilePath? inBarrierPolylineFeatures = null)
        => spatialAnalyst.Idw(inPointFeatures, zField, cellSize, power, searchRadius, inBarrierPolylineFeatures);

    public static Grid Kriging(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, string zField, KrigingModel krigingModel, double? cellSize = null, Radius? searchRadius = null, FilePath? outVariancePredictionGrid = null)
        => spatialAnalyst.Kriging(inPointFeatures, zField, krigingModel, cellSize, searchRadius, outVariancePredictionGrid);

    public static Grid NaturalNeighbor(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, string zField, double? cellSize = null)
        => spatialAnalyst.NaturalNeighbor(inPointFeatures, zField, cellSize);

    public static Grid Spline(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, string zField, double? cellSize = null, SplineType splineType = SplineType.Regularized, double weight = 0.1, int numberPoints = 12)
        => spatialAnalyst.Spline(inPointFeatures, zField, cellSize, splineType, weight, numberPoints);

    public static Grid SplineWithBarriers(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, string zValueField, FilePath? InputBarrierFeatures = null, double? cellSize = null, double? Smoothing_Factor = null)
        => spatialAnalyst.SplineWithBarriers(inPointFeatures, zValueField, InputBarrierFeatures, cellSize, Smoothing_Factor);

    public static Grid TopoToGridByFile(this _SpatialAnalyst spatialAnalyst, FilePath inParameterFile, FilePath? outStreamFeatures = null, FilePath? outSinkFeatures = null, FilePath? outResidualFeature = null, FilePath? outStreamCliffErrorFeature = null, FilePath? outContourErrorFeature = null)
        => spatialAnalyst.TopoToGridByFile(inParameterFile, outStreamFeatures, outSinkFeatures, outResidualFeature, outStreamCliffErrorFeature, outContourErrorFeature);

    public static Grid Trend(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, string zField, double? cellSize = null, int order = 1, RegressionType regressionType = RegressionType.Linear, FilePath? outRmsFile = null)
        => spatialAnalyst.Trend(inPointFeatures, zField, cellSize, order, regressionType, outRmsFile);

    #endregion

    #region Local

    public static Grid CellStatistics(this _SpatialAnalyst spatialAnalyst, Grid[] inGrids, string? statisticsType = null, MissingValues ignoreNodata = MissingValues.Data)
        => spatialAnalyst.CellStatistics(inGrids, statisticsType, ignoreNodata);

    public static Grid Combine(this _SpatialAnalyst spatialAnalyst, params Grid[] inGrids)
        => spatialAnalyst.Combine(inGrids);

    public static Grid EqualToFrequency(this _SpatialAnalyst spatialAnalyst, Grid inValueGrid, params Grid[] inGrids)
        => spatialAnalyst.EqualToFrequency(inValueGrid, inGrids);

    public static Grid GreaterThanFrequency(this _SpatialAnalyst spatialAnalyst, Grid inValueGrid, params Grid[] inGrids)
        => spatialAnalyst.GreaterThanFrequency(inValueGrid, inGrids);

    public static Grid HighestPosition(this _SpatialAnalyst spatialAnalyst, params Grid[] inGrids)
        => spatialAnalyst.HighestPosition(inGrids);

    public static Grid LessThanFrequency(this _SpatialAnalyst spatialAnalyst, Grid inValueGrid, params Grid[] inGrids)
        => spatialAnalyst.LessThanFrequency(inValueGrid, inGrids);

    public static Grid LowestPosition(this _SpatialAnalyst spatialAnalyst, params Grid[] inGrids)
        => spatialAnalyst.LowestPosition(inGrids);

    public static Grid Popularity(this _SpatialAnalyst spatialAnalyst, Grid inPopularityGridOrConstant, params Grid[] inGrids)
        => spatialAnalyst.Popularity(inPopularityGridOrConstant, inGrids);

    public static Grid Rank(this _SpatialAnalyst spatialAnalyst, Grid inRankGridOrConstant, params Grid[] inGrids)
        => spatialAnalyst.Rank(inRankGridOrConstant, inGrids);

    #endregion

    #region Math

    public static Grid Abs(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Abs(grid);

    public static Grid Divide(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.Divide(grid1, grid2);

    public static Grid Divide(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.Divide(grid, n);

    public static Grid Divide(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.Divide(n, grid);

    public static Grid Divide(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.Divide(grid, n);

    public static Grid Divide(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.Divide(n, grid);

    public static Grid Exp(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Exp(grid);

    public static Grid Exp10(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Exp10(grid);

    public static Grid Exp2(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Exp2(grid);

    public static Grid Float(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Float(grid);

    public static Grid Int(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Int(grid);

    public static Grid Ln(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Ln(grid);

    public static Grid Log10(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Log10(grid);

    public static Grid Log2(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Log2(grid);

    public static Grid Minus(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.Minus(grid1, grid2);

    public static Grid Minus(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.Minus(grid, n);

    public static Grid Minus(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.Minus(n, grid);

    public static Grid Minus(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.Minus(grid, n);

    public static Grid Minus(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.Minus(n, grid);

    public static Grid Mod(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.Mod(grid1, grid2);

    public static Grid Mod(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.Mod(grid, n);

    public static Grid Mod(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.Mod(n, grid);

    public static Grid Mod(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.Mod(grid, n);

    public static Grid Mod(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.Mod(n, grid);

    public static Grid Negate(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Negate(grid);

    public static Grid Plus(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.Plus(grid1, grid2);

    public static Grid Plus(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.Plus(grid, n);

    public static Grid Plus(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.Plus(n, grid);

    public static Grid Plus(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.Plus(grid, n);

    public static Grid Plus(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.Plus(n, grid);

    public static Grid Power(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.Power(grid1, grid2);

    public static Grid Power(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.Power(grid, n);

    public static Grid Power(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.Power(n, grid);

    public static Grid Power(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.Power(grid, n);

    public static Grid Power(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.Power(n, grid);

    public static Grid RoundDown(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.RoundDown(grid);

    public static Grid RoundUp(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.RoundUp(grid);

    public static Grid Square(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Square(grid);

    public static Grid SquareRoot(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.SquareRoot(grid);

    public static Grid Times(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.Times(grid1, grid2);

    public static Grid Times(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.Times(grid, n);

    public static Grid Times(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.Times(n, grid);

    public static Grid Times(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.Times(grid, n);

    public static Grid Times(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.Times(n, grid);

    #region Bitwise

    public static Grid BitwiseAnd(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.BitwiseAnd(grid1, grid2);

    public static Grid BitwiseAnd(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.BitwiseAnd(grid, n);

    public static Grid BitwiseAnd(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.BitwiseAnd(n, grid);

    public static Grid BitwiseAnd(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.BitwiseAnd(grid, n);

    public static Grid BitwiseAnd(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.BitwiseAnd(n, grid);

    public static Grid BitwiseLeftShift(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.BitwiseLeftShift(grid1, grid2);

    public static Grid BitwiseLeftShift(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.BitwiseLeftShift(grid, n);

    public static Grid BitwiseLeftShift(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.BitwiseLeftShift(n, grid);

    public static Grid BitwiseLeftShift(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.BitwiseLeftShift(grid, n);

    public static Grid BitwiseLeftShift(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.BitwiseLeftShift(n, grid);

    public static Grid BitwiseNot(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.BitwiseNot(grid);

    public static Grid BitwiseOr(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.BitwiseOr(grid1, grid2);

    public static Grid BitwiseOr(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.BitwiseOr(grid, n);

    public static Grid BitwiseOr(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.BitwiseOr(n, grid);

    public static Grid BitwiseOr(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.BitwiseOr(grid, n);

    public static Grid BitwiseOr(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.BitwiseOr(n, grid);

    public static Grid BitwiseRightShift(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.BitwiseRightShift(grid1, grid2);

    public static Grid BitwiseRightShift(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.BitwiseRightShift(grid, n);

    public static Grid BitwiseRightShift(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.BitwiseRightShift(n, grid);

    public static Grid BitwiseRightShift(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.BitwiseRightShift(grid, n);

    public static Grid BitwiseRightShift(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.BitwiseRightShift(n, grid);

    public static Grid BitwiseXOr(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.BitwiseXOr(grid1, grid2);

    public static Grid BitwiseXOr(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.BitwiseXOr(grid, n);

    public static Grid BitwiseXOr(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.BitwiseXOr(n, grid);

    public static Grid BitwiseXOr(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.BitwiseXOr(grid, n);

    public static Grid BitwiseXOr(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.BitwiseXOr(n, grid);

    #endregion

    #region Logical

    public static Grid BooleanAnd(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.BooleanAnd(grid1, grid2);

    public static Grid BooleanAnd(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.BooleanAnd(grid, n);

    public static Grid BooleanAnd(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.BooleanAnd(n, grid);

    public static Grid BooleanAnd(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.BooleanAnd(grid, n);

    public static Grid BooleanAnd(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.BooleanAnd(n, grid);

    public static Grid BooleanNot(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.BooleanNot(grid);

    public static Grid BooleanOr(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.BooleanOr(grid1, grid2);

    public static Grid BooleanOr(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.BooleanOr(grid, n);

    public static Grid BooleanOr(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.BooleanOr(n, grid);

    public static Grid BooleanOr(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.BooleanOr(grid, n);

    public static Grid BooleanOr(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.BooleanOr(n, grid);

    public static Grid BooleanXOr(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.BooleanXOr(grid1, grid2);

    public static Grid BooleanXOr(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.BooleanXOr(grid, n);

    public static Grid BooleanXOr(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.BooleanXOr(n, grid);

    public static Grid BooleanXOr(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.BooleanXOr(grid, n);

    public static Grid BooleanXOr(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.BooleanXOr(n, grid);

    public static Grid CombinatorialAnd(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.CombinatorialAnd(grid1, grid2);

    public static Grid CombinatorialAnd(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.CombinatorialAnd(grid, n);

    public static Grid CombinatorialAnd(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.CombinatorialAnd(n, grid);

    public static Grid CombinatorialOr(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.CombinatorialOr(grid1, grid2);

    public static Grid CombinatorialOr(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.CombinatorialOr(grid, n);

    public static Grid CombinatorialOr(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.CombinatorialOr(n, grid);

    public static Grid CombinatorialXOr(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.CombinatorialXOr(grid1, grid2);

    public static Grid CombinatorialXOr(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.CombinatorialXOr(grid, n);

    public static Grid CombinatorialXOr(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.CombinatorialXOr(n, grid);

    public static Grid Diff(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.Diff(grid1, grid2);

    public static Grid Diff(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.Diff(grid, n);

    public static Grid Diff(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.Diff(n, grid);

    public static Grid Diff(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.Diff(grid, n);

    public static Grid Diff(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.Diff(n, grid);

    public static Grid EqualTo(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.EqualTo(grid1, grid2);

    public static Grid EqualTo(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.EqualTo(grid, n);

    public static Grid EqualTo(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.EqualTo(n, grid);

    public static Grid EqualTo(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.EqualTo(grid, n);

    public static Grid EqualTo(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.EqualTo(n, grid);

    public static Grid GreaterThan(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.GreaterThan(grid1, grid2);

    public static Grid GreaterThan(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.GreaterThan(grid, n);

    public static Grid GreaterThan(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.GreaterThan(n, grid);

    public static Grid GreaterThan(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.GreaterThan(grid, n);

    public static Grid GreaterThan(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.GreaterThan(n, grid);

    public static Grid GreaterThanEqual(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.GreaterThanEqual(grid1, grid2);

    public static Grid GreaterThanEqual(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.GreaterThanEqual(grid, n);

    public static Grid GreaterThanEqual(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.GreaterThanEqual(n, grid);

    public static Grid GreaterThanEqual(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.GreaterThanEqual(grid, n);

    public static Grid GreaterThanEqual(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.GreaterThanEqual(n, grid);

    public static Grid InList(this _SpatialAnalyst spatialAnalyst, Grid grid, params Grid[] list)
        => spatialAnalyst.InList(grid, list);

    public static Grid InList(this _SpatialAnalyst spatialAnalyst, Grid grid, params int[] list)
        => spatialAnalyst.InList(grid, list);

    public static Grid InList(this _SpatialAnalyst spatialAnalyst, int n, params Grid[] list)
        => spatialAnalyst.InList(n, list);

    public static Grid InList(this _SpatialAnalyst spatialAnalyst, Grid grid, params double[] list)
        => spatialAnalyst.InList(grid, list);

    public static Grid InList(this _SpatialAnalyst spatialAnalyst, double n, params Grid[] list)
        => spatialAnalyst.InList(n, list);

    public static Grid IsNull(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.IsNull(grid);

    public static Grid LessThan(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.LessThan(grid1, grid2);

    public static Grid LessThan(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.LessThan(grid, n);

    public static Grid LessThan(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.LessThan(n, grid);

    public static Grid LessThan(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.LessThan(grid, n);

    public static Grid LessThan(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.LessThan(n, grid);

    public static Grid LessThanEqual(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.LessThanEqual(grid1, grid2);

    public static Grid LessThanEqual(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.LessThanEqual(grid, n);

    public static Grid LessThanEqual(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.LessThanEqual(n, grid);

    public static Grid LessThanEqual(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.LessThanEqual(grid, n);

    public static Grid LessThanEqual(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.LessThanEqual(n, grid);

    public static Grid NotEqual(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.NotEqual(grid1, grid2);

    public static Grid NotEqual(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.NotEqual(grid, n);

    public static Grid NotEqual(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.NotEqual(n, grid);

    public static Grid NotEqual(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.NotEqual(grid, n);

    public static Grid NotEqual(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.NotEqual(n, grid);

    public static Grid Over(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.Over(grid1, grid2);

    public static Grid Over(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.Over(grid, n);

    public static Grid Over(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.Over(n, grid);

    public static Grid Over(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.Over(grid, n);

    public static Grid Over(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.Over(n, grid);

    public static Grid Test(this _SpatialAnalyst spatialAnalyst, Grid grid, string whereClause)
        => spatialAnalyst.Test(grid, whereClause);

    #endregion

    #region Trigonometric

    public static Grid ACos(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.ACos(grid);

    public static Grid ACosH(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.ACosH(grid);

    public static Grid ASin(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.ASin(grid);

    public static Grid ASinH(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.ASinH(grid);

    public static Grid ATan(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.ATan(grid);

    public static Grid ATan2(this _SpatialAnalyst spatialAnalyst, Grid grid1, Grid grid2)
        => spatialAnalyst.ATan2(grid1, grid2);

    public static Grid ATan2(this _SpatialAnalyst spatialAnalyst, Grid grid, int n)
        => spatialAnalyst.ATan2(grid, n);

    public static Grid ATan2(this _SpatialAnalyst spatialAnalyst, Grid grid, double n)
        => spatialAnalyst.ATan2(grid, n);

    public static Grid ATan2(this _SpatialAnalyst spatialAnalyst, int n, Grid grid)
        => spatialAnalyst.ATan2(n, grid);

    public static Grid ATan2(this _SpatialAnalyst spatialAnalyst, double n, Grid grid)
        => spatialAnalyst.ATan2(n, grid);

    public static Grid ATanH(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.ATanH(grid);

    public static Grid Cos(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Cos(grid);

    public static Grid CosH(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.CosH(grid);

    public static Grid Sin(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Sin(grid);

    public static Grid SinH(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.SinH(grid);

    public static Grid Tan(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.Tan(grid);

    public static Grid TanH(this _SpatialAnalyst spatialAnalyst, Grid grid)
        => spatialAnalyst.TanH(grid);

    #endregion

    #endregion

    #region Multivariate

    public static void BandCollectionStats(this _SpatialAnalyst spatialAnalyst, Grid[] inGridBands, FilePath outStatFile, bool? computeMatrices = null)
        => spatialAnalyst.BandCollectionStats(inGridBands, outStatFile, computeMatrices);

    public static Grid ClassProbability(this _SpatialAnalyst spatialAnalyst, Grid[] inGridBands, FilePath inSignatureFile, int? maximumOutputValue = null, APriori aPrioriProbabilities = APriori.Equal, FilePath? inAPrioriFile = null)
        => spatialAnalyst.ClassProbability(inGridBands, inSignatureFile, maximumOutputValue, aPrioriProbabilities, inAPrioriFile);

    public static void CreateSignatures(this _SpatialAnalyst spatialAnalyst, Grid[] inGridBands, Grid inSampleData, FilePath outSignatureFile, ComputeCovariance computeCovariance = ComputeCovariance.Covariance, string? sampleField = null)
        => spatialAnalyst.CreateSignatures(inGridBands, inSampleData, outSignatureFile, computeCovariance, sampleField);

    public static void Dendrogram(this _SpatialAnalyst spatialAnalyst, FilePath inSignatureFile, FilePath outDendrogramFile, DistanceCalculation distanceCalculation = DistanceCalculation.Variance, int lineWidth = 78)
        => spatialAnalyst.Dendrogram(inSignatureFile, outDendrogramFile, distanceCalculation, lineWidth);

    public static void EditSignatures(this _SpatialAnalyst spatialAnalyst, Grid[] inGridBands, FilePath inSignatureFile, FilePath inSignatureRemapFile, FilePath outSignatureFile, int sampleInterval = 10)
        => spatialAnalyst.EditSignatures(inGridBands, inSignatureFile, inSignatureRemapFile, outSignatureFile, sampleInterval);

    public static void IsoCluster(this _SpatialAnalyst spatialAnalyst, Grid[] inGridBands, FilePath outSignatureFile, int numberClasses, int numberIterations = 20, int minClassSize = 20, int sampleInterval = 10)
        => spatialAnalyst.IsoCluster(inGridBands, outSignatureFile, numberClasses, numberIterations, minClassSize, sampleInterval);

    public static Grid IsoClusterUnsupervisedClassification(this _SpatialAnalyst spatialAnalyst, Grid[] inGridBands, int numberOfClasses, int minimumClassSize = 20, int sampleInterval = 10, FilePath? outSignatureFile = null)
        => spatialAnalyst.IsoClusterUnsupervisedClassification(inGridBands, numberOfClasses, minimumClassSize, sampleInterval, outSignatureFile);

    public static Grid MLClassify(this _SpatialAnalyst spatialAnalyst, Grid[] inGridBands, FilePath inSignatureFile, string? rejectFraction = null, string? aPrioriProbabilities = null, FilePath? inAPrioriFile = null, Grid? outConfidenceGrid = null)
        => spatialAnalyst.MLClassify(inGridBands, inSignatureFile, rejectFraction, aPrioriProbabilities, inAPrioriFile, outConfidenceGrid);

    public static Grid PrincipalComponents(this _SpatialAnalyst spatialAnalyst, Grid[] inGridBands, int? numberComponents = null, FilePath? outDataFile = null)
        => spatialAnalyst.PrincipalComponents(inGridBands, numberComponents, outDataFile);

    #endregion

    #region Neighborhood

    public static Grid BlockStatistics(this _SpatialAnalyst spatialAnalyst, Grid inGrid, Nbr? neighborhood = null, StatisticsType statisticsType = StatisticsType.Mean, MissingValues ignoreNodata = MissingValues.Data)
        => spatialAnalyst.BlockStatistics(inGrid, neighborhood ?? Nbr.Rectangle(3, 3, NeighborhoodUnit.Cell), statisticsType, ignoreNodata);

    public static Grid Filter(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilterType filterType = FilterType.Low, MissingValues ignoreNodata = MissingValues.Data)
        => spatialAnalyst.Filter(inGrid, filterType, ignoreNodata);

    public static Grid FocalFlow(this _SpatialAnalyst spatialAnalyst, Grid inSurfaceGrid, double? thresholdValue = null)
        => spatialAnalyst.FocalFlow(inSurfaceGrid, thresholdValue);

    public static Grid FocalStatistics(this _SpatialAnalyst spatialAnalyst, Grid inGrid, Nbr? neighborhood = null, StatisticsType statisticsType = StatisticsType.Mean, MissingValues ignoreNodata = MissingValues.Data)
        => spatialAnalyst.FocalStatistics(inGrid, neighborhood ?? Nbr.Rectangle(3, 3, NeighborhoodUnit.Cell), statisticsType, ignoreNodata);

    public static Grid LineStatistics(this _SpatialAnalyst spatialAnalyst, FilePath inPolylineFeatures, string field, double? cellSize = null, double? searchRadius = null, StatisticsType statisticsType = StatisticsType.Mean)
        => spatialAnalyst.LineStatistics(inPolylineFeatures, field, cellSize, searchRadius, statisticsType);

    public static Grid PointStatistics(this _SpatialAnalyst spatialAnalyst, FilePath inPointFeatures, string field, double? cellSize = null, Nbr? neighborhood = null, StatisticsType statisticsType = StatisticsType.Mean)
        => spatialAnalyst.PointStatistics(inPointFeatures, field, cellSize, neighborhood ?? Nbr.Rectangle(3, 3, NeighborhoodUnit.Cell), statisticsType);

    #endregion

    #region Overlay

    public static Grid FuzzyMembership(this _SpatialAnalyst spatialAnalyst, Grid inGrid, Fuzzy? fuzzyFunction = null, string? hedge = null)
        => spatialAnalyst.FuzzyMembership(inGrid, fuzzyFunction, hedge);

    public static Grid FuzzyOverlay(this _SpatialAnalyst spatialAnalyst, Grid[] inGrids, string? overlayType = null, double? gamma = null)
        => spatialAnalyst.FuzzyOverlay(inGrids, overlayType, gamma);

    public static Grid WeightedOverlay(this _SpatialAnalyst spatialAnalyst, FilePath inWeightedOverlayTable)
        => spatialAnalyst.WeightedOverlay(inWeightedOverlayTable);

    #endregion

    #region Creation

    public static Grid CreateConstantGrid(this _SpatialAnalyst spatialAnalyst, int constantValue, double? cellSize = null, Extent? extent = null)
        => spatialAnalyst.CreateConstantGrid(constantValue, cellSize, extent);

    public static Grid CreateConstantGrid(this _SpatialAnalyst spatialAnalyst, double constantValue, double? cellSize = null, Extent? extent = null)
        => spatialAnalyst.CreateConstantGrid(constantValue, cellSize, extent);

    public static Grid CreateNormalGrid(this _SpatialAnalyst spatialAnalyst, double? cellSize = null, Extent? extent = null)
        => spatialAnalyst.CreateNormalGrid(cellSize, extent);

    public static Grid CreateRandomGrid(this _SpatialAnalyst spatialAnalyst, double? seedValue = null, double? cellSize = null, Extent? extent = null)
        => CreateRandomGrid(spatialAnalyst, seedValue, cellSize, extent);

    #endregion

    #region Reclass

    public static Grid Lookup(this _SpatialAnalyst spatialAnalyst, Grid inGrid, string lookupField)
        => spatialAnalyst.Lookup(inGrid, lookupField);

    public static Grid ReclassByASCIIFile(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inRemapFile, MissingValues missingValues = MissingValues.Data)
        => spatialAnalyst.ReclassByASCIIFile(inGrid, inRemapFile, missingValues);

    public static Grid ReclassByTable(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inRemapTable, string fromValueField, string toValueField, string outputValueField, MissingValues missingValues = MissingValues.Data)
        => spatialAnalyst.ReclassByTable(inGrid, inRemapTable, fromValueField, toValueField, outputValueField, missingValues);

    public static Grid Reclassify(this _SpatialAnalyst spatialAnalyst, Grid inGrid, string reclassField, Remap remap, MissingValues missingValues = MissingValues.Data)
        => spatialAnalyst.Reclassify(inGrid, reclassField, remap, missingValues);

    public static Grid RescaleByFunction(this _SpatialAnalyst spatialAnalyst, Grid inGrid, Tf? transformationFunction = null, double fromScale = 1, double toScale = 10)
        => spatialAnalyst.RescaleByFunction(inGrid, transformationFunction, fromScale, toScale);

    public static Grid Slice(this _SpatialAnalyst spatialAnalyst, Grid inGrid, int numberZones, SliceType sliceType = SliceType.Equal_Interval, int baseOutputZone = 1)
        => spatialAnalyst.Slice(inGrid, numberZones, sliceType, baseOutputZone);

    #endregion

    #region Segmentation and Classification

    public static Grid ClassifyGrid(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inClassifierDefinition, Grid? inAdditionalGrid = null)
        => spatialAnalyst.ClassifyGrid(inGrid, inClassifierDefinition, inAdditionalGrid);

    public static void ComputeConfusionMatrix(this _SpatialAnalyst spatialAnalyst, FilePath inAccuracyAssessmentPoints, FilePath outConfusionMatrix)
        => spatialAnalyst.ComputeConfusionMatrix(inAccuracyAssessmentPoints, outConfusionMatrix);

    public static Grid ComputeSegmentAttributes(this _SpatialAnalyst spatialAnalyst, Grid inSegmentedGrid, Grid? inAdditionalGrid = null, string? usedAttributes = null)
        => spatialAnalyst.ComputeSegmentAttributes(inSegmentedGrid, inAdditionalGrid, usedAttributes);

    public static void CreateAccuracyAssessmentPoints(this _SpatialAnalyst spatialAnalyst, Grid inClassData, FilePath outPoints, string? targetField = null, int numRandomPoints = 500, string? sampling = null)
        => spatialAnalyst.CreateAccuracyAssessmentPoints(inClassData, outPoints, targetField, numRandomPoints, sampling);

    public static void GenerateTrainingSamplesFromSeedPoints(this _SpatialAnalyst spatialAnalyst, Grid inClassData, FilePath inSeedPoints, FilePath outTrainingFeatureClass, double? minSampleArea = null, double? maxSampleRadius = null)
        => spatialAnalyst.GenerateTrainingSamplesFromSeedPoints(inClassData, inSeedPoints, outTrainingFeatureClass, minSampleArea, maxSampleRadius);

    public static Grid InspectTrainingSamples(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inTrainingFeatures, FilePath inClassifierDefinition, FilePath outTrainingFeatureClass, Grid? inAdditionalGrid = null)
        => spatialAnalyst.InspectTrainingSamples(inGrid, inTrainingFeatures, inClassifierDefinition, outTrainingFeatureClass, inAdditionalGrid);

    public static Grid RemoveGridSegmentTilingArtifacts(this _SpatialAnalyst spatialAnalyst, Grid inSegmentedGrid, int tileSizeX = 512, int tileSizeY = 512)
        => spatialAnalyst.RemoveGridSegmentTilingArtifacts(inSegmentedGrid, tileSizeX, tileSizeY);

    public static Grid SegmentMeanShift(this _SpatialAnalyst spatialAnalyst, Grid inGrid, double? spectralDetail = null, double? spatialDetail = null, int? minSegmentSize = null, string? bandIndexes = null)
        => spatialAnalyst.SegmentMeanShift(inGrid, spectralDetail, spatialDetail, minSegmentSize, bandIndexes);

    public static void TrainIsoClusterClassifier(this _SpatialAnalyst spatialAnalyst, Grid inGrid, int maxClasses, FilePath outClassifierDefinition, Grid? inAdditionalGrid = null, int? maxIterations = null, int? minSamplesPerCluster = null, int? skipFactor = null, string? usedAttributes = null, int? maxMergePerIter = null, double? maxMergeDistance = null)
        => spatialAnalyst.TrainIsoClusterClassifier(inGrid, maxClasses, outClassifierDefinition, inAdditionalGrid, maxIterations, minSamplesPerCluster, skipFactor, usedAttributes, maxMergePerIter, maxMergeDistance);

    public static void TrainMaximumLikelihoodClassifier(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inTrainingFeatures, FilePath outClassifierDefinition, Grid? inAdditionalGrid = null, string[]? usedAttributes = null)
        => spatialAnalyst.TrainMaximumLikelihoodClassifier(inGrid, inTrainingFeatures, outClassifierDefinition, inAdditionalGrid, usedAttributes);

    public static void TrainRandomTreesClassifier(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inTrainingFeatures, FilePath outClassifierDefinition, Grid? inAdditionalGrid = null, int? maxNumTrees = null, int? maxTreeDepth = null, int? maxSamplesPerClass = null, string? usedAttributes = null)
        => spatialAnalyst.TrainRandomTreesClassifier(inGrid, inTrainingFeatures, outClassifierDefinition, inAdditionalGrid, maxNumTrees, maxTreeDepth, maxSamplesPerClass, usedAttributes);

    public static void TrainSupportVectorMachineClassifier(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inTrainingFeatures, FilePath outClassifierDefinition, Grid? inAdditionalGrid = null, int? maxSamplesPerClass = null, string? usedAttributes = null)
        => spatialAnalyst.TrainSupportVectorMachineClassifier(inGrid, inTrainingFeatures, outClassifierDefinition, inAdditionalGrid, maxSamplesPerClass, usedAttributes);

    public static void UpdateAccuracyAssessmentPoints(this _SpatialAnalyst spatialAnalyst, Grid inClassData, FilePath inPoints, FilePath outPoints, string? targetField = null)
        => spatialAnalyst.UpdateAccuracyAssessmentPoints(inClassData, inPoints, outPoints, targetField);

    #endregion

    #region Solar Radiation

    #endregion

    #region Surface

    public static Grid Aspect(this _SpatialAnalyst spatialAnalyst, Grid inGrid, bool geodesic = false, ZUnit zUnit = ZUnit.Meter)
        => spatialAnalyst.Aspect(inGrid, geodesic, zUnit);

    public static void Contour(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath outPolylineFeatures, double contourInterval, double baseContour = 0, double zFactor = 1)
        => spatialAnalyst.Contour(inGrid, outPolylineFeatures, contourInterval, baseContour, zFactor);

    public static void ContourList(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath outPolylineFeatures, params double[] contourValue)
        => spatialAnalyst.ContourList(inGrid, outPolylineFeatures, contourValue);

    public static void ContourWithBarriers(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath outContourFeatureClass, FilePath? inBarrierFeatures = null, ContourType inContourType = ContourType.Contour, FilePath? inContourValuesFile = null, bool explicitOnly = false, double inBaseContour = 0, double? inContourInterval = null, double? inIndexedContourInterval = null, double[]? inExplicitContour = null, double inZFactor = 1)
        => spatialAnalyst.ContourWithBarriers(inGrid, outContourFeatureClass, inBarrierFeatures, inContourType, inContourValuesFile, explicitOnly, inBaseContour, inContourInterval, inIndexedContourInterval, inExplicitContour, inZFactor);

    public static Grid Curvature(this _SpatialAnalyst spatialAnalyst, Grid inGrid, double zFactor = 1, Grid? outProfileCurveGrid = null, FilePath? outPlanCurveGrid = null)
        => spatialAnalyst.Curvature(inGrid, zFactor, outProfileCurveGrid, outPlanCurveGrid);

    public static Grid CutFill(this _SpatialAnalyst spatialAnalyst, Grid inBeforeSurface, Grid inAfterSurface, double zFactor = 1)
        => spatialAnalyst.CutFill(inBeforeSurface, inAfterSurface, zFactor);

    public static Grid Hillshade(this _SpatialAnalyst spatialAnalyst, Grid inGrid, double azimuth = 315, double altitude = 45, bool modelShadows = false, double zFactor = 1)
        => spatialAnalyst.Hillshade(inGrid, azimuth, altitude, modelShadows, zFactor);

    public static Grid ObserverPoints(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inObserverPointFeatures, double zFactor = 1, bool curvatureCorrection = false, double refractivityCoefficient = 0.13, FilePath? outAglGrid = null)
        => spatialAnalyst.ObserverPoints(inGrid, inObserverPointFeatures, zFactor, curvatureCorrection, refractivityCoefficient, outAglGrid);

    public static Grid Slope(this _SpatialAnalyst spatialAnalyst, Grid inGrid, SlopeMeasurement outputMeasurement = SlopeMeasurement.Degree, double zFactor = 1, bool geodesic = false, ZUnit zUnit = ZUnit.Meter)
        => spatialAnalyst.Slope(inGrid, outputMeasurement, zFactor, geodesic, zUnit);

    public static Grid Viewshed(this _SpatialAnalyst spatialAnalyst, Grid inGrid, FilePath inObserverFeatures, double zFactor = 1, bool? curvatureCorrection = null, double? refractivityCoefficient = null, FilePath? outAglGrid = null)
        => spatialAnalyst.Viewshed(inGrid, inObserverFeatures, zFactor, curvatureCorrection, refractivityCoefficient, outAglGrid);

    #endregion

    #region Zonal

    public static void TabulateArea(this _SpatialAnalyst spatialAnalyst, Grid inZoneData, string zoneField, Grid inClassData, string classField, FilePath outTable, double? processingCellSize = null)
        => spatialAnalyst.TabulateArea(inZoneData, zoneField, inClassData, classField, outTable, processingCellSize);

    public static Grid ZonalFill(this _SpatialAnalyst spatialAnalyst, Grid inZoneGrid, Grid inWeightGrid)
        => spatialAnalyst.ZonalFill(inZoneGrid, inWeightGrid);

    public static Grid ZonalGeometry(this _SpatialAnalyst spatialAnalyst, Grid inZoneData, string zoneField, string? geometryType = null, double? cellSize = null)
        => spatialAnalyst.ZonalGeometry(inZoneData, zoneField, geometryType, cellSize);

    public static void ZonalGeometryAsTable(this _SpatialAnalyst spatialAnalyst, Grid inZoneData, string zoneField, FilePath outTable, double? processingCellSize = null)
        => spatialAnalyst.ZonalGeometryAsTable(inZoneData, zoneField, outTable, processingCellSize);

    public static void ZonalHistogram(this _SpatialAnalyst spatialAnalyst, Grid inZoneData, string zoneField, Grid inValueGrid, FilePath outTable, string? outGraph = null)
        => spatialAnalyst.ZonalHistogram(inZoneData, zoneField, inValueGrid, outTable, outGraph);

    public static Grid ZonalStatistics(this _SpatialAnalyst spatialAnalyst, Grid inZoneData, string zoneField, Grid inValueGrid, string? statisticsType = null, MissingValues ignoreNodata = MissingValues.Data)
        => spatialAnalyst.ZonalStatistics(inZoneData, zoneField, inValueGrid, statisticsType, ignoreNodata);

    public static void ZonalStatisticsAsTable(this _SpatialAnalyst spatialAnalyst, Grid inZoneData, string zoneField, Grid inValueGrid, FilePath outTable, MissingValues ignoreNodata = MissingValues.Data, string? statisticsType = null)
        => spatialAnalyst.ZonalStatisticsAsTable(inZoneData, zoneField, inValueGrid, outTable, ignoreNodata, statisticsType);

    #endregion
}
