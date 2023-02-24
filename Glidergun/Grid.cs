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
                "ymax": {{variable}}.extent.YMax
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
    public Extent Extent { get; set; } = default!;

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

public class Extent
{
    public double Xmin { get; set; }
    public double Ymin { get; set; }
    public double Xmax { get; set; }
    public double Ymax { get; set; }

    public Extent(double xmin, double ymin, double xmax, double ymax)
        => (Xmin, Ymin, Xmax, Ymax) = (xmin, ymin, xmax, ymax);

    public void Deconstruct(out double xmin, out double ymin, out double xmax, out double ymax)
        => (xmin, ymin, xmax, ymax) = (Xmin, Ymin, Xmax, Ymax);

    public override string ToString()
        => $"{Xmin} {Ymin} {Xmax} {Ymax}";
}
