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

    public static string Workspace { get; set; } = Environment.CurrentDirectory;

    public static Variable Run(string code)
    {
        Runtime.PythonDLL = Directory.GetFiles(PythonHome, "python*.dll").Last();
        PythonEngine.PythonHome = PythonHome;
        PythonEngine.Initialize();

        var temp = GetTempName();

        using (Py.GIL())
        {
            PythonEngine.RunSimpleString($"""
                    import arcpy
                    arcpy.env.workspace = r"{Workspace}"
                    {temp} = {code}
                    """);
        }

        PythonEngine.Shutdown();

        return temp;
    }

    public static Variable Run(string method, object?[] args)
    {
        return Run($"{method}({Format(args)})");
    }

    private static string GetTempName()
    {
        return "_" + Guid.NewGuid().ToString().Substring(0, 7);
    }

    private static string Format(object?[] args)
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
