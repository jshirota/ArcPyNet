using ArcPyNet;

namespace Glidergun;

public class Grid : Metadata, IVariable
{
    public Code Variable { get; }

    public Grid(Code variable)
    {
        this.Variable = variable;

        var code = $$"""
            {
                "bandCount": {{variable}}.bandCount,
                "width": {{variable}}.width,
                "height": {{variable}}.height,
                "pixelType": {{variable}}.pixelType,
                "isInteger": {{variable}}.isInteger,
                "noDataValue": {{variable}}.noDataValue,
                "minimum": {{variable}}.minimum,
                "maximum": {{variable}}.maximum,
                "mean": {{variable}}.mean,
                "standardDeviation": {{variable}}.standardDeviation,
                "meanCellWidth": {{variable}}.meanCellWidth,
                "meanCellHeight": {{variable}}.meanCellHeight,
                "wkid": {{variable}}.spatialReference.factoryCode,
                "wkt": {{variable}}.spatialReference.exportToString(),
                "xmin": {{variable}}.extent.XMin,
                "ymin": {{variable}}.extent.YMin,
                "xmax": {{variable}}.extent.XMax,
                "ymax": {{variable}}.extent.YMax,
                "hasColormap": hasattr(arcpy.sa.Raster, "getColormap") and {{variable}}.getColormap("") is not None
            }
            """;

        var result = ArcPy.Instance.Run(code);
        var metadata = result.Evaluate<Metadata>();

        foreach (var p in typeof(Metadata).GetProperties())
            p.SetValue(this, p.GetValue(metadata));
    }

    public Grid(string name)
        : this(ArcPy.Instance.sa.Raster(name))
    {
    }

    public static implicit operator Grid(Code name) => new(name);


    private string thumbnail = default!;
    public string Thumbnail => thumbnail ??= $"<img src='data:image/png;base64, {Convert.ToBase64String(this.GetThumbnail())}' />";

    private byte[] GetThumbnail()
    {
        var fileName = Path.GetTempFileName().Replace(".tmp", "");

        var outputCellSize = this.MeanCellWidth * this.Width / 600;
        var temp = ArcPy.Instance.management.Resample(this, fileName, outputCellSize);
        var pngFileName = fileName + ".png";

        if (this.HasColormap)
            ArcPy.Instance.management.CopyRaster(temp, pngFileName, null, null, null, null, "ColormapToRGB", "8_BIT_UNSIGNED", null);
        else
            ArcPy.Instance.management.CopyRaster(temp, pngFileName, null, null, null, null, null, "8_BIT_UNSIGNED", "ScalePixelValue");

        return File.ReadAllBytes(pngFileName);
    }

    public void Save(string fileName)
    {
        var code = $"""
            {this.Variable}.save(r"{fileName}")
            """;

        ArcPy.Instance.Run(code);
    }

