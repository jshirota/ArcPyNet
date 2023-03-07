using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Conversion
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.conversion.{method}", args);
    }

    public Variable ASCIIToRaster(params object?[] args) => Run(args);
    public Variable AddCADFields(params object?[] args) => Run(args);
    public Variable AddRasterToGeoPackage(params object?[] args) => Run(args);
    public Variable BIMFileToGeodatabase(params object?[] args) => Run(args);
    public Variable CADToGeodatabase(params object?[] args) => Run(args);
    public Variable ConnectNetworkDatasetTransitSourcesToStreets(params object?[] args) => Run(args);
    public Variable ConvertLas(params object?[] args) => Run(args);
    public Variable DEMToRaster(params object?[] args) => Run(args);
    public Variable ExcelToTable(params object?[] args) => Run(args);
    public Variable ExportCAD(params object?[] args) => Run(args);
    public Variable ExportFeatures(params object?[] args) => Run(args);
    public Variable ExportTable(params object?[] args) => Run(args);
    public Variable ExtractLocationsDocument(params object?[] args) => Run(args);
    public Variable ExtractLocationsText(params object?[] args) => Run(args);
    public Variable FeatureClassToFeatureClass(params object?[] args) => Run(args);
    public Variable FeatureClassToGeodatabase(params object?[] args) => Run(args);
    public Variable FeatureClassToShapefile(params object?[] args) => Run(args);
    public Variable FeatureToRaster(params object?[] args) => Run(args);
    public Variable FeaturesToGPX(params object?[] args) => Run(args);
    public Variable FeaturesToGTFSShapes(params object?[] args) => Run(args);
    public Variable FeaturesToGTFSStops(params object?[] args) => Run(args);
    public Variable FeaturesToGraphics(params object?[] args) => Run(args);
    public Variable FeaturesToJSON(params object?[] args) => Run(args);
    public Variable FloatToRaster(params object?[] args) => Run(args);
    public Variable GPXtoFeatures(params object?[] args) => Run(args);
    public Variable GTFSShapesToFeatures(params object?[] args) => Run(args);
    public Variable GTFSStopsToFeatures(params object?[] args) => Run(args);
    public Variable GTFSToNetworkDatasetTransitSources(params object?[] args) => Run(args);
    public Variable GenerateShapesFeaturesFromGTFS(params object?[] args) => Run(args);
    public Variable GraphicsToFeatures(params object?[] args) => Run(args);
    public Variable JSONToFeatures(params object?[] args) => Run(args);
    public Variable KMLToLayer(params object?[] args) => Run(args);
    public Variable LasDatasetToRaster(params object?[] args) => Run(args);
    public Variable LayerToKML(params object?[] args) => Run(args);
    public Variable MapToKML(params object?[] args) => Run(args);
    public Variable MobileGdbToFileGdb(params object?[] args) => Run(args);
    public Variable MultipatchToCollada(params object?[] args) => Run(args);
    public Variable MultipatchToRaster(params object?[] args) => Run(args);
    public Variable PDFToTIFF(params object?[] args) => Run(args);
    public Variable PointCloudToRaster(params object?[] args) => Run(args);
    public Variable PointToRaster(params object?[] args) => Run(args);
    public Variable PolygonToRaster(params object?[] args) => Run(args);
    public Variable PolylineToRaster(params object?[] args) => Run(args);
    public Variable RasterToASCII(params object?[] args) => Run(args);
    public Variable RasterToFloat(params object?[] args) => Run(args);
    public Variable RasterToGeodatabase(params object?[] args) => Run(args);
    public Variable RasterToOtherFormat(params object?[] args) => Run(args);
    public Variable RasterToPoint(params object?[] args) => Run(args);
    public Variable RasterToPolygon(params object?[] args) => Run(args);
    public Variable RasterToPolyline(params object?[] args) => Run(args);
    public Variable SASToTable(params object?[] args) => Run(args);
    public Variable TableToDBASE(params object?[] args) => Run(args);
    public Variable TableToExcel(params object?[] args) => Run(args);
    public Variable TableToGeodatabase(params object?[] args) => Run(args);
    public Variable TableToSAS(params object?[] args) => Run(args);
    public Variable TableToTable(params object?[] args) => Run(args);
    public Variable WFSToFeatureClass(params object?[] args) => Run(args);
}
