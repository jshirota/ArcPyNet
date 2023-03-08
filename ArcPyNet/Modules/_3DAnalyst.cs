﻿using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _3DAnalyst
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.ddd.{method}", args);
    }

    public Variable ASCII3DToFeatureClass(params object?[] args) => Run(args);
    public Variable AddFeatureClassToTerrain(params object?[] args) => Run(args);
    public Variable AddSurfaceInformation(params object?[] args) => Run(args);
    public Variable AddTerrainPoints(params object?[] args) => Run(args);
    public Variable AddTerrainPyramidLevel(params object?[] args) => Run(args);
    public Variable AddZInformation(params object?[] args) => Run(args);
    public Variable AppendTerrainPoints(params object?[] args) => Run(args);
    public Variable Aspect(params object?[] args) => Run(args);
    public Variable Buffer3D(params object?[] args) => Run(args);
    public Variable BuildTerrain(params object?[] args) => Run(args);
    public Variable ChangeLasClassCodes(params object?[] args) => Run(args);
    public Variable ChangeTerrainReferenceScale(params object?[] args) => Run(args);
    public Variable ChangeTerrainResolutionBounds(params object?[] args) => Run(args);
    public Variable ClassifyLasBuilding(params object?[] args) => Run(args);
    public Variable ClassifyLasByHeight(params object?[] args) => Run(args);
    public Variable ClassifyLasGround(params object?[] args) => Run(args);
    public Variable ClassifyLasNoise(params object?[] args) => Run(args);
    public Variable ClassifyLasOverlap(params object?[] args) => Run(args);
    public Variable ClassifyPointCloudUsingTrainedModel(params object?[] args) => Run(args);
    public Variable ColorizeLas(params object?[] args) => Run(args);
    public Variable ConstructSightLines(params object?[] args) => Run(args);
    public Variable Contour(params object?[] args) => Run(args);
    public Variable ContourList(params object?[] args) => Run(args);
    public Variable ContourWithBarriers(params object?[] args) => Run(args);
    public Variable CopyTin(params object?[] args) => Run(args);
    public Variable CreateTerrain(params object?[] args) => Run(args);
    public Variable CreateTin(params object?[] args) => Run(args);
    public Variable Curvature(params object?[] args) => Run(args);
    public Variable CutFill(params object?[] args) => Run(args);
    public Variable DecimateTinNodes(params object?[] args) => Run(args);
    public Variable DeleteTerrainPoints(params object?[] args) => Run(args);
    public Variable DelineateTinDataArea(params object?[] args) => Run(args);
    public Variable Difference3D(params object?[] args) => Run(args);
    public Variable Divide(params object?[] args) => Run(args);
    public Variable EditTin(params object?[] args) => Run(args);
    public Variable EncloseMultiPatch(params object?[] args) => Run(args);
    public Variable EnforceRiverMonotonicity(params object?[] args) => Run(args);
    public Variable EvaluatePointCloudClassificationModel(params object?[] args) => Run(args);
    public Variable ExtractLas(params object?[] args) => Run(args);
    public Variable ExtractMultipatchFromMesh(params object?[] args) => Run(args);
    public Variable ExtractPowerLinesFromPointCloud(params object?[] args) => Run(args);
    public Variable ExtrudeBetween(params object?[] args) => Run(args);
    public Variable FeatureClassZToASCII(params object?[] args) => Run(args);
    public Variable FeatureTo3DByAttribute(params object?[] args) => Run(args);
    public Variable FeaturesFromCityEngineRules(params object?[] args) => Run(args);
    public Variable FenceDiagram(params object?[] args) => Run(args);
    public Variable Float(params object?[] args) => Run(args);
    public Variable GenerateClearanceSurface(params object?[] args) => Run(args);
    public Variable HillShade(params object?[] args) => Run(args);
    public Variable Idw(params object?[] args) => Run(args);
    public Variable Import3DFiles(params object?[] args) => Run(args);
    public Variable Inside3D(params object?[] args) => Run(args);
    public Variable Int(params object?[] args) => Run(args);
    public Variable InterpolatePolyToPatch(params object?[] args) => Run(args);
    public Variable InterpolateShape(params object?[] args) => Run(args);
    public Variable Intersect3D(params object?[] args) => Run(args);
    public Variable Intersect3DLineWithMultiPatch(params object?[] args) => Run(args);
    public Variable Intersect3DLineWithSurface(params object?[] args) => Run(args);
    public Variable Intersect3DLines(params object?[] args) => Run(args);
    public Variable Intervisibility(params object?[] args) => Run(args);
    public Variable IsClosed3D(params object?[] args) => Run(args);
    public Variable Kriging(params object?[] args) => Run(args);
    public Variable LASToMultipoint(params object?[] args) => Run(args);
    public Variable LandXMLToTin(params object?[] args) => Run(args);
    public Variable LasBuildingMultipatch(params object?[] args) => Run(args);
    public Variable LasDatasetToTin(params object?[] args) => Run(args);
    public Variable LasHeightMetrics(params object?[] args) => Run(args);
    public Variable LasPointStatsByArea(params object?[] args) => Run(args);
    public Variable Layer3DToFeatureClass(params object?[] args) => Run(args);
    public Variable LayerToKML(params object?[] args) => Run(args);
    public Variable LineOfSight(params object?[] args) => Run(args);
    public Variable LocateLasPointsByProximity(params object?[] args) => Run(args);
    public Variable LocateOutliers(params object?[] args) => Run(args);
    public Variable Lookup(params object?[] args) => Run(args);
    public Variable MapToKML(params object?[] args) => Run(args);
    public Variable MinimumBoundingVolume(params object?[] args) => Run(args);
    public Variable Minus(params object?[] args) => Run(args);
    public Variable MultiPatchFootprint(params object?[] args) => Run(args);
    public Variable NaturalNeighbor(params object?[] args) => Run(args);
    public Variable Near3D(params object?[] args) => Run(args);
    public Variable ObserverPoints(params object?[] args) => Run(args);
    public Variable Plus(params object?[] args) => Run(args);
    public Variable PointFileInformation(params object?[] args) => Run(args);
    public Variable PolygonVolume(params object?[] args) => Run(args);
    public Variable PreparePointCloudTrainingData(params object?[] args) => Run(args);
    public Variable RasterDomain(params object?[] args) => Run(args);
    public Variable RasterTin(params object?[] args) => Run(args);
    public Variable RasterToMultipoint(params object?[] args) => Run(args);
    public Variable ReclassByASCIIFile(params object?[] args) => Run(args);
    public Variable ReclassByTable(params object?[] args) => Run(args);
    public Variable Reclassify(params object?[] args) => Run(args);
    public Variable RegularizeAdjacentBuildingFootprint(params object?[] args) => Run(args);
    public Variable RegularizeBuildingFootprint(params object?[] args) => Run(args);
    public Variable RemoveFeatureClassFromTerrain(params object?[] args) => Run(args);
    public Variable RemoveTerrainPoints(params object?[] args) => Run(args);
    public Variable RemoveTerrainPyramidLevel(params object?[] args) => Run(args);
    public Variable ReplaceTerrainPoints(params object?[] args) => Run(args);
    public Variable SetLasClassCodesUsingFeatures(params object?[] args) => Run(args);
    public Variable SetLasClassCodesUsingRaster(params object?[] args) => Run(args);
    public Variable Simplify3DLine(params object?[] args) => Run(args);
    public Variable Skyline(params object?[] args) => Run(args);
    public Variable SkylineBarrier(params object?[] args) => Run(args);
    public Variable SkylineGraph(params object?[] args) => Run(args);
    public Variable Slice(params object?[] args) => Run(args);
    public Variable Slope(params object?[] args) => Run(args);
    public Variable Spline(params object?[] args) => Run(args);
    public Variable SplineWithBarriers(params object?[] args) => Run(args);
    public Variable StackProfile(params object?[] args) => Run(args);
    public Variable SunShadowFrequency(params object?[] args) => Run(args);
    public Variable SunShadowVolume(params object?[] args) => Run(args);
    public Variable SurfaceAspect(params object?[] args) => Run(args);
    public Variable SurfaceContour(params object?[] args) => Run(args);
    public Variable SurfaceDifference(params object?[] args) => Run(args);
    public Variable SurfaceLength(params object?[] args) => Run(args);
    public Variable SurfaceParameters(params object?[] args) => Run(args);
    public Variable SurfaceSlope(params object?[] args) => Run(args);
    public Variable SurfaceSpot(params object?[] args) => Run(args);
    public Variable SurfaceVolume(params object?[] args) => Run(args);
    public Variable TerrainToPoints(params object?[] args) => Run(args);
    public Variable TerrainToRaster(params object?[] args) => Run(args);
    public Variable TerrainToTin(params object?[] args) => Run(args);
    public Variable ThinLas(params object?[] args) => Run(args);
    public Variable TileLas(params object?[] args) => Run(args);
    public Variable Times(params object?[] args) => Run(args);
    public Variable TinAspect(params object?[] args) => Run(args);
    public Variable TinContour(params object?[] args) => Run(args);
    public Variable TinDifference(params object?[] args) => Run(args);
    public Variable TinDomain(params object?[] args) => Run(args);
    public Variable TinEdge(params object?[] args) => Run(args);
    public Variable TinLine(params object?[] args) => Run(args);
    public Variable TinNode(params object?[] args) => Run(args);
    public Variable TinPolygonTag(params object?[] args) => Run(args);
    public Variable TinPolygonVolume(params object?[] args) => Run(args);
    public Variable TinRaster(params object?[] args) => Run(args);
    public Variable TinSlope(params object?[] args) => Run(args);
    public Variable TinTriangle(params object?[] args) => Run(args);
    public Variable TopoToRaster(params object?[] args) => Run(args);
    public Variable TopoToRasterByFile(params object?[] args) => Run(args);
    public Variable TrainPointCloudClassificationModel(params object?[] args) => Run(args);
    public Variable Trend(params object?[] args) => Run(args);
    public Variable Union3D(params object?[] args) => Run(args);
    public Variable UpdateFeatureZ(params object?[] args) => Run(args);
    public Variable Viewshed(params object?[] args) => Run(args);
    public Variable Viewshed2(params object?[] args) => Run(args);
    public Variable Visibility(params object?[] args) => Run(args);
}