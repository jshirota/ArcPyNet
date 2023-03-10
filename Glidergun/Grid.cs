using ArcPyNet;

namespace Glidergun;

public class Grid : Metadata
{
    private static readonly ArcPy arcpy = ArcPy.Instance;

    public Code Name { get; private set; }

    public Grid(Code name)
    {
        this.Name = name;

        var code = $$"""
            {
                "bandCount": {{name}}.bandCount,
                "extent": json.loads({{name}}.extent.JSON),
                "width": {{name}}.width,
                "height": {{name}}.height,
                "pixelType": {{name}}.pixelType,
                "isInteger": {{name}}.isInteger,
                "noDataValue": {{name}}.noDataValue,
                "minimum": {{name}}.minimum,
                "maximum": {{name}}.maximum,
                "mean": {{name}}.mean,
                "standardDeviation": {{name}}.standardDeviation,
                "meanCellWidth": {{name}}.meanCellWidth,
                "meanCellHeight": {{name}}.meanCellHeight,
                "wkid": {{name}}.spatialReference.factoryCode,
                "wkt": {{name}}.spatialReference.exportToString(),
                "hasColormap": hasattr(arcpy.sa.Raster, "getColormap") and {{name}}.getColormap("") is not None
            }
            """;

        var result = arcpy.Run(code);
        var metadata = result.Evaluate<Metadata>();

        foreach (var p in typeof(Metadata).GetProperties())
            if (p.CanWrite)
                p.SetValue(this, p.GetValue(metadata));
    }

    public Grid(string name)
        : this(arcpy.sa.Raster(name))
    {
    }

    public static implicit operator Grid(Code name) => new(name);

    private string thumbnail = default!;
    public string Thumbnail => thumbnail ??= $"<img src='data:image/png;base64, {Convert.ToBase64String(this.GetThumbnail())}' />";

    private byte[] GetThumbnail()
    {
        var fileName = Path.GetTempFileName().Replace(".tmp", "");

        var outputCellSize = this.MeanCellWidth * this.Width / 600;
        var temp = arcpy.management.Resample(this, fileName, outputCellSize);
        var pngFileName = fileName + ".png";

        if (this.HasColormap)
            arcpy.management.CopyRaster(temp, pngFileName, null, null, null, null, "ColormapToRGB", "8_BIT_UNSIGNED", null);
        else
            arcpy.management.CopyRaster(temp, pngFileName, null, null, null, null, null, "8_BIT_UNSIGNED", "ScalePixelValue");

        return File.ReadAllBytes(pngFileName);
    }

    public void Save(FilePath filePath)
    {
        arcpy.management.CopyRaster(this, (string)filePath);
    }

    public void Save(Stream stream, RasterFormat format)
    {
        var path = $@"{arcpy.Workspace}\{ArcPy.GetTempName()}.{format}";
        this.Save(path);
        using var source = new FileStream(path, FileMode.Open, FileAccess.Read);
        source.CopyTo(stream);
    }

