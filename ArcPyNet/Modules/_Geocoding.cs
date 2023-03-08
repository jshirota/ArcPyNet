using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _Geocoding
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.geocoding.{method}", args);
    }

    public Variable AssignZonesToStreets(params object?[] args) => Run(args);
    public Variable ClipLocator(params object?[] args) => Run(args);
    public Variable ConsolidateLocator(params object?[] args) => Run(args);
    public Variable CreateCompositeAddressLocator(params object?[] args) => Run(args);
    public Variable CreateFeatureLocator(params object?[] args) => Run(args);
    public Variable CreateLocator(params object?[] args) => Run(args);
    public Variable GeocodeAddresses(params object?[] args) => Run(args);
    public Variable GeocodeFile(params object?[] args) => Run(args);
    public Variable GeocodeLocationsFromTable(params object?[] args) => Run(args);
    public Variable Locator(params object?[] args) => Run(args);
    public Variable PackageLocator(params object?[] args) => Run(args);
    public Variable RebuildAddressLocator(params object?[] args) => Run(args);
    public Variable RematchAddresses(params object?[] args) => Run(args);
    public Variable ReverseGeocode(params object?[] args) => Run(args);
    public Variable SplitAddressIntoComponents(params object?[] args) => Run(args);
}