    public override bool Equals(object? obj)
    {
        return obj is Grid grid && grid.Variable == this.Variable;
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public static Grid operator +(Grid grid1, Grid grid2) => ArcPy.Instance.sa.Plus(grid1, grid2);
    public static Grid operator +(Grid grid, int n) => ArcPy.Instance.sa.Plus(grid, n);
    public static Grid operator +(Grid grid, double n) => ArcPy.Instance.sa.Plus(grid, n);
    public static Grid operator +(int n, Grid grid) => ArcPy.Instance.sa.Plus(n, grid);
    public static Grid operator +(double n, Grid grid) => ArcPy.Instance.sa.Plus(n, grid);
    public static Grid operator +(Grid grid) => ArcPy.Instance.sa.Plus(0, grid);
    public static Grid operator -(Grid grid1, Grid grid2) => ArcPy.Instance.sa.Minus(grid1, grid2);
    public static Grid operator -(Grid grid, int n) => ArcPy.Instance.sa.Minus(grid, n);
    public static Grid operator -(Grid grid, double n) => ArcPy.Instance.sa.Minus(grid, n);
    public static Grid operator -(int n, Grid grid) => ArcPy.Instance.sa.Minus(n, grid);
    public static Grid operator -(double n, Grid grid) => ArcPy.Instance.sa.Minus(n, grid);
    public static Grid operator -(Grid grid) => ArcPy.Instance.sa.Minus(0, grid);
    public static Grid operator *(Grid grid1, Grid grid2) => ArcPy.Instance.sa.Times(grid1, grid2);
    public static Grid operator *(Grid grid, int n) => ArcPy.Instance.sa.Times(grid, n);
    public static Grid operator *(Grid grid, double n) => ArcPy.Instance.sa.Times(grid, n);
    public static Grid operator *(int n, Grid grid) => ArcPy.Instance.sa.Times(n, grid);
    public static Grid operator *(double n, Grid grid) => ArcPy.Instance.sa.Times(n, grid);
    public static Grid operator /(Grid grid1, Grid grid2) => ArcPy.Instance.sa.Divide(grid1, grid2);
    public static Grid operator /(Grid grid, int n) => ArcPy.Instance.sa.Divide(grid, n);
    public static Grid operator /(Grid grid, double n) => ArcPy.Instance.sa.Divide(grid, n);
    public static Grid operator /(int n, Grid grid) => ArcPy.Instance.sa.Divide(n, grid);
    public static Grid operator /(double n, Grid grid) => ArcPy.Instance.sa.Divide(n, grid);
    public static Grid operator %(Grid grid1, Grid grid2) => ArcPy.Instance.sa.Mod(grid1, grid2);
    public static Grid operator %(Grid grid, int n) => ArcPy.Instance.sa.Mod(grid, n);
    public static Grid operator %(Grid grid, double n) => ArcPy.Instance.sa.Mod(grid, n);
    public static Grid operator %(int n, Grid grid) => ArcPy.Instance.sa.Mod(n, grid);
    public static Grid operator %(double n, Grid grid) => ArcPy.Instance.sa.Mod(n, grid);
    public static Grid operator ==(Grid grid1, Grid grid2) => ArcPy.Instance.sa.EqualTo(grid1, grid2);
    public static Grid operator ==(Grid grid, int n) => ArcPy.Instance.sa.EqualTo(grid, n);
    public static Grid operator ==(Grid grid, double n) => ArcPy.Instance.sa.EqualTo(grid, n);
    public static Grid operator ==(int n, Grid grid) => ArcPy.Instance.sa.EqualTo(n, grid);
    public static Grid operator ==(double n, Grid grid) => ArcPy.Instance.sa.EqualTo(n, grid);
    public static Grid operator !=(Grid grid1, Grid grid2) => ArcPy.Instance.sa.NotEqual(grid1, grid2);
    public static Grid operator !=(Grid grid, int n) => ArcPy.Instance.sa.NotEqual(grid, n);
    public static Grid operator !=(Grid grid, double n) => ArcPy.Instance.sa.NotEqual(grid, n);
    public static Grid operator !=(int n, Grid grid) => ArcPy.Instance.sa.NotEqual(n, grid);
    public static Grid operator !=(double n, Grid grid) => ArcPy.Instance.sa.NotEqual(n, grid);
    public static Grid operator >(Grid grid1, Grid grid2) => ArcPy.Instance.sa.GreaterThan(grid1, grid2);
    public static Grid operator >(Grid grid, int n) => ArcPy.Instance.sa.GreaterThan(grid, n);
    public static Grid operator >(Grid grid, double n) => ArcPy.Instance.sa.GreaterThan(grid, n);
    public static Grid operator >(int n, Grid grid) => ArcPy.Instance.sa.GreaterThan(n, grid);
    public static Grid operator >(double n, Grid grid) => ArcPy.Instance.sa.GreaterThan(n, grid);
    public static Grid operator <(Grid grid1, Grid grid2) => ArcPy.Instance.sa.LessThan(grid1, grid2);
    public static Grid operator <(Grid grid, int n) => ArcPy.Instance.sa.LessThan(grid, n);
    public static Grid operator <(Grid grid, double n) => ArcPy.Instance.sa.LessThan(grid, n);
    public static Grid operator <(int n, Grid grid) => ArcPy.Instance.sa.LessThan(n, grid);
    public static Grid operator <(double n, Grid grid) => ArcPy.Instance.sa.LessThan(n, grid);
    public static Grid operator >=(Grid grid1, Grid grid2) => ArcPy.Instance.sa.GreaterThanEqual(grid1, grid2);
    public static Grid operator >=(Grid grid, int n) => ArcPy.Instance.sa.GreaterThanEqual(grid, n);
    public static Grid operator >=(Grid grid, double n) => ArcPy.Instance.sa.GreaterThanEqual(grid, n);
    public static Grid operator >=(int n, Grid grid) => ArcPy.Instance.sa.GreaterThanEqual(n, grid);
    public static Grid operator >=(double n, Grid grid) => ArcPy.Instance.sa.GreaterThanEqual(n, grid);
    public static Grid operator <=(Grid grid1, Grid grid2) => ArcPy.Instance.sa.LessThanEqual(grid1, grid2);
    public static Grid operator <=(Grid grid, int n) => ArcPy.Instance.sa.LessThanEqual(grid, n);
    public static Grid operator <=(Grid grid, double n) => ArcPy.Instance.sa.LessThanEqual(grid, n);
    public static Grid operator <=(int n, Grid grid) => ArcPy.Instance.sa.LessThanEqual(n, grid);
    public static Grid operator <=(double n, Grid grid) => ArcPy.Instance.sa.LessThanEqual(n, grid);
    public static Grid operator &(Grid grid1, Grid grid2) => ArcPy.Instance.sa.BooleanAnd(grid1, grid2);
    public static Grid operator &(Grid grid, int n) => ArcPy.Instance.sa.BooleanAnd(grid, n);
    public static Grid operator &(Grid grid, double n) => ArcPy.Instance.sa.BooleanAnd(grid, n);
    public static Grid operator &(int n, Grid grid) => ArcPy.Instance.sa.BooleanAnd(n, grid);
    public static Grid operator &(double n, Grid grid) => ArcPy.Instance.sa.BooleanAnd(n, grid);
    public static Grid operator |(Grid grid1, Grid grid2) => ArcPy.Instance.sa.BooleanOr(grid1, grid2);
    public static Grid operator |(Grid grid, int n) => ArcPy.Instance.sa.BooleanOr(grid, n);
    public static Grid operator |(Grid grid, double n) => ArcPy.Instance.sa.BooleanOr(grid, n);
    public static Grid operator |(int n, Grid grid) => ArcPy.Instance.sa.BooleanOr(n, grid);
    public static Grid operator |(double n, Grid grid) => ArcPy.Instance.sa.BooleanOr(n, grid);
    public static Grid operator !(Grid grid) => ArcPy.Instance.sa.BooleanNot(grid);

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

        if (ArcPy.Instance is null)
            ArcPy.Start();

        void Register(Type type)
        {
            Action<object, TextWriter> action = (obj, writer) =>
            {
                var grids = obj switch
                {
                    Grid r => new[] { r },
                    IEnumerable<Grid> r => r.ToArray(),
                    ValueTuple<Grid, Grid> t => new[] { t.Item1, t.Item2 },
                    ValueTuple<Grid, Grid, Grid> t => new[] { t.Item1, t.Item2, t.Item3 },
                    ValueTuple<Grid, Grid, Grid, Grid> t => new[] { t.Item1, t.Item2, t.Item3, t.Item4 },
                    ValueTuple<Grid, Grid, Grid, Grid, Grid> t => new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 },
                    _ => Array.Empty<Grid>()
                };

                writer.Write($"<table><tr>{string.Join("", grids.Select(r => $"<td align=left><p>{r}</p>{r.Thumbnail}</td>"))}</tr></table>");
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
    public double Xmin { get; set; }
    public double Ymin { get; set; }
    public double Xmax { get; set; }
    public double Ymax { get; set; }
    public bool HasColormap { get; set; }

    public override string ToString()
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
