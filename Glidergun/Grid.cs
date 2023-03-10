using ArcPyNet;

namespace Glidergun;

public class Grid : Metadata
{
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

        var result = ArcPy.Instance.Run(code);
        var metadata = result.Evaluate<Metadata>();

        foreach (var p in typeof(Metadata).GetProperties())
            if (p.CanWrite)
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
        var code = $"""{this.Name}.save(r"{fileName}")""";

        ArcPy.Instance.Run(code);
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
