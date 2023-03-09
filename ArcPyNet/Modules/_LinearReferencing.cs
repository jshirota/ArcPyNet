using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _LinearReferencing
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.lr.{method}", args);
    }

    public Code CalibrateRoutes(params object?[] args) => Run(args);
    public Code CreateRoutes(params object?[] args) => Run(args);
    public Code DissolveRouteEvents(params object?[] args) => Run(args);
    public Code LocateFeaturesAlongRoutes(params object?[] args) => Run(args);
    public Code MakeRouteEventLayer(params object?[] args) => Run(args);
    public Code OverlayRouteEvents(params object?[] args) => Run(args);
    public Code TransformRouteEvents(params object?[] args) => Run(args);
}
