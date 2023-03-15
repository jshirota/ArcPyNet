using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _LinearReferencing
{
    internal _LinearReferencing() { }
}

public static class _LinearReferencingExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.lr.{method}", args);
    }

    public static Code CalibrateRoutes(this _LinearReferencing _, params object?[] args) => Run(args);
    public static Code CreateRoutes(this _LinearReferencing _, params object?[] args) => Run(args);
    public static Code DissolveRouteEvents(this _LinearReferencing _, params object?[] args) => Run(args);
    public static Code LocateFeaturesAlongRoutes(this _LinearReferencing _, params object?[] args) => Run(args);
    public static Code MakeRouteEventLayer(this _LinearReferencing _, params object?[] args) => Run(args);
    public static Code OverlayRouteEvents(this _LinearReferencing _, params object?[] args) => Run(args);
    public static Code TransformRouteEvents(this _LinearReferencing _, params object?[] args) => Run(args);
}
