﻿using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _DataManagement
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.management.{method}", args);
    }

    public Code Add3DFormats(params object?[] args) => Run(args);
    public Code AddAttachments(params object?[] args) => Run(args);
    public Code AddAttributeRule(params object?[] args) => Run(args);
    public Code AddCodedValueToDomain(params object?[] args) => Run(args);
    public Code AddColormap(params object?[] args) => Run(args);
    public Code AddContingentValue(params object?[] args) => Run(args);
    public Code AddDataToTrajectoryDataset(params object?[] args) => Run(args);
    public Code AddFeatureClassToTopology(params object?[] args) => Run(args);
    public Code AddField(params object?[] args) => Run(args);
    public Code AddFieldConflictFilter(params object?[] args) => Run(args);
    public Code AddFields(params object?[] args) => Run(args);
    public Code AddFilesToLasDataset(params object?[] args) => Run(args);
    public Code AddGPSMetadataFields(params object?[] args) => Run(args);
    public Code AddGeometryAttributes(params object?[] args) => Run(args);
    public Code AddGlobalIDs(params object?[] args) => Run(args);
    public Code AddIncrementingIDField(params object?[] args) => Run(args);
    public Code AddIndex(params object?[] args) => Run(args);
    public Code AddItemsToCatalogDataset(params object?[] args) => Run(args);
    public Code AddJoin(params object?[] args) => Run(args);
    public Code AddPortalItemsToCatalogDataset(params object?[] args) => Run(args);
    public Code AddRastersToMosaicDataset(params object?[] args) => Run(args);
    public Code AddRelate(params object?[] args) => Run(args);
    public Code AddRuleToRelationshipClass(params object?[] args) => Run(args);
    public Code AddRuleToTopology(params object?[] args) => Run(args);
    public Code AddSpatialIndex(params object?[] args) => Run(args);
    public Code AddSpatialJoin(params object?[] args) => Run(args);
    public Code AddSubtype(params object?[] args) => Run(args);
    public Code AddXY(params object?[] args) => Run(args);
    public Code Adjust3DZ(params object?[] args) => Run(args);
    public Code AlterAttributeRule(params object?[] args) => Run(args);
    public Code AlterDomain(params object?[] args) => Run(args);
    public Code AlterField(params object?[] args) => Run(args);
    public Code AlterFieldGroup(params object?[] args) => Run(args);
    public Code AlterMosaicDatasetSchema(params object?[] args) => Run(args);
    public Code AlterVersion(params object?[] args) => Run(args);
    public Code Analyze(params object?[] args) => Run(args);
    public Code AnalyzeControlPoints(params object?[] args) => Run(args);
    public Code AnalyzeDatasets(params object?[] args) => Run(args);
    public Code AnalyzeMosaicDataset(params object?[] args) => Run(args);
    public Code AnalyzeToolboxForVersion(params object?[] args) => Run(args);
    public Code AnalyzeToolsForPro(params object?[] args) => Run(args);
    public Code Append(params object?[] args) => Run(args);
    public Code AppendAnnotation(params object?[] args) => Run(args);
    public Code AppendControlPoints(params object?[] args) => Run(args);
    public Code ApplyBlockAdjustment(params object?[] args) => Run(args);
    public Code ApplySymbologyFromLayer(params object?[] args) => Run(args);
    public Code AssignDefaultToField(params object?[] args) => Run(args);
    public Code AssignDomainToField(params object?[] args) => Run(args);
    public Code BatchBuildPyramids(params object?[] args) => Run(args);
    public Code BatchCalculateStatistics(params object?[] args) => Run(args);
    public Code BatchProject(params object?[] args) => Run(args);
    public Code BatchUpdateFields(params object?[] args) => Run(args);
    public Code BearingDistanceToLine(params object?[] args) => Run(args);
    public Code BuildBoundary(params object?[] args) => Run(args);
    public Code BuildFootprints(params object?[] args) => Run(args);
    public Code BuildLasDatasetPyramid(params object?[] args) => Run(args);
    public Code BuildMosaicDatasetItemCache(params object?[] args) => Run(args);
    public Code BuildMultidimensionalInfo(params object?[] args) => Run(args);
    public Code BuildMultidimensionalTranspose(params object?[] args) => Run(args);
    public Code BuildOverviews(params object?[] args) => Run(args);
    public Code BuildPyramids(params object?[] args) => Run(args);
    public Code BuildPyramidsandStatistics(params object?[] args) => Run(args);
    public Code BuildRasterAttributeTable(params object?[] args) => Run(args);
    public Code BuildSeamlines(params object?[] args) => Run(args);
    public Code BuildStereoModel(params object?[] args) => Run(args);
    public Code CalculateCellSizeRanges(params object?[] args) => Run(args);
    public Code CalculateDefaultClusterTolerance(params object?[] args) => Run(args);
    public Code CalculateDefaultGridIndex(params object?[] args) => Run(args);
    public Code CalculateEndTime(params object?[] args) => Run(args);
    public Code CalculateField(params object?[] args) => Run(args);
    public Code CalculateFields(params object?[] args) => Run(args);
    public Code CalculateGeometryAttributes(params object?[] args) => Run(args);
    public Code CalculateStatistics(params object?[] args) => Run(args);
    public Code CalculateValue(params object?[] args) => Run(args);
    public Code ChangePrivileges(params object?[] args) => Run(args);
    public Code ChangeVersion(params object?[] args) => Run(args);
    public Code CheckGeometry(params object?[] args) => Run(args);
    public Code ClearPixelCache(params object?[] args) => Run(args);
    public Code ClearWorkspaceCache(params object?[] args) => Run(args);
    public Code Clip(params object?[] args) => Run(args);
    public Code ColorBalanceMosaicDataset(params object?[] args) => Run(args);
    public Code Compact(params object?[] args) => Run(args);
    public Code CompareReplicaSchema(params object?[] args) => Run(args);
    public Code CompositeBands(params object?[] args) => Run(args);
    public Code Compress(params object?[] args) => Run(args);
    public Code CompressFileGeodatabaseData(params object?[] args) => Run(args);
    public Code ComputeBlockAdjustment(params object?[] args) => Run(args);
    public Code ComputeCameraModel(params object?[] args) => Run(args);
    public Code ComputeControlPoints(params object?[] args) => Run(args);
    public Code ComputeDirtyArea(params object?[] args) => Run(args);
    public Code ComputeFiducials(params object?[] args) => Run(args);
    public Code ComputeMosaicCandidates(params object?[] args) => Run(args);
    public Code ComputePansharpenWeights(params object?[] args) => Run(args);
    public Code ComputeTiePoints(params object?[] args) => Run(args);
    public Code ConfigureGeodatabaseLogFileTables(params object?[] args) => Run(args);
    public Code ConsolidateLayer(params object?[] args) => Run(args);
    public Code ConsolidateLocator(params object?[] args) => Run(args);
    public Code ConsolidateMap(params object?[] args) => Run(args);
    public Code ConsolidateProject(params object?[] args) => Run(args);
    public Code ConsolidateToolbox(params object?[] args) => Run(args);
    public Code ConvertCoordinateNotation(params object?[] args) => Run(args);
    public Code ConvertRasterFunctionTemplate(params object?[] args) => Run(args);
    public Code ConvertTimeField(params object?[] args) => Run(args);
    public Code ConvertTimeZone(params object?[] args) => Run(args);
    public Code Copy(params object?[] args) => Run(args);
    public Code CopyFeatures(params object?[] args) => Run(args);
    public Code CopyRaster(params object?[] args) => Run(args);
    public Code CopyRows(params object?[] args) => Run(args);
    public Code Create3DObjectSceneLayerPackage(params object?[] args) => Run(args);
    public Code CreateBuildingSceneLayerPackage(params object?[] args) => Run(args);
    public Code CreateCatalogDataset(params object?[] args) => Run(args);
    public Code CreateCloudStorageConnectionFile(params object?[] args) => Run(args);
    public Code CreateColorComposite(params object?[] args) => Run(args);
    public Code CreateConnectionString(params object?[] args) => Run(args);
    public Code CreateCustomGeoTransformation(params object?[] args) => Run(args);
    public Code CreateDatabaseConnection(params object?[] args) => Run(args);
    public Code CreateDatabaseConnectionString(params object?[] args) => Run(args);
    public Code CreateDatabaseSequence(params object?[] args) => Run(args);
    public Code CreateDatabaseUser(params object?[] args) => Run(args);
    public Code CreateDatabaseView(params object?[] args) => Run(args);
    public Code CreateDomain(params object?[] args) => Run(args);
    public Code CreateEnterpriseGeodatabase(params object?[] args) => Run(args);
    public Code CreateFeatureDataset(params object?[] args) => Run(args);
    public Code CreateFeatureclass(params object?[] args) => Run(args);
    public Code CreateFieldGroup(params object?[] args) => Run(args);
    public Code CreateFileGDB(params object?[] args) => Run(args);
    public Code CreateFishnet(params object?[] args) => Run(args);
    public Code CreateFolder(params object?[] args) => Run(args);
    public Code CreateIntegratedMeshSceneLayerPackage(params object?[] args) => Run(args);
    public Code CreateLasDataset(params object?[] args) => Run(args);
    public Code CreateMapTilePackage(params object?[] args) => Run(args);
    public Code CreateMobileGDB(params object?[] args) => Run(args);
    public Code CreateMobileMapPackage(params object?[] args) => Run(args);
    public Code CreateMobileScenePackage(params object?[] args) => Run(args);
    public Code CreateMosaicDataset(params object?[] args) => Run(args);
    public Code CreateOrthoCorrectedRasterDataset(params object?[] args) => Run(args);
    public Code CreatePansharpenedRasterDataset(params object?[] args) => Run(args);
    public Code CreatePointCloudSceneLayerPackage(params object?[] args) => Run(args);
    public Code CreatePointSceneLayerPackage(params object?[] args) => Run(args);
    public Code CreateRandomPoints(params object?[] args) => Run(args);
    public Code CreateRandomRaster(params object?[] args) => Run(args);
    public Code CreateRasterDataset(params object?[] args) => Run(args);
    public Code CreateRasterType(params object?[] args) => Run(args);
    public Code CreateReferencedMosaicDataset(params object?[] args) => Run(args);
    public Code CreateRelationshipClass(params object?[] args) => Run(args);
    public Code CreateReplica(params object?[] args) => Run(args);
    public Code CreateReplicaFromServer(params object?[] args) => Run(args);
    public Code CreateRole(params object?[] args) => Run(args);
    public Code CreateSQLiteDatabase(params object?[] args) => Run(args);
    public Code CreateSceneLayerPackage(params object?[] args) => Run(args);
    public Code CreateSpatialReference(params object?[] args) => Run(args);
    public Code CreateSpatialType(params object?[] args) => Run(args);
    public Code CreateTable(params object?[] args) => Run(args);
    public Code CreateTopology(params object?[] args) => Run(args);
    public Code CreateTrajectoryDataset(params object?[] args) => Run(args);
    public Code CreateUnRegisteredFeatureclass(params object?[] args) => Run(args);
    public Code CreateUnRegisteredTable(params object?[] args) => Run(args);
    public Code CreateVectorTileIndex(params object?[] args) => Run(args);
    public Code CreateVectorTilePackage(params object?[] args) => Run(args);
    public Code CreateVersion(params object?[] args) => Run(args);
    public Code CreateVersionedView(params object?[] args) => Run(args);
    public Code CreateVoxelSceneLayerContent(params object?[] args) => Run(args);
    public Code DefineMosaicDatasetNoData(params object?[] args) => Run(args);
    public Code DefineOverviews(params object?[] args) => Run(args);
    public Code DefineProjection(params object?[] args) => Run(args);
    public Code Delete(params object?[] args) => Run(args);
    public Code DeleteAttributeRule(params object?[] args) => Run(args);
    public Code DeleteCodedValueFromDomain(params object?[] args) => Run(args);
    public Code DeleteColormap(params object?[] args) => Run(args);
    public Code DeleteDatabaseSequence(params object?[] args) => Run(args);
    public Code DeleteDomain(params object?[] args) => Run(args);
    public Code DeleteFeatures(params object?[] args) => Run(args);
    public Code DeleteField(params object?[] args) => Run(args);
    public Code DeleteFieldGroup(params object?[] args) => Run(args);
    public Code DeleteIdentical(params object?[] args) => Run(args);
    public Code DeleteMosaicDataset(params object?[] args) => Run(args);
    public Code DeleteRasterAttributeTable(params object?[] args) => Run(args);
    public Code DeleteRows(params object?[] args) => Run(args);
    public Code DeleteSchemaGeodatabase(params object?[] args) => Run(args);
    public Code DeleteVersion(params object?[] args) => Run(args);
    public Code DetectFeatureChanges(params object?[] args) => Run(args);
    public Code DiagnoseVersionMetadata(params object?[] args) => Run(args);
    public Code DiagnoseVersionTables(params object?[] args) => Run(args);
    public Code Dice(params object?[] args) => Run(args);
    public Code DisableArchiving(params object?[] args) => Run(args);
    public Code DisableAttachments(params object?[] args) => Run(args);
    public Code DisableAttributeRules(params object?[] args) => Run(args);
    public Code DisableCOGO(params object?[] args) => Run(args);
    public Code DisableEditorTracking(params object?[] args) => Run(args);
    public Code DisableFeatureBinning(params object?[] args) => Run(args);
    public Code DisableReplicaTracking(params object?[] args) => Run(args);
    public Code Dissolve(params object?[] args) => Run(args);
    public Code DomainToTable(params object?[] args) => Run(args);
    public Code DowngradeAttachments(params object?[] args) => Run(args);
    public Code DownloadRasters(params object?[] args) => Run(args);
    public Code EditRasterFunction(params object?[] args) => Run(args);
    public Code Eliminate(params object?[] args) => Run(args);
    public Code EliminatePolygonPart(params object?[] args) => Run(args);
    public Code EnableArchiving(params object?[] args) => Run(args);
    public Code EnableAttachments(params object?[] args) => Run(args);
    public Code EnableAttributeRules(params object?[] args) => Run(args);
    public Code EnableCOGO(params object?[] args) => Run(args);
    public Code EnableEditorTracking(params object?[] args) => Run(args);
    public Code EnableEnterpriseGeodatabase(params object?[] args) => Run(args);
    public Code EnableFeatureBinning(params object?[] args) => Run(args);
    public Code EnableReplicaTracking(params object?[] args) => Run(args);
    public Code EncodeField(params object?[] args) => Run(args);
    public Code EvaluateRules(params object?[] args) => Run(args);
    public Code ExportAcknowledgementMessage(params object?[] args) => Run(args);
    public Code ExportAttributeRules(params object?[] args) => Run(args);
    public Code ExportContingentValues(params object?[] args) => Run(args);
    public Code ExportDataChangeMessage(params object?[] args) => Run(args);
    public Code ExportFrameAndCameraParameters(params object?[] args) => Run(args);
    public Code ExportGeodatabaseConfigurationKeywords(params object?[] args) => Run(args);
    public Code ExportMosaicDatasetGeometry(params object?[] args) => Run(args);
    public Code ExportMosaicDatasetItems(params object?[] args) => Run(args);
    public Code ExportMosaicDatasetPaths(params object?[] args) => Run(args);
    public Code ExportRasterWorldFile(params object?[] args) => Run(args);
    public Code ExportReplicaSchema(params object?[] args) => Run(args);
    public Code ExportReportToPDF(params object?[] args) => Run(args);
    public Code ExportTileCache(params object?[] args) => Run(args);
    public Code ExportTopologyErrors(params object?[] args) => Run(args);
    public Code ExportXMLWorkspaceDocument(params object?[] args) => Run(args);
    public Code ExtractPackage(params object?[] args) => Run(args);
    public Code ExtractSubDataset(params object?[] args) => Run(args);
    public Code FeatureCompare(params object?[] args) => Run(args);
    public Code FeatureEnvelopeToPolygon(params object?[] args) => Run(args);
    public Code FeatureToLine(params object?[] args) => Run(args);
    public Code FeatureToPoint(params object?[] args) => Run(args);
    public Code FeatureToPolygon(params object?[] args) => Run(args);
    public Code FeatureVerticesToPoints(params object?[] args) => Run(args);
    public Code FieldStatisticsToTable(params object?[] args) => Run(args);
    public Code FileCompare(params object?[] args) => Run(args);
    public Code FindIdentical(params object?[] args) => Run(args);
    public Code Flip(params object?[] args) => Run(args);
    public Code GenerateAttachmentMatchTable(params object?[] args) => Run(args);
    public Code GenerateBlockAdjustmentReport(params object?[] args) => Run(args);
    public Code GenerateExcludeArea(params object?[] args) => Run(args);
    public Code GenerateFgdbLicense(params object?[] args) => Run(args);
    public Code GenerateLicensedFgdb(params object?[] args) => Run(args);
    public Code GeneratePointCloud(params object?[] args) => Run(args);
    public Code GeneratePointsAlongLines(params object?[] args) => Run(args);
    public Code GenerateRasterCollection(params object?[] args) => Run(args);
    public Code GenerateRasterFromRasterFunction(params object?[] args) => Run(args);
    public Code GenerateRectanglesAlongLines(params object?[] args) => Run(args);
    public Code GenerateTableFromRasterFunction(params object?[] args) => Run(args);
    public Code GenerateTessellation(params object?[] args) => Run(args);
    public Code GenerateTileCacheTilingScheme(params object?[] args) => Run(args);
    public Code GenerateTransectsAlongLines(params object?[] args) => Run(args);
    public Code GeoTaggedPhotosToPoints(params object?[] args) => Run(args);
    public Code GeodeticDensify(params object?[] args) => Run(args);
    public Code GetCellValue(params object?[] args) => Run(args);
    public Code GetCount(params object?[] args) => Run(args);
    public Code GetRasterProperties(params object?[] args) => Run(args);
    public Code ImportAttributeRules(params object?[] args) => Run(args);
    public Code ImportContingentValues(params object?[] args) => Run(args);
    public Code ImportGeodatabaseConfigurationKeywords(params object?[] args) => Run(args);
    public Code ImportMessage(params object?[] args) => Run(args);
    public Code ImportMosaicDatasetGeometry(params object?[] args) => Run(args);
    public Code ImportReplicaSchema(params object?[] args) => Run(args);
    public Code ImportTileCache(params object?[] args) => Run(args);
    public Code ImportXMLWorkspaceDocument(params object?[] args) => Run(args);
    public Code Integrate(params object?[] args) => Run(args);
    public Code InterpolateFromPointCloud(params object?[] args) => Run(args);
    public Code JoinField(params object?[] args) => Run(args);
    public Code LasDatasetStatistics(params object?[] args) => Run(args);
    public Code LasPointStatsAsRaster(params object?[] args) => Run(args);
    public Code MakeAggregationQueryLayer(params object?[] args) => Run(args);
    public Code MakeBuildingLayer(params object?[] args) => Run(args);
    public Code MakeFeatureLayer(params object?[] args) => Run(args);
    public Code MakeImageServerLayer(params object?[] args) => Run(args);
    public Code MakeLasDatasetLayer(params object?[] args) => Run(args);
    public Code MakeMosaicLayer(params object?[] args) => Run(args);
    public Code MakeQueryLayer(params object?[] args) => Run(args);
    public Code MakeQueryTable(params object?[] args) => Run(args);
    public Code MakeRasterLayer(params object?[] args) => Run(args);
    public Code MakeSceneLayer(params object?[] args) => Run(args);
    public Code MakeTableView(params object?[] args) => Run(args);
    public Code MakeTinLayer(params object?[] args) => Run(args);
    public Code MakeTrajectoryLayer(params object?[] args) => Run(args);
    public Code MakeWCSLayer(params object?[] args) => Run(args);
    public Code MakeXYEventLayer(params object?[] args) => Run(args);
    public Code ManageFeatureBinCache(params object?[] args) => Run(args);
    public Code ManageTileCache(params object?[] args) => Run(args);
    public Code MatchControlPoints(params object?[] args) => Run(args);
    public Code MatchLayerSymbologyToAStyle(params object?[] args) => Run(args);
    public Code MatchPhotosToRowsByTime(params object?[] args) => Run(args);
    public Code Merge(params object?[] args) => Run(args);
    public Code MergeMosaicDatasetItems(params object?[] args) => Run(args);
    public Code MigrateObjectIDTo64Bit(params object?[] args) => Run(args);
    public Code MigrateRelationshipClass(params object?[] args) => Run(args);
    public Code MigrateStorage(params object?[] args) => Run(args);
    public Code MinimumBoundingGeometry(params object?[] args) => Run(args);
    public Code Mirror(params object?[] args) => Run(args);
    public Code Mosaic(params object?[] args) => Run(args);
    public Code MosaicDatasetToMobileMosaicDataset(params object?[] args) => Run(args);
    public Code MosaicToNewRaster(params object?[] args) => Run(args);
    public Code MultipartToSinglepart(params object?[] args) => Run(args);
    public Code PackageLayer(params object?[] args) => Run(args);
    public Code PackageLocator(params object?[] args) => Run(args);
    public Code PackageMap(params object?[] args) => Run(args);
    public Code PackageProject(params object?[] args) => Run(args);
    public Code PackageResult(params object?[] args) => Run(args);
    public Code PivotTable(params object?[] args) => Run(args);
    public Code PointsToLine(params object?[] args) => Run(args);
    public Code PolygonToLine(params object?[] args) => Run(args);
    public Code Project(params object?[] args) => Run(args);
    public Code ProjectRaster(params object?[] args) => Run(args);
    public Code RasterCompare(params object?[] args) => Run(args);
    public Code RasterToDTED(params object?[] args) => Run(args);
    public Code ReExportUnacknowledgedMessages(params object?[] args) => Run(args);
    public Code RebuildIndexes(params object?[] args) => Run(args);
    public Code RecalculateFeatureClassExtent(params object?[] args) => Run(args);
    public Code ReclassifyField(params object?[] args) => Run(args);
    public Code ReconcileVersion(params object?[] args) => Run(args);
    public Code ReconcileVersions(params object?[] args) => Run(args);
    public Code RecoverFileGDB(params object?[] args) => Run(args);
    public Code RefreshExcel(params object?[] args) => Run(args);
    public Code RegisterAsVersioned(params object?[] args) => Run(args);
    public Code RegisterRaster(params object?[] args) => Run(args);
    public Code RegisterWithGeodatabase(params object?[] args) => Run(args);
    public Code Remove3DFormats(params object?[] args) => Run(args);
    public Code RemoveAttachments(params object?[] args) => Run(args);
    public Code RemoveContingentValue(params object?[] args) => Run(args);
    public Code RemoveDomainFromField(params object?[] args) => Run(args);
    public Code RemoveFeatureClassFromTopology(params object?[] args) => Run(args);
    public Code RemoveFieldConflictFilter(params object?[] args) => Run(args);
    public Code RemoveFilesFromLasDataset(params object?[] args) => Run(args);
    public Code RemoveIndex(params object?[] args) => Run(args);
    public Code RemoveJoin(params object?[] args) => Run(args);
    public Code RemoveRastersFromMosaicDataset(params object?[] args) => Run(args);
    public Code RemoveRelate(params object?[] args) => Run(args);
    public Code RemoveRuleFromRelationshipClass(params object?[] args) => Run(args);
    public Code RemoveRuleFromTopology(params object?[] args) => Run(args);
    public Code RemoveSpatialIndex(params object?[] args) => Run(args);
    public Code RemoveSubtype(params object?[] args) => Run(args);
    public Code Rename(params object?[] args) => Run(args);
    public Code ReorderAttributeRule(params object?[] args) => Run(args);
    public Code RepairGeometry(params object?[] args) => Run(args);
    public Code RepairMosaicDatasetPaths(params object?[] args) => Run(args);
    public Code RepairTrajectoryDatasetPaths(params object?[] args) => Run(args);
    public Code RepairVersionMetadata(params object?[] args) => Run(args);
    public Code RepairVersionTables(params object?[] args) => Run(args);
    public Code Resample(params object?[] args) => Run(args);
    public Code Rescale(params object?[] args) => Run(args);
    public Code Rotate(params object?[] args) => Run(args);
    public Code SaveToLayerFile(params object?[] args) => Run(args);
    public Code SaveToolboxToVersion(params object?[] args) => Run(args);
    public Code SelectData(params object?[] args) => Run(args);
    public Code SelectLayerByAttribute(params object?[] args) => Run(args);
    public Code SelectLayerByLocation(params object?[] args) => Run(args);
    public Code SetClusterTolerance(params object?[] args) => Run(args);
    public Code SetDefaultSubtype(params object?[] args) => Run(args);
    public Code SetFeatureClassSplitModel(params object?[] args) => Run(args);
    public Code SetMosaicDatasetProperties(params object?[] args) => Run(args);
    public Code SetRasterProperties(params object?[] args) => Run(args);
    public Code SetRelationshipClassSplitPolicy(params object?[] args) => Run(args);
    public Code SetSubtypeField(params object?[] args) => Run(args);
    public Code SetValueForRangeDomain(params object?[] args) => Run(args);
    public Code SharePackage(params object?[] args) => Run(args);
    public Code Shift(params object?[] args) => Run(args);
    public Code Sort(params object?[] args) => Run(args);
    public Code SortCodedValueDomain(params object?[] args) => Run(args);
    public Code SplitLine(params object?[] args) => Run(args);
    public Code SplitLineAtPoint(params object?[] args) => Run(args);
    public Code SplitMosaicDatasetItems(params object?[] args) => Run(args);
    public Code SplitRaster(params object?[] args) => Run(args);
    public Code StandardizeField(params object?[] args) => Run(args);
    public Code SubdividePolygon(params object?[] args) => Run(args);
    public Code SynchronizeChanges(params object?[] args) => Run(args);
    public Code SynchronizeMosaicDataset(params object?[] args) => Run(args);
    public Code TINCompare(params object?[] args) => Run(args);
    public Code TableCompare(params object?[] args) => Run(args);
    public Code TableToDomain(params object?[] args) => Run(args);
    public Code TableToEllipse(params object?[] args) => Run(args);
    public Code TableToRelationshipClass(params object?[] args) => Run(args);
    public Code TransferFiles(params object?[] args) => Run(args);
    public Code TransformField(params object?[] args) => Run(args);
    public Code TransposeFields(params object?[] args) => Run(args);
    public Code TrimArchiveHistory(params object?[] args) => Run(args);
    public Code TruncateTable(params object?[] args) => Run(args);
    public Code UncompressFileGeodatabaseData(params object?[] args) => Run(args);
    public Code UnregisterAsVersioned(params object?[] args) => Run(args);
    public Code UnregisterReplica(params object?[] args) => Run(args);
    public Code UnsplitLine(params object?[] args) => Run(args);
    public Code UpdateEnterpriseGeodatabaseLicense(params object?[] args) => Run(args);
    public Code UpdateGeodatabaseConnectionPropertiesToBranch(params object?[] args) => Run(args);
    public Code UpdateInteriorOrientation(params object?[] args) => Run(args);
    public Code UpdatePortalDatasetOwner(params object?[] args) => Run(args);
    public Code UpgradeAttachments(params object?[] args) => Run(args);
    public Code UpgradeDataset(params object?[] args) => Run(args);
    public Code UpgradeGDB(params object?[] args) => Run(args);
    public Code UpgradeSceneLayer(params object?[] args) => Run(args);
    public Code ValidateJoin(params object?[] args) => Run(args);
    public Code ValidateSceneLayerPackage(params object?[] args) => Run(args);
    public Code ValidateTopology(params object?[] args) => Run(args);
    public Code Warp(params object?[] args) => Run(args);
    public Code WarpFromFile(params object?[] args) => Run(args);
    public Code WorkspaceToRasterDataset(params object?[] args) => Run(args);
    public Code XYTableToPoint(params object?[] args) => Run(args);
    public Code XYToLine(params object?[] args) => Run(args);
}
