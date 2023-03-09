using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Geocoding
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.geocoding.{method}", args);
    }

    public Code AssignZonesToStreets(params object?[] args) => Run(args);
    public Code ClipLocator(params object?[] args) => Run(args);
    public Code ConsolidateLocator(params object?[] args) => Run(args);
    public Code CreateCompositeAddressLocator(params object?[] args) => Run(args);
    public Code CreateFeatureLocator(params object?[] args) => Run(args);
    public Code CreateLocator(params object?[] args) => Run(args);
    public Code GeocodeAddresses(params object?[] args) => Run(args);
    public Code GeocodeFile(params object?[] args) => Run(args);
    public Code GeocodeLocationsFromTable(params object?[] args) => Run(args);
    public Code Locator(params object?[] args) => Run(args);
    public Code PackageLocator(params object?[] args) => Run(args);
    public Code RebuildAddressLocator(params object?[] args) => Run(args);
    public Code RematchAddresses(params object?[] args) => Run(args);
    public Code ReverseGeocode(params object?[] args) => Run(args);
    public Code SplitAddressIntoComponents(params object?[] args) => Run(args);
}
