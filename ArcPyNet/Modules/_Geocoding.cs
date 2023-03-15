using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Geocoding
{
    internal _Geocoding() { }
}

public static class _GeocodingExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.geocoding.{method}", args);
    }

    public static Code AssignZonesToStreets(this _Geocoding _, params object?[] args) => Run(args);
    public static Code ClipLocator(this _Geocoding _, params object?[] args) => Run(args);
    public static Code ConsolidateLocator(this _Geocoding _, params object?[] args) => Run(args);
    public static Code CreateCompositeAddressLocator(this _Geocoding _, params object?[] args) => Run(args);
    public static Code CreateFeatureLocator(this _Geocoding _, params object?[] args) => Run(args);
    public static Code CreateLocator(this _Geocoding _, params object?[] args) => Run(args);
    public static Code GeocodeAddresses(this _Geocoding _, params object?[] args) => Run(args);
    public static Code GeocodeFile(this _Geocoding _, params object?[] args) => Run(args);
    public static Code GeocodeLocationsFromTable(this _Geocoding _, params object?[] args) => Run(args);
    public static Code Locator(this _Geocoding _, params object?[] args) => Run(args);
    public static Code PackageLocator(this _Geocoding _, params object?[] args) => Run(args);
    public static Code RebuildAddressLocator(this _Geocoding _, params object?[] args) => Run(args);
    public static Code RematchAddresses(this _Geocoding _, params object?[] args) => Run(args);
    public static Code ReverseGeocode(this _Geocoding _, params object?[] args) => Run(args);
    public static Code SplitAddressIntoComponents(this _Geocoding _, params object?[] args) => Run(args);
}
