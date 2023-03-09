using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Conversion
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.conversion.{method}", args);
    }

    public Code ASCIIToRaster(params object?[] args) => Run(args);
    public Code AddCADFields(params object?[] args) => Run(args);
    public Code AddRasterToGeoPackage(params object?[] args) => Run(args);
    public Code BIMFileToGeodatabase(params object?[] args) => Run(args);
    public Code CADToGeodatabase(params object?[] args) => Run(args);
    public Code ConnectNetworkDatasetTransitSourcesToStreets(params object?[] args) => Run(args);
    public Code ConvertLas(params object?[] args) => Run(args);
    public Code DEMToRaster(params object?[] args) => Run(args);
    public Code ExcelToTable(params object?[] args) => Run(args);
    public Code ExportCAD(params object?[] args) => Run(args);
    public Code ExportFeatures(params object?[] args) => Run(args);
    public Code ExportTable(params object?[] args) => Run(args);
    public Code ExtractLocationsDocument(params object?[] args) => Run(args);
    public Code ExtractLocationsText(params object?[] args) => Run(args);
    public Code FeatureClassToFeatureClass(params object?[] args) => Run(args);
    public Code FeatureClassToGeodatabase(params object?[] args) => Run(args);
    public Code FeatureClassToShapefile(params object?[] args) => Run(args);
    public Code FeatureToRaster(params object?[] args) => Run(args);
    public Code FeaturesToGPX(params object?[] args) => Run(args);
    public Code FeaturesToGTFSShapes(params object?[] args) => Run(args);
    public Code FeaturesToGTFSStops(params object?[] args) => Run(args);
    public Code FeaturesToGraphics(params object?[] args) => Run(args);
    public Code FeaturesToJSON(params object?[] args) => Run(args);
    public Code FloatToRaster(params object?[] args) => Run(args);
    public Code GPXtoFeatures(params object?[] args) => Run(args);
    public Code GTFSShapesToFeatures(params object?[] args) => Run(args);
    public Code GTFSStopsToFeatures(params object?[] args) => Run(args);
    public Code GTFSToNetworkDatasetTransitSources(params object?[] args) => Run(args);
    public Code GenerateShapesFeaturesFromGTFS(params object?[] args) => Run(args);
    public Code GraphicsToFeatures(params object?[] args) => Run(args);
    public Code JSONToFeatures(params object?[] args) => Run(args);
    public Code KMLToLayer(params object?[] args) => Run(args);
    public Code LasDatasetToRaster(params object?[] args) => Run(args);
    public Code LayerToKML(params object?[] args) => Run(args);
    public Code MapToKML(params object?[] args) => Run(args);
    public Code MobileGdbToFileGdb(params object?[] args) => Run(args);
    public Code MultipatchToCollada(params object?[] args) => Run(args);
    public Code MultipatchToRaster(params object?[] args) => Run(args);
    public Code PDFToTIFF(params object?[] args) => Run(args);
    public Code PointCloudToRaster(params object?[] args) => Run(args);
    public Code PointToRaster(params object?[] args) => Run(args);
    public Code PolygonToRaster(params object?[] args) => Run(args);
    public Code PolylineToRaster(params object?[] args) => Run(args);
    public Code RasterToASCII(params object?[] args) => Run(args);
    public Code RasterToFloat(params object?[] args) => Run(args);
    public Code RasterToGeodatabase(params object?[] args) => Run(args);
    public Code RasterToOtherFormat(params object?[] args) => Run(args);
    public Code RasterToPoint(params object?[] args) => Run(args);
    public Code RasterToPolygon(params object?[] args) => Run(args);
    public Code RasterToPolyline(params object?[] args) => Run(args);
    public Code SASToTable(params object?[] args) => Run(args);
    public Code TableToDBASE(params object?[] args) => Run(args);
    public Code TableToExcel(params object?[] args) => Run(args);
    public Code TableToGeodatabase(params object?[] args) => Run(args);
    public Code TableToSAS(params object?[] args) => Run(args);
    public Code TableToTable(params object?[] args) => Run(args);
    public Code WFSToFeatureClass(params object?[] args) => Run(args);
}
