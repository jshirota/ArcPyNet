using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class DataInteroperability
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.interop.{method}", args);
    }

    public Variable QuickExport(params object?[] args) => Run(args);
    public Variable QuickImport(params object?[] args) => Run(args);
}
