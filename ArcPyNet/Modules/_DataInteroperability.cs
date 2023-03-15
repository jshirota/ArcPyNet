using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _DataInteroperability
{
    internal _DataInteroperability() { }
}

public static class _DataInteroperabilityExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.interop.{method}", args);
    }

    public static Code QuickExport(this _DataInteroperability _, params object?[] args) => Run(args);
    public static Code QuickImport(this _DataInteroperability _, params object?[] args) => Run(args);
}
