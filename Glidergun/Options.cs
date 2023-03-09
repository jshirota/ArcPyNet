using ArcPyNet;
using System.Runtime.CompilerServices;

namespace Glidergun;

public abstract class Option
{
    public string Function { get; init; } = default!;
    public object?[] Arguments { get; init; } = default!;

    protected Option(object?[] arguments, string function)
    {
        Function = function;
        Arguments = arguments;
    }

    protected Option() { }

    public override string ToString()
    {
        return $@"arcpy.sa.{this.Function}({string.Join(", ", this.Arguments.Select(ArcPy.Format))})";
    }
}

public class Fuzzy : Option
{
    private Fuzzy(object?[] arguments, [CallerMemberName] string function = null!)
        : base(arguments, $"Fuzzy{function}") { }

    public Fuzzy() { }

    public static Fuzzy Gaussian(double midpoint, double spread = 0.1)
        => new(new object?[] { midpoint, spread });

    public static Fuzzy Large(double midpoint, double spread = 5)
        => new(new object?[] { midpoint, spread });

    public static Fuzzy Linear(double minimum, double maximum)
        => new(new object?[] { minimum, maximum });

    public static Fuzzy MSLarge(double meanMultiplier = 1, double STDMultiplier = 1)
        => new(new object?[] { meanMultiplier, STDMultiplier });

    public static Fuzzy MSSmall(double meanMultiplier = 1, double STDMultiplier = 1)
        => new(new object?[] { meanMultiplier, STDMultiplier });

    public static Fuzzy Near(double midpoint, double spread = 0.1)
        => new(new object?[] { midpoint, spread });

    public static Fuzzy Small(double midpoint, double spread = 5)
        => new(new object?[] { midpoint, spread });
}

public class Hf : Option
{
    private Hf(object?[] arguments, [CallerMemberName] string function = null!)
        : base(arguments, $"Hf{function}") { }

    public Hf() { }

    public static Hf Binary(double zeroFactor, double cutAngle)
        => new(new object?[] { zeroFactor, cutAngle });

    public static Hf Forward(double zeroFactor, double sideValue)
        => new(new object?[] { zeroFactor, sideValue });

    public static Hf Linear(double zeroFactor, double cutAngle, double slope)
        => new(new object?[] { zeroFactor, cutAngle, slope });

    public static Hf InverseLinear(double zeroFactor, double cutAngle, double slope)
        => new(new object?[] { zeroFactor, cutAngle, slope });

    public static Hf Table(string inTable)
        => new(new object?[] { inTable });
}

public class KrigingModel : Option
{
    private KrigingModel(object?[] arguments, [CallerMemberName] string function = null!)
        : base(arguments, $"KrigingModel{function}") { }

    public KrigingModel() { }

    public static KrigingModel Ordinary(OrdinarySemivariogram semivariogramType, double lagSize, double majorRange, double partialSill, double nugget)
        => new(new object?[] { semivariogramType, lagSize, majorRange, partialSill, nugget });

    public static KrigingModel Universal(UniversalSemivariogram semivariogramType, double lagSize, double majorRange, double partialSill, double nugget)
        => new(new object?[] { semivariogramType, lagSize, majorRange, partialSill, nugget });
}

public class Nbr : Option
{
    private const NeighborhoodUnit Cell = NeighborhoodUnit.Cell;

    private Nbr(object?[] arguments, [CallerMemberName] string function = null!)
        : base(arguments, $"Nbr{function}") { }

    public Nbr() { }

    public static Nbr Annulus(int innerRadius, int outerRadius, NeighborhoodUnit unit = Cell)
        => new(new object?[] { innerRadius, outerRadius, unit });

    public static Nbr Circle(int radius, NeighborhoodUnit unit = Cell)
        => new(new object?[] { radius, unit });

    public static Nbr Rectangle(int width, int height, NeighborhoodUnit unit = Cell)
        => new(new object?[] { width, height, unit });

    public static Nbr Wedge(int radius, int startAngle, int endAngle, NeighborhoodUnit unit = Cell)
        => new(new object?[] { radius, startAngle, endAngle, unit });

    public static Nbr Irregular(string inKernelFile)
        => new(new object?[] { inKernelFile });

    public static Nbr Weight(string inKernelFile)
        => new(new object?[] { inKernelFile });
}

public class Radius : Option
{
    private Radius(object?[] arguments, [CallerMemberName] string function = null!)
        : base(arguments, $"Radius{function}") { }

    public Radius() { }

    public static Radius Variable(int numberofPoints = 12, double? maxDistance = null)
        => new(new object?[] { numberofPoints, maxDistance });

    public static Radius Fixed(double? distance = null, int minNumberofPoints = 0)
        => new(new object?[] { distance, minNumberofPoints });
}

public class Remap : Option
{
    private Remap(object?[] arguments, [CallerMemberName] string function = null!)
        : base(arguments, $"Remap{function}") { }

    public Remap() { }

    public static Remap Range(params (double startValue, double endValue, int newValue)[] remapTable)
        => new(new[] { remapTable.Select(x => new object?[] { x.startValue, x.endValue, x.newValue }).ToArray() });

    public static Remap Value(params (double oldValue, int newValue)[] remapTable)
        => new(new[] { remapTable.Select(x => new object?[] { x.oldValue, x.newValue }).ToArray() });

    public static Remap Value(params (int oldValue, int newValue)[] remapTable)
        => new(new[] { remapTable.Select(x => new object?[] { x.oldValue, x.newValue }).ToArray() });

