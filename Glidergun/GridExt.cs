using ArcPyNet;

namespace Glidergun;

public static class GridExt
{
    public static Grid Abs(this Grid grid)
        => ArcPy.Instance.SpatialAnalyst.Abs(grid);

    public static Grid ACos(this Grid grid)
        => ArcPy.Instance.SpatialAnalyst.ACos(grid);

    public static Grid Con(this Grid grid, double trueValue, double falseValue)
        => ArcPy.Instance.SpatialAnalyst.Con(grid, trueValue, falseValue);

    public static Grid Con(this Grid grid, double trueValue, Grid falseGrid)
        => ArcPy.Instance.SpatialAnalyst.Con(grid, trueValue, falseGrid);

    public static Grid Con(this Grid grid, Grid trueGrid, double falseValue)
        => ArcPy.Instance.SpatialAnalyst.Con(grid, trueGrid, falseValue);

    public static Grid Con(this Grid grid, Grid trueGrid, Grid falseGrid)
        => ArcPy.Instance.SpatialAnalyst.Con(grid, trueGrid, falseGrid);

    public static Grid Hillshade(this Grid grid, double azimuth = 315, double altitude = 45, bool model_shadows = false, double z_factor = 1)
        => ArcPy.Instance.SpatialAnalyst.Hillshade(grid, azimuth, altitude, model_shadows ? "SHADOWS" : "NO_SHADOWS", z_factor);

    public static byte[] GetThumbnail(this Grid grid)
    {
        var fileName = Path.GetTempFileName().Replace(".tmp", "");

        var temp = ArcPy.Instance.DataManagement.Resample(grid, fileName, "0.001");
        var pngFileName = fileName + ".png";

        ArcPy.Instance.DataManagement.CopyRaster(temp,
            pngFileName, null, null, null, null,
             "ColormapToRGB",
             "8_BIT_UNSIGNED");

        return File.ReadAllBytes(pngFileName);
    }
}
