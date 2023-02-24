using ArcPy;
using System.Text.Json;
using static ArcPy.SpatialAnalyst;

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

        var result = Engine.Instance.Run(code);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var metadata = JsonSerializer.Deserialize<Metadata>(result.Json, options)!;

        foreach (var p in typeof(Metadata).GetProperties())
            p.SetValue(this, p.GetValue(metadata));
    }

    public Grid(string name)
        : this(Raster(name))
    {
    }

    public static implicit operator Grid(Variable name) => new(name);

    public void Save(string fileName)
    {
        var code = $"""
            {this.Variable}.save(r"{fileName}")
            """;

        Engine.Instance.Run(code);
    }

    public override bool Equals(object? obj)
    {
        return obj is Grid grid && grid.Variable == this.Variable;
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public static Grid operator +(Grid grid1, Grid grid2) => Plus(grid1, grid2);
    public static Grid operator +(Grid grid, int n) => Plus(grid, n);
    public static Grid operator +(Grid grid, double n) => Plus(grid, n);
    public static Grid operator +(int n, Grid grid) => Plus(n, grid);
    public static Grid operator +(double n, Grid grid) => Plus(n, grid);
    public static Grid operator +(Grid grid) => Plus(0, grid);
    public static Grid operator -(Grid grid1, Grid grid2) => Minus(grid1, grid2);
    public static Grid operator -(Grid grid, int n) => Minus(grid, n);
    public static Grid operator -(Grid grid, double n) => Minus(grid, n);
    public static Grid operator -(int n, Grid grid) => Minus(n, grid);
    public static Grid operator -(double n, Grid grid) => Minus(n, grid);
    public static Grid operator -(Grid grid) => Minus(0, grid);
    public static Grid operator *(Grid grid1, Grid grid2) => Times(grid1, grid2);
    public static Grid operator *(Grid grid, int n) => Times(grid, n);
    public static Grid operator *(Grid grid, double n) => Times(grid, n);
    public static Grid operator *(int n, Grid grid) => Times(n, grid);
    public static Grid operator *(double n, Grid grid) => Times(n, grid);
    public static Grid operator /(Grid grid1, Grid grid2) => Divide(grid1, grid2);
    public static Grid operator /(Grid grid, int n) => Divide(grid, n);
    public static Grid operator /(Grid grid, double n) => Divide(grid, n);
    public static Grid operator /(int n, Grid grid) => Divide(n, grid);
    public static Grid operator /(double n, Grid grid) => Divide(n, grid);
    public static Grid operator %(Grid grid1, Grid grid2) => Mod(grid1, grid2);
    public static Grid operator %(Grid grid, int n) => Mod(grid, n);
    public static Grid operator %(Grid grid, double n) => Mod(grid, n);
    public static Grid operator %(int n, Grid grid) => Mod(n, grid);
    public static Grid operator %(double n, Grid grid) => Mod(n, grid);
    public static Grid operator ==(Grid grid1, Grid grid2) => EqualTo(grid1, grid2);
    public static Grid operator ==(Grid grid, int n) => EqualTo(grid, n);
    public static Grid operator ==(Grid grid, double n) => EqualTo(grid, n);
    public static Grid operator ==(int n, Grid grid) => EqualTo(n, grid);
    public static Grid operator ==(double n, Grid grid) => EqualTo(n, grid);
    public static Grid operator !=(Grid grid1, Grid grid2) => NotEqual(grid1, grid2);
    public static Grid operator !=(Grid grid, int n) => NotEqual(grid, n);
    public static Grid operator !=(Grid grid, double n) => NotEqual(grid, n);
    public static Grid operator !=(int n, Grid grid) => NotEqual(n, grid);
    public static Grid operator !=(double n, Grid grid) => NotEqual(n, grid);
    public static Grid operator >(Grid grid1, Grid grid2) => GreaterThan(grid1, grid2);
    public static Grid operator >(Grid grid, int n) => GreaterThan(grid, n);
    public static Grid operator >(Grid grid, double n) => GreaterThan(grid, n);
    public static Grid operator >(int n, Grid grid) => GreaterThan(n, grid);
    public static Grid operator >(double n, Grid grid) => GreaterThan(n, grid);
    public static Grid operator <(Grid grid1, Grid grid2) => LessThan(grid1, grid2);
    public static Grid operator <(Grid grid, int n) => LessThan(grid, n);
    public static Grid operator <(Grid grid, double n) => LessThan(grid, n);
    public static Grid operator <(int n, Grid grid) => LessThan(n, grid);
    public static Grid operator <(double n, Grid grid) => LessThan(n, grid);
    public static Grid operator >=(Grid grid1, Grid grid2) => GreaterThanEqual(grid1, grid2);
    public static Grid operator >=(Grid grid, int n) => GreaterThanEqual(grid, n);
    public static Grid operator >=(Grid grid, double n) => GreaterThanEqual(grid, n);
    public static Grid operator >=(int n, Grid grid) => GreaterThanEqual(n, grid);
    public static Grid operator >=(double n, Grid grid) => GreaterThanEqual(n, grid);
    public static Grid operator <=(Grid grid1, Grid grid2) => LessThanEqual(grid1, grid2);
    public static Grid operator <=(Grid grid, int n) => LessThanEqual(grid, n);
    public static Grid operator <=(Grid grid, double n) => LessThanEqual(grid, n);
    public static Grid operator <=(int n, Grid grid) => LessThanEqual(n, grid);
    public static Grid operator <=(double n, Grid grid) => LessThanEqual(n, grid);
    public static Grid operator &(Grid grid1, Grid grid2) => BooleanAnd(grid1, grid2);
    public static Grid operator &(Grid grid, int n) => BooleanAnd(grid, n);
    public static Grid operator &(Grid grid, double n) => BooleanAnd(grid, n);
    public static Grid operator &(int n, Grid grid) => BooleanAnd(n, grid);
    public static Grid operator &(double n, Grid grid) => BooleanAnd(n, grid);
    public static Grid operator |(Grid grid1, Grid grid2) => BooleanOr(grid1, grid2);
    public static Grid operator |(Grid grid, int n) => BooleanOr(grid, n);
    public static Grid operator |(Grid grid, double n) => BooleanOr(grid, n);
    public static Grid operator |(int n, Grid grid) => BooleanOr(n, grid);
    public static Grid operator |(double n, Grid grid) => BooleanOr(n, grid);
    public static Grid operator !(Grid grid) => BooleanNot(grid);
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
