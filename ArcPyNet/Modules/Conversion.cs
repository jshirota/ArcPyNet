using System.Runtime.CompilerServices;

namespace ArcPyNet;

public static class Conversion
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Run($"arcpy.conversion.{method}", args);
    }

    public static Variable ASCIIToRaster(params object?[] args) => Run(args);
    public static Variable AddCADFields(params object?[] args) => Run(args);
    public static Variable AddRasterToGeoPackage(params object?[] args) => Run(args);
    public static Variable BIMFileToGeodatabase(params object?[] args) => Run(args);
    public static Variable CADToGeodatabase(params object?[] args) => Run(args);
    public static Variable ConnectNetworkDatasetTransitSourcesToStreets(params object?[] args) => Run(args);
    public static Variable ConvertLas(params object?[] args) => Run(args);
    public static Variable DEMToRaster(params object?[] args) => Run(args);
    public static Variable ExcelToTable(params object?[] args) => Run(args);
    public static Variable ExportCAD(params object?[] args) => Run(args);
    public static Variable ExportFeatures(params object?[] args) => Run(args);
    public static Variable ExportTable(params object?[] args) => Run(args);
    public static Variable ExtractLocationsDocument(params object?[] args) => Run(args);
    public static Variable ExtractLocationsText(params object?[] args) => Run(args);
    public static Variable FeatureClassToFeatureClass(params object?[] args) => Run(args);
    public static Variable FeatureClassToGeodatabase(params object?[] args) => Run(args);
    public static Variable FeatureClassToShapefile(params object?[] args) => Run(args);
    public static Variable FeatureToRaster(params object?[] args) => Run(args);
    public static Variable FeaturesToGPX(params object?[] args) => Run(args);
    public static Variable FeaturesToGTFSShapes(params object?[] args) => Run(args);
    public static Variable FeaturesToGTFSStops(params object?[] args) => Run(args);
    public static Variable FeaturesToGraphics(params object?[] args) => Run(args);
    public static Variable FeaturesToJSON(params object?[] args) => Run(args);
    public static Variable FloatToRaster(params object?[] args) => Run(args);
    public static Variable GPXtoFeatures(params object?[] args) => Run(args);
    public static Variable GTFSShapesToFeatures(params object?[] args) => Run(args);
    public static Variable GTFSStopsToFeatures(params object?[] args) => Run(args);
    public static Variable GTFSToNetworkDatasetTransitSources(params object?[] args) => Run(args);
    public static Variable GenerateShapesFeaturesFromGTFS(params object?[] args) => Run(args);
    public static Variable GraphicsToFeatures(params object?[] args) => Run(args);
    public static Variable JSONToFeatures(params object?[] args) => Run(args);
    public static Variable KMLToLayer(params object?[] args) => Run(args);
    public static Variable LasDatasetToRaster(params object?[] args) => Run(args);
    public static Variable LayerToKML(params object?[] args) => Run(args);
    public static Variable MapToKML(params object?[] args) => Run(args);
    public static Variable MobileGdbToFileGdb(params object?[] args) => Run(args);
    public static Variable MultipatchToCollada(params object?[] args) => Run(args);
    public static Variable MultipatchToRaster(params object?[] args) => Run(args);
    public static Variable PDFToTIFF(params object?[] args) => Run(args);
    public static Variable PointCloudToRaster(params object?[] args) => Run(args);
    public static Variable PointToRaster(params object?[] args) => Run(args);
    public static Variable PolygonToRaster(params object?[] args) => Run(args);
    public static Variable PolylineToRaster(params object?[] args) => Run(args);
    public static Variable RasterToASCII(params object?[] args) => Run(args);
    public static Variable RasterToFloat(params object?[] args) => Run(args);
    public static Variable RasterToGeodatabase(params object?[] args) => Run(args);
    public static Variable RasterToOtherFormat(params object?[] args) => Run(args);
    public static Variable RasterToPoint(params object?[] args) => Run(args);
    public static Variable RasterToPolygon(params object?[] args) => Run(args);
    public static Variable RasterToPolyline(params object?[] args) => Run(args);
    public static Variable SASToTable(params object?[] args) => Run(args);
    public static Variable TableToDBASE(params object?[] args) => Run(args);
    public static Variable TableToExcel(params object?[] args) => Run(args);
    public static Variable TableToGeodatabase(params object?[] args) => Run(args);
    public static Variable TableToSAS(params object?[] args) => Run(args);
    public static Variable TableToTable(params object?[] args) => Run(args);
    public static Variable WFSToFeatureClass(params object?[] args) => Run(args);
}

