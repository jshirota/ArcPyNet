using ArcPyNet;
using System.Text.Json;

namespace Glidergun;

public class Grid : Metadata, IVariable
{
    public Variable Variable { get; }

    public Grid(Variable variable)
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

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var metadata = JsonSerializer.Deserialize<Metadata>(result.Json, options)!;

        foreach (var p in typeof(Metadata).GetProperties())
            p.SetValue(this, p.GetValue(metadata));
    }

    public Grid(string name)
        : this(ArcPy.Instance.SpatialAnalyst.Raster(name))
    {
    }

    public static implicit operator Grid(Variable name) => new(name);


    private string thumbnail = default!;
    public string Thumbnail => thumbnail ??= $"<img src='data:image/png;base64, {Convert.ToBase64String(this.GetThumbnail())}' />";

    private byte[] GetThumbnail()
    {
        var fileName = Path.GetTempFileName().Replace(".tmp", "");

        var outputCellSize = this.MeanCellWidth * this.Width / 600;
        var temp = ArcPy.Instance.DataManagement.Resample(this, fileName, outputCellSize);
        var pngFileName = fileName + ".png";

        if (this.HasColormap)
            ArcPy.Instance.DataManagement.CopyRaster(temp, pngFileName, null, null, null, null, "ColormapToRGB", "8_BIT_UNSIGNED", null);
        else
            ArcPy.Instance.DataManagement.CopyRaster(temp, pngFileName, null, null, null, null, null, "8_BIT_UNSIGNED", "ScalePixelValue");

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

    public static Grid operator +(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.Plus(grid1, grid2);
    public static Grid operator +(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.Plus(grid, n);
    public static Grid operator +(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.Plus(grid, n);
    public static Grid operator +(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Plus(n, grid);
    public static Grid operator +(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Plus(n, grid);
    public static Grid operator +(Grid grid) => ArcPy.Instance.SpatialAnalyst.Plus(0, grid);
    public static Grid operator -(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.Minus(grid1, grid2);
    public static Grid operator -(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.Minus(grid, n);
    public static Grid operator -(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.Minus(grid, n);
    public static Grid operator -(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Minus(n, grid);
    public static Grid operator -(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Minus(n, grid);
    public static Grid operator -(Grid grid) => ArcPy.Instance.SpatialAnalyst.Minus(0, grid);
    public static Grid operator *(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.Times(grid1, grid2);
    public static Grid operator *(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.Times(grid, n);
    public static Grid operator *(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.Times(grid, n);
    public static Grid operator *(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Times(n, grid);
    public static Grid operator *(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Times(n, grid);
    public static Grid operator /(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.Divide(grid1, grid2);
    public static Grid operator /(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.Divide(grid, n);
    public static Grid operator /(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.Divide(grid, n);
    public static Grid operator /(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Divide(n, grid);
    public static Grid operator /(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Divide(n, grid);
    public static Grid operator %(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.Mod(grid1, grid2);
    public static Grid operator %(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.Mod(grid, n);
    public static Grid operator %(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.Mod(grid, n);
    public static Grid operator %(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Mod(n, grid);
    public static Grid operator %(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.Mod(n, grid);
    public static Grid operator ==(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.EqualTo(grid1, grid2);
    public static Grid operator ==(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.EqualTo(grid, n);
    public static Grid operator ==(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.EqualTo(grid, n);
    public static Grid operator ==(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.EqualTo(n, grid);
    public static Grid operator ==(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.EqualTo(n, grid);
    public static Grid operator !=(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.NotEqual(grid1, grid2);
    public static Grid operator !=(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.NotEqual(grid, n);
    public static Grid operator !=(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.NotEqual(grid, n);
    public static Grid operator !=(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.NotEqual(n, grid);
    public static Grid operator !=(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.NotEqual(n, grid);
    public static Grid operator >(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.GreaterThan(grid1, grid2);
    public static Grid operator >(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.GreaterThan(grid, n);
    public static Grid operator >(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.GreaterThan(grid, n);
    public static Grid operator >(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.GreaterThan(n, grid);
    public static Grid operator >(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.GreaterThan(n, grid);
    public static Grid operator <(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.LessThan(grid1, grid2);
    public static Grid operator <(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.LessThan(grid, n);
    public static Grid operator <(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.LessThan(grid, n);
    public static Grid operator <(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.LessThan(n, grid);
    public static Grid operator <(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.LessThan(n, grid);
    public static Grid operator >=(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.GreaterThanEqual(grid1, grid2);
    public static Grid operator >=(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.GreaterThanEqual(grid, n);
    public static Grid operator >=(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.GreaterThanEqual(grid, n);
    public static Grid operator >=(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.GreaterThanEqual(n, grid);
    public static Grid operator >=(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.GreaterThanEqual(n, grid);
    public static Grid operator <=(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.LessThanEqual(grid1, grid2);
    public static Grid operator <=(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.LessThanEqual(grid, n);
    public static Grid operator <=(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.LessThanEqual(grid, n);
    public static Grid operator <=(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.LessThanEqual(n, grid);
    public static Grid operator <=(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.LessThanEqual(n, grid);
    public static Grid operator &(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.BooleanAnd(grid1, grid2);
    public static Grid operator &(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.BooleanAnd(grid, n);
    public static Grid operator &(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.BooleanAnd(grid, n);
    public static Grid operator &(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.BooleanAnd(n, grid);
    public static Grid operator &(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.BooleanAnd(n, grid);
    public static Grid operator |(Grid grid1, Grid grid2) => ArcPy.Instance.SpatialAnalyst.BooleanOr(grid1, grid2);
    public static Grid operator |(Grid grid, int n) => ArcPy.Instance.SpatialAnalyst.BooleanOr(grid, n);
    public static Grid operator |(Grid grid, double n) => ArcPy.Instance.SpatialAnalyst.BooleanOr(grid, n);
    public static Grid operator |(int n, Grid grid) => ArcPy.Instance.SpatialAnalyst.BooleanOr(n, grid);
    public static Grid operator |(double n, Grid grid) => ArcPy.Instance.SpatialAnalyst.BooleanOr(n, grid);
    public static Grid operator !(Grid grid) => ArcPy.Instance.SpatialAnalyst.BooleanNot(grid);

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
