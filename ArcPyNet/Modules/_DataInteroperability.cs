using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _DataInteroperability
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.interop.{method}", args);
    }

    internal _DataInteroperability() { }

    public Code QuickExport(params object?[] args) => Run(args);
    public Code QuickImport(params object?[] args) => Run(args);
}
