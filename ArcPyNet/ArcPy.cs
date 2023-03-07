using Python.Runtime;

namespace ArcPyNet;

public class ArcPy : IDisposable
{
    private const string defaultPythonHome = @"C:\Program Files\ArcGIS\Pro\bin\Python\envs\arcgispro-py3";

    public static ArcPy Instance { get; private set; } = default!;

    public string Workspace { get; }
    private bool disposed;

    public static ArcPy Start(string? workspace = null, string? pythonHome = defaultPythonHome)
    {
        if (Instance is null || Instance.disposed)
            Instance = new ArcPy(workspace, pythonHome);

        Instance.Run("None");

        return Instance;
    }

    private ArcPy(string? workspace, string? pythonHome)
    {
        if (string.IsNullOrEmpty(workspace))
            workspace = Path.GetDirectoryName(Path.GetTempFileName());

        this.Workspace = Path.GetFullPath(workspace);

        if (!Directory.Exists(this.Workspace))
            Directory.CreateDirectory(this.Workspace);

        if (string.IsNullOrEmpty(pythonHome))
            pythonHome = defaultPythonHome;

        Runtime.PythonDLL = Directory.GetFiles(pythonHome, "python*.dll").Last();
        PythonEngine.PythonHome = pythonHome!;
        PythonEngine.Initialize();
    }

    public Variable Run(string preprocess, string expression)
    {
        var temp = GetTempName();
        var jsonPath = $@"{this.Workspace}\{temp}.json";

        string code;

        using (Py.GIL())
        {
            code = $"""
                    import arcpy
                    import json

                    arcpy.env.workspace = r"{this.Workspace}"

                    {preprocess}

                    {temp} = {expression}

                    with open(r"{jsonPath}", "w") as json_file:
                        json_file.write(json.dumps({temp}, default=str))
                    """;

            PythonEngine.RunSimpleString(code);
        }

        return temp;
    }

    public Variable Run(string expression)
    {
        return this.Run("", expression);
    }

    internal Variable Run(string method, object?[] args)
    {
        return this.Run($"{method}({Format(args)})");
    }

    public static string GetTempName()
    {
        return "_" + Guid.NewGuid().ToString().Substring(0, 7);
    }

    private static string Format(object?[] args)
    {
        return string.Join(", ", args.Select(x => x switch
        {
            null => "None",
            IVariable variable => variable.Variable,
            string s => $@"r""{s}""",
            _ => x
        }));
    }

    public void Dispose()
    {
        PythonEngine.Shutdown();

        this.disposed = true;
    }

    public _3DAnalyst ddd = new();
    public _Analysis analysis = new();
    public _Cartography cartography = new();
    public _Conversion conversion = new();
    public _DataInteroperability interop = new();
    public _DataManagement management = new();
    public _GeoAI geoai = new();
    public _GeostatisticalAnalyst ga = new();
    public _Intelligence intelligence = new();
    public _LinearReferencing lr = new();
    public _RasterAnalysis ra = new();
    public _SpatialAnalyst sa = new();
    public _SpatialStatistics stats = new();
    public _WorkflowManager wmx = new();
}
