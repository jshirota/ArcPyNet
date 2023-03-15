using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Conversion
{
    internal _Conversion() { }
}

public static class _ConversionExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.conversion.{method}", args);
    }

    public static Code ASCIIToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code AddCADFields(this _Conversion _, params object?[] args) => Run(args);
    public static Code AddRasterToGeoPackage(this _Conversion _, params object?[] args) => Run(args);
    public static Code BIMFileToGeodatabase(this _Conversion _, params object?[] args) => Run(args);
    public static Code CADToGeodatabase(this _Conversion _, params object?[] args) => Run(args);
    public static Code ConnectNetworkDatasetTransitSourcesToStreets(this _Conversion _, params object?[] args) => Run(args);
    public static Code ConvertLas(this _Conversion _, params object?[] args) => Run(args);
    public static Code DEMToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code ExcelToTable(this _Conversion _, params object?[] args) => Run(args);
    public static Code ExportCAD(this _Conversion _, params object?[] args) => Run(args);
    public static Code ExportFeatures(this _Conversion _, params object?[] args) => Run(args);
    public static Code ExportTable(this _Conversion _, params object?[] args) => Run(args);
    public static Code ExtractLocationsDocument(this _Conversion _, params object?[] args) => Run(args);
    public static Code ExtractLocationsText(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeatureClassToFeatureClass(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeatureClassToGeodatabase(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeatureClassToShapefile(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeatureToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeaturesToGPX(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeaturesToGTFSShapes(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeaturesToGTFSStops(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeaturesToGraphics(this _Conversion _, params object?[] args) => Run(args);
    public static Code FeaturesToJSON(this _Conversion _, params object?[] args) => Run(args);
    public static Code FloatToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code GPXtoFeatures(this _Conversion _, params object?[] args) => Run(args);
    public static Code GTFSShapesToFeatures(this _Conversion _, params object?[] args) => Run(args);
    public static Code GTFSStopsToFeatures(this _Conversion _, params object?[] args) => Run(args);
    public static Code GTFSToNetworkDatasetTransitSources(this _Conversion _, params object?[] args) => Run(args);
    public static Code GenerateShapesFeaturesFromGTFS(this _Conversion _, params object?[] args) => Run(args);
    public static Code GraphicsToFeatures(this _Conversion _, params object?[] args) => Run(args);
    public static Code JSONToFeatures(this _Conversion _, params object?[] args) => Run(args);
    public static Code KMLToLayer(this _Conversion _, params object?[] args) => Run(args);
    public static Code LasDatasetToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code LayerToKML(this _Conversion _, params object?[] args) => Run(args);
    public static Code MapToKML(this _Conversion _, params object?[] args) => Run(args);
    public static Code MobileGdbToFileGdb(this _Conversion _, params object?[] args) => Run(args);
    public static Code MultipatchToCollada(this _Conversion _, params object?[] args) => Run(args);
    public static Code MultipatchToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code PDFToTIFF(this _Conversion _, params object?[] args) => Run(args);
    public static Code PointCloudToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code PointToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code PolygonToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code PolylineToRaster(this _Conversion _, params object?[] args) => Run(args);
    public static Code RasterToASCII(this _Conversion _, params object?[] args) => Run(args);
    public static Code RasterToFloat(this _Conversion _, params object?[] args) => Run(args);
    public static Code RasterToGeodatabase(this _Conversion _, params object?[] args) => Run(args);
    public static Code RasterToOtherFormat(this _Conversion _, params object?[] args) => Run(args);
    public static Code RasterToPoint(this _Conversion _, params object?[] args) => Run(args);
    public static Code RasterToPolygon(this _Conversion _, params object?[] args) => Run(args);
    public static Code RasterToPolyline(this _Conversion _, params object?[] args) => Run(args);
    public static Code SASToTable(this _Conversion _, params object?[] args) => Run(args);
    public static Code TableToDBASE(this _Conversion _, params object?[] args) => Run(args);
    public static Code TableToExcel(this _Conversion _, params object?[] args) => Run(args);
    public static Code TableToGeodatabase(this _Conversion _, params object?[] args) => Run(args);
    public static Code TableToSAS(this _Conversion _, params object?[] args) => Run(args);
    public static Code TableToTable(this _Conversion _, params object?[] args) => Run(args);
    public static Code WFSToFeatureClass(this _Conversion _, params object?[] args) => Run(args);
}