    public static Remap Value(params (string oldValue, int newValue)[] remapTable)
        => new(new[] { remapTable.Select(x => new object?[] { x.oldValue, x.newValue }).ToArray() });
}

public class Tf : Option
{
    private Tf(object?[] arguments, [CallerMemberName] string function = null!)
        : base(arguments, $"Tf{function}") { }

    public Tf() { }

    public static Tf Exponential(double? shift = null, double? baseFactor = null, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { shift, baseFactor, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf Gaussian(double? midpoint = null, double? spread = null, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { midpoint, spread, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf Large(double? midpoint = null, double spread = 5, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { midpoint, spread, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf Linear(double? minimum = null, double? maximum = null, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { minimum, maximum, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf Logarithm(double? shift = null, double? factor = null, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { shift, factor, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf LogisticDecay(double? minimum = null, double? maximum = null, double yInterceptPercent = 99, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { minimum, maximum, yInterceptPercent, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf LogisticGrowth(double? minimum = null, double? maximum = null, double yInterceptPercent = 1, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { minimum, maximum, yInterceptPercent, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf MSLarge(double meanMultiplier = 1, double STDMultiplier = 1, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { meanMultiplier, STDMultiplier, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf MSSmall(double meanMultiplier = 1, double STDMultiplier = 1, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { meanMultiplier, STDMultiplier, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf Near(double? midpoint = null, double? spread = null, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { midpoint, spread, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf Power(double? shift = null, double? exponent = null, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { shift, exponent, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf Small(double? midpoint = null, double spread = 5, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { midpoint, spread, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });

    public static Tf SymmetricLinear(double? minimum = null, double? maximum = null, double? lowerThreshold = null, double? valueBelowThreshold = null, double? upperThreshold = null, double? valueAboveThreshold = null)
        => new(new object?[] { minimum, maximum, lowerThreshold, valueBelowThreshold, upperThreshold, valueAboveThreshold });
}

public class Time : Option
{
    private Time(object?[] arguments, [CallerMemberName] string function = null!)
       : base(arguments, $"Time{function}") { }

    public Time() { }

    public static Time WithinDay(int day, double startTime, double endTime)
        => new(new object?[] { day, startTime, endTime });

    public static Time MultipleDays(int year, int startDay, int endDay)
        => new(new object?[] { year, startDay, endDay });

    public static Time SpecialDays()
        => new(Array.Empty<object?>());

    public static Time WholeYear(int year)
        => new(new object?[] { year });
}

public class Topo : Option
{
    private Topo(object?[] arguments, [CallerMemberName] string function = null!)
       : base(arguments, $"Topo{function}") { }

    public Topo() { }

    public static Topo PointElevation(params (FilePath featureClass, string field)[] featureClasses)
        => new(new object?[] { featureClasses });

    public static Topo Contour(params (FilePath featureClass, string field)[] featureClasses)
        => new(new object?[] { featureClasses });

    public static Topo Stream(params FilePath[] featureClasses)
        => new(new object?[] { featureClasses });

    public static Topo Sink(params (FilePath featureClass, string field)[] featureClasses)
        => new(new object?[] { featureClasses });

    public static Topo Boundary(params string[] featureClasses)
        => new(new object?[] { featureClasses });

    public static Topo Lake(params string[] featureClasses)
        => new(new object?[] { featureClasses });

    public static Topo Cliff(params string[] featureClasses)
        => new(new object?[] { featureClasses });

    public static Topo Exclusion(params string[] featureClasses)
        => new(new object?[] { featureClasses });

    public static Topo Coast(params string[] featureClasses)
        => new(new object?[] { featureClasses });
}

public class Vf : Option
{
    private Vf(object?[] arguments, [CallerMemberName] string function = null!)
       : base(arguments, $"Vf{function}") { }

    public Vf() { }

    public static Vf Binary(double zeroFactor, double lowCutAngle, double highCutAngle)
        => new(new object?[] { zeroFactor, lowCutAngle, highCutAngle });

    public static Vf Linear(double zeroFactor, double lowCutAngle, double highCutAngle, double slope)
        => new(new object?[] { zeroFactor, lowCutAngle, highCutAngle, slope });

    public static Vf InverseLinear(double zeroFactor, double lowCutAngle, double highCutAngle, double slope)
        => new(new object?[] { zeroFactor, lowCutAngle, highCutAngle, slope });

    public static Vf SymLinear(double zeroFactor, double lowCutAngle, double highCutAngle, double slope)
        => new(new object?[] { zeroFactor, lowCutAngle, highCutAngle, slope });

    public static Vf SymInverseLinear(double zeroFactor, double lowCutAngle, double highCutAngle, double slope)
        => new(new object?[] { zeroFactor, lowCutAngle, highCutAngle, slope });

    public static Vf Cos(double lowCutAngle, double highCutAngle, double cosPower)
        => new(new object?[] { lowCutAngle, highCutAngle, cosPower });

    public static Vf Sec(double lowCutAngle, double highCutAngle, double secPower)
        => new(new object?[] { lowCutAngle, highCutAngle, secPower });

    public static Vf CosSec(double lowCutAngle, double highCutAngle, double cosPower, double secPower)
        => new(new object?[] { lowCutAngle, highCutAngle, cosPower, secPower });

    public static Vf SecCos(double lowCutAngle, double highCutAngle, double secPower, double cosPower)
        => new(new object?[] { lowCutAngle, highCutAngle, secPower, cosPower });

    public static Vf Table(FilePath inTable)
        => new(new object?[] { inTable });
}
