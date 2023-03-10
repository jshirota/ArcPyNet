using ArcPyNet;

namespace Glidergun;

public static class GridExtra
{
    public static Grid Hillshade(this Grid grid, double azimuth = 315, double altitude = 45, bool model_shadows = false, double z_factor = 1)
        => ArcPy.Instance.sa.Hillshade(grid, azimuth, altitude, model_shadows ? "SHADOWS" : "NO_SHADOWS", z_factor);

    public static Grid Color(this Grid grid, ColorRamp colorRamp)
    {
        var temp1 = ArcPy.GetTempName();
        var temp2 = ArcPy.GetTempName();

        var result = ArcPy.Instance.Run($"""
            arcpy.MakeRasterLayer_management(arcpy.sa.Colormap({grid.Name}, {ArcPy.Format(colorRamp)}), "{temp1}")
            arcpy.CopyRaster_management("{temp1}", "{temp2}")
            """, $"""arcpy.sa.Raster("{temp2}")""");

        return result;
    }
}
