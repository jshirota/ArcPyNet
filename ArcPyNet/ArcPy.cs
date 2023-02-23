using Python.Runtime;

namespace ArcPyNet;

public static class ArcPy
{
    /// <summary>
    /// Defaults to C:\Program Files\ArcGIS\Pro\bin\Python\envs\arcgispro-py3.
    /// </summary>
    public static string PythonHome { get; set; } = @"C:\Program Files\ArcGIS\Pro\bin\Python\envs\arcgispro-py3";

    /// <summary>
    /// Defaults to C:\Program Files\ArcGIS\Pro\Resources\ArcPy.
    /// </summary>
    public static string ArcPyFolder { get; set; } = @"C:\Program Files\ArcGIS\Pro\Resources\ArcPy";

    internal static void Run(string code)
    {
        if (!PythonEngine.IsInitialized)
        {
            Runtime.PythonDLL = Directory.GetFiles(PythonHome, "python*.dll").Last();
            PythonEngine.PythonHome = PythonHome;
            PythonEngine.Initialize();

            using (Py.GIL())
                PythonEngine.RunSimpleString($"""
                    import arcpy
                    """);
        }

        using (Py.GIL())
            PythonEngine.RunSimpleString(code);

        PythonEngine.Shutdown();
    }

    internal static string GetTempName()
    {
        return "_" + Guid.NewGuid().ToString().Substring(0, 7);
    }

    internal static string Format(object?[] args)
    {
        return string.Join(", ", args.Select(x => x switch
        {
            null => "None",
            Variable name => name,
            string s => $@"r""{s}""",
            _ => x
        })); ;
    }
}