    public override bool Equals(object? obj)
    {
        return obj is Grid grid && grid.Name == this.Name;
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public override string ToString()
    {
        return this.Name;
    }

    public static Grid operator +(Grid grid1, Grid grid2) => arcpy.sa.Plus(grid1, grid2);
    public static Grid operator +(Grid grid, int n) => arcpy.sa.Plus(grid, n);
    public static Grid operator +(Grid grid, double n) => arcpy.sa.Plus(grid, n);
    public static Grid operator +(int n, Grid grid) => arcpy.sa.Plus(n, grid);
    public static Grid operator +(double n, Grid grid) => arcpy.sa.Plus(n, grid);
    public static Grid operator +(Grid grid) => arcpy.sa.Plus(0, grid);
    public static Grid operator -(Grid grid1, Grid grid2) => arcpy.sa.Minus(grid1, grid2);
    public static Grid operator -(Grid grid, int n) => arcpy.sa.Minus(grid, n);
    public static Grid operator -(Grid grid, double n) => arcpy.sa.Minus(grid, n);
    public static Grid operator -(int n, Grid grid) => arcpy.sa.Minus(n, grid);
    public static Grid operator -(double n, Grid grid) => arcpy.sa.Minus(n, grid);
    public static Grid operator -(Grid grid) => arcpy.sa.Minus(0, grid);
    public static Grid operator *(Grid grid1, Grid grid2) => arcpy.sa.Times(grid1, grid2);
    public static Grid operator *(Grid grid, int n) => arcpy.sa.Times(grid, n);
    public static Grid operator *(Grid grid, double n) => arcpy.sa.Times(grid, n);
    public static Grid operator *(int n, Grid grid) => arcpy.sa.Times(n, grid);
    public static Grid operator *(double n, Grid grid) => arcpy.sa.Times(n, grid);
    public static Grid operator /(Grid grid1, Grid grid2) => arcpy.sa.Divide(grid1, grid2);
    public static Grid operator /(Grid grid, int n) => arcpy.sa.Divide(grid, n);
    public static Grid operator /(Grid grid, double n) => arcpy.sa.Divide(grid, n);
    public static Grid operator /(int n, Grid grid) => arcpy.sa.Divide(n, grid);
    public static Grid operator /(double n, Grid grid) => arcpy.sa.Divide(n, grid);
    public static Grid operator %(Grid grid1, Grid grid2) => arcpy.sa.Mod(grid1, grid2);
    public static Grid operator %(Grid grid, int n) => arcpy.sa.Mod(grid, n);
    public static Grid operator %(Grid grid, double n) => arcpy.sa.Mod(grid, n);
    public static Grid operator %(int n, Grid grid) => arcpy.sa.Mod(n, grid);
    public static Grid operator %(double n, Grid grid) => arcpy.sa.Mod(n, grid);
    public static Grid operator ==(Grid grid1, Grid grid2) => arcpy.sa.EqualTo(grid1, grid2);
    public static Grid operator ==(Grid grid, int n) => arcpy.sa.EqualTo(grid, n);
    public static Grid operator ==(Grid grid, double n) => arcpy.sa.EqualTo(grid, n);
    public static Grid operator ==(int n, Grid grid) => arcpy.sa.EqualTo(n, grid);
    public static Grid operator ==(double n, Grid grid) => arcpy.sa.EqualTo(n, grid);
    public static Grid operator !=(Grid grid1, Grid grid2) => arcpy.sa.NotEqual(grid1, grid2);
    public static Grid operator !=(Grid grid, int n) => arcpy.sa.NotEqual(grid, n);
    public static Grid operator !=(Grid grid, double n) => arcpy.sa.NotEqual(grid, n);
    public static Grid operator !=(int n, Grid grid) => arcpy.sa.NotEqual(n, grid);
    public static Grid operator !=(double n, Grid grid) => arcpy.sa.NotEqual(n, grid);
    public static Grid operator >(Grid grid1, Grid grid2) => arcpy.sa.GreaterThan(grid1, grid2);
    public static Grid operator >(Grid grid, int n) => arcpy.sa.GreaterThan(grid, n);
    public static Grid operator >(Grid grid, double n) => arcpy.sa.GreaterThan(grid, n);
    public static Grid operator >(int n, Grid grid) => arcpy.sa.GreaterThan(n, grid);
    public static Grid operator >(double n, Grid grid) => arcpy.sa.GreaterThan(n, grid);
    public static Grid operator <(Grid grid1, Grid grid2) => arcpy.sa.LessThan(grid1, grid2);
    public static Grid operator <(Grid grid, int n) => arcpy.sa.LessThan(grid, n);
    public static Grid operator <(Grid grid, double n) => arcpy.sa.LessThan(grid, n);
    public static Grid operator <(int n, Grid grid) => arcpy.sa.LessThan(n, grid);
    public static Grid operator <(double n, Grid grid) => arcpy.sa.LessThan(n, grid);
    public static Grid operator >=(Grid grid1, Grid grid2) => arcpy.sa.GreaterThanEqual(grid1, grid2);
    public static Grid operator >=(Grid grid, int n) => arcpy.sa.GreaterThanEqual(grid, n);
    public static Grid operator >=(Grid grid, double n) => arcpy.sa.GreaterThanEqual(grid, n);
    public static Grid operator >=(int n, Grid grid) => arcpy.sa.GreaterThanEqual(n, grid);
    public static Grid operator >=(double n, Grid grid) => arcpy.sa.GreaterThanEqual(n, grid);
    public static Grid operator <=(Grid grid1, Grid grid2) => arcpy.sa.LessThanEqual(grid1, grid2);
    public static Grid operator <=(Grid grid, int n) => arcpy.sa.LessThanEqual(grid, n);
    public static Grid operator <=(Grid grid, double n) => arcpy.sa.LessThanEqual(grid, n);
    public static Grid operator <=(int n, Grid grid) => arcpy.sa.LessThanEqual(n, grid);
    public static Grid operator <=(double n, Grid grid) => arcpy.sa.LessThanEqual(n, grid);
    public static Grid operator &(Grid grid1, Grid grid2) => arcpy.sa.BooleanAnd(grid1, grid2);
    public static Grid operator &(Grid grid, int n) => arcpy.sa.BooleanAnd(grid, n);
    public static Grid operator &(Grid grid, double n) => arcpy.sa.BooleanAnd(grid, n);
    public static Grid operator &(int n, Grid grid) => arcpy.sa.BooleanAnd(n, grid);
    public static Grid operator &(double n, Grid grid) => arcpy.sa.BooleanAnd(n, grid);
    public static Grid operator |(Grid grid1, Grid grid2) => arcpy.sa.BooleanOr(grid1, grid2);
    public static Grid operator |(Grid grid, int n) => arcpy.sa.BooleanOr(grid, n);
    public static Grid operator |(Grid grid, double n) => arcpy.sa.BooleanOr(grid, n);
    public static Grid operator |(int n, Grid grid) => arcpy.sa.BooleanOr(n, grid);
    public static Grid operator |(double n, Grid grid) => arcpy.sa.BooleanOr(n, grid);
    public static Grid operator !(Grid grid) => arcpy.sa.BooleanNot(grid);

    #region DotNet Interactive

    static Grid()
    {
        var assembly = AppDomain.CurrentDomain.GetAssemblies()
            .SingleOrDefault(x => x.GetName().Name == "Microsoft.DotNet.Interactive.Formatting");

        if (assembly is null)
            return;

        var method = assembly.GetType("Microsoft.DotNet.Interactive.Formatting.Formatter").GetMethods()
            .Where(x => x.Name == "Register")
            .SingleOrDefault(x => x.GetParameters()
                .Select(y => y.ParameterType)
                .SequenceEqual(new[] { typeof(Type), typeof(Action<object, TextWriter>), typeof(string) }));

        if (method is null)
            return;

        if (arcpy is null)
            ArcPy.Start();

        void Register(Type type)
        {
            Action<object, TextWriter> action = (obj, writer) =>
            {
                var grids = obj switch
                {
                    Grid x => new[] { x },
                    IEnumerable<Grid> x => x.ToArray(),
                    ValueTuple<Grid, Grid> t => new[] { t.Item1, t.Item2 },
                    ValueTuple<Grid, Grid, Grid> t => new[] { t.Item1, t.Item2, t.Item3 },
                    ValueTuple<Grid, Grid, Grid, Grid> t => new[] { t.Item1, t.Item2, t.Item3, t.Item4 },
                    ValueTuple<Grid, Grid, Grid, Grid, Grid> t => new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 },
                    _ => Array.Empty<Grid>()
                };

                writer.Write($"<table><tr>{string.Join("", grids.Select(x => $"<td align=left><p>{x.Description}</p>{x.Thumbnail}</td>"))}</tr></table>");
            };

            method.Invoke(null, new object[] { type, action, "text/html" });
        }

        Register(typeof(Grid));
        Register(typeof(IEnumerable<Grid>));
        Register(typeof(ValueTuple<Grid, Grid>));
        Register(typeof(ValueTuple<Grid, Grid, Grid>));
        Register(typeof(ValueTuple<Grid, Grid, Grid, Grid>));
        Register(typeof(ValueTuple<Grid, Grid, Grid, Grid, Grid>));
    }

