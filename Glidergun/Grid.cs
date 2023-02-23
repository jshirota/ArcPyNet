using ArcPy;
using static ArcPy.SpatialAnalyst;

namespace Glidergun;

public class Grid
{
    private readonly Variable name;

    public Grid(Variable name)
    {
        this.name = name;
    }

    public Grid(string name)
    {
        this.name = Raster(name);
    }

    public static implicit operator Grid(Variable name) => new(name);
    public static implicit operator Variable(Grid grid) => grid.name;

    public void Save(string fileName)
    {
        var code = $"""
            {this.name}.save(r"{fileName}")
            """;

        Engine.Run(code);
    }

    public byte[] GetThumbnail()
    {
        var fileName = Path.GetTempFileName().Replace(".tmp", "");

        var temp = DataManagement.Resample(this, fileName, "0.001");
        var pngFileName = fileName + ".png";

        DataManagement.CopyRaster(temp,
            pngFileName, null, null, null, null,
             "ColormapToRGB",
             "8_BIT_UNSIGNED");

        return File.ReadAllBytes(pngFileName);
    }

    public override bool Equals(object? obj)
    {
        return obj is Grid grid && grid.name == this.name;
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public override string ToString()
    {
        return this.name.ToString();
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
