using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _LinearReferencing
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.lr.{method}", args);
    }

    public Variable CalibrateRoutes(params object?[] args) => Run(args);
    public Variable CreateRoutes(params object?[] args) => Run(args);
    public Variable DissolveRouteEvents(params object?[] args) => Run(args);
    public Variable LocateFeaturesAlongRoutes(params object?[] args) => Run(args);
    public Variable MakeRouteEventLayer(params object?[] args) => Run(args);
    public Variable OverlayRouteEvents(params object?[] args) => Run(args);
    public Variable TransformRouteEvents(params object?[] args) => Run(args);
}
