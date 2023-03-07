﻿using Python.Runtime;

namespace ArcPyNet;

public class ArcPy : IDisposable
{
    public static ArcPy Instance { get; private set; } = default!;

    public string Workspace { get; }
    private bool disposed;

    public static ArcPy Start(string? workspace = null, string pythonHome = @"C:\Program Files\ArcGIS\Pro\bin\Python\envs\arcgispro-py3")
    {
        Console.Write("Starting ArcPy...");

        if (Instance is null || Instance.disposed)
            Instance = new ArcPy(workspace ?? Path.GetDirectoryName(Path.GetTempFileName()), pythonHome);

        Instance.Run("None");

        Console.WriteLine("  Started.");

        return Instance;
    }

    private ArcPy(string workspace, string pythonHome)
    {
        this.Workspace = Path.GetFullPath(workspace);

        if (!Directory.Exists(this.Workspace))
            Directory.CreateDirectory(this.Workspace);

        Runtime.PythonDLL = Directory.GetFiles(pythonHome, "python*.dll").Last();
        PythonEngine.PythonHome = pythonHome;
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

    public Analysis Analysis = new();
    public Cartography Cartography = new();
    public Conversion Conversion = new();
    public DataInteroperability DataInteroperability = new();
    public DataManagement DataManagement = new();
    public GeoAI GeoAI = new();
    public GeostatisticalAnalyst GeostatisticalAnalyst = new();
    public Intelligence Intelligence = new();
    public LinearReferencing LinearReferencing = new();
    public RasterAnalysis RasterAnalysis = new();
    public SpatialAnalyst SpatialAnalyst = new();
    public SpatialStatistics SpatialStatistics = new();
    public WorkflowManager WorkflowManager = new();
}
