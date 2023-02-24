using Python.Runtime;

namespace ArcPyNet;

public class ArcPy : IDisposable
{
    public static ArcPy Instance { get; private set; } = default!;

    private readonly string workspace;
    private bool disposed;

    public static ArcPy Start(string? workspace = null, string pythonHome = @"C:\Program Files\ArcGIS\Pro\bin\Python\envs\arcgispro-py3")
    {
        if (Instance is null || Instance.disposed)
            Instance = new ArcPy(workspace ?? Environment.CurrentDirectory, pythonHome);

        Instance.Run("None");

        return Instance;
    }

    private ArcPy(string workspace, string pythonHome)
    {
        this.workspace = Path.GetFullPath(workspace);

        if (!Directory.Exists(this.workspace))
            Directory.CreateDirectory(this.workspace);

        Runtime.PythonDLL = Directory.GetFiles(pythonHome, "python*.dll").Last();
        PythonEngine.PythonHome = pythonHome;
        PythonEngine.Initialize();
    }

    public Variable Run(string expression)
    {
        var temp = GetTempName();
        var jsonPath = $@"{this.workspace}\{temp}.json";

        using (Py.GIL())
        {
            var code = $"""
                    import arcpy
                    import json

                    arcpy.env.workspace = r"{this.workspace}"

                    {temp} = {expression}

                    with open(r"{jsonPath}", "w") as json_file:
                        json_file.write(json.dumps({temp}, default=str))

                    """;

            PythonEngine.RunSimpleString(code);
        }

        var json = File.ReadAllText(jsonPath);

        return new Variable(temp, json);
    }

    internal Variable Run(string method, object?[] args)
    {
        return this.Run($"{method}({Format(args)})");
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

    public Analysis Analysis = new();
    public Conversion Conversion = new();
    public DataManagement DataManagement = new();
    public GeostatisticalAnalyst GeostatisticalAnalyst = new();
    public SpatialAnalyst SpatialAnalyst = new();
    public SpatialStatistics SpatialStatistics = new();
}