    #endregion
}

public class Metadata
{
    public string Id { get; set; } = default!;
    public int BandCount { get; set; }
    public Extent Extent { get; set; } = default!;
    public int Width { get; set; }
    public int Height { get; set; }
    public string PixelType { get; set; } = default!;
    public bool IsInteger { get; set; }
    public double? NoDataValue { get; set; }
    public double? Minimum { get; set; }
    public double? Maximum { get; set; }
    public double? Mean { get; set; }
    public double? StandardDeviation { get; set; }
    public double MeanCellWidth { get; set; }
    public double MeanCellHeight { get; set; }
    public int? Wkid { get; set; }
    public string? Wkt { get; set; }
    public bool HasColormap { get; set; }

    public string Description
    {
        get
        {
            var (min, max) = IsInteger ? ($"{Minimum}", $"{Maximum}") : ($"{Minimum:F6}", $"{Maximum:F6}");

            return $@"{new
            {
                Range = $"{min} ~ {max}",
                Mean = $"{Mean:F6}",
                Size = $"{Width} x {Height}",
                PixelType,
                CellSize = $"{MeanCellWidth:F6}",
                Wkid
            }}";
        }
    }
}

public class Extent
{
    public double Xmin { get; init; }
    public double Ymin { get; init; }
    public double Xmax { get; init; }
    public double Ymax { get; init; }

    public Extent(double xmin, double ymin, double xmax, double ymax)
        => (Xmin, Ymin, Xmax, Ymax) = (xmin, ymin, xmax, ymax);

    public void Deconstruct(out double xmin, out double ymin, out double xmax, out double ymax)
        => (xmin, ymin, xmax, ymax) = (Xmin, Ymin, Xmax, Ymax);

    public override string ToString()
        => $"{Xmin} {Ymin} {Xmax} {Ymax}";
}
