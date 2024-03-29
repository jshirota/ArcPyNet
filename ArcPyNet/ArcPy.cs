﻿using Python.Runtime;
using System.Collections;
using System.ComponentModel;

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

        return Instance;
    }

    private ArcPy(string? workspace, string? pythonHome)
    {
        if (string.IsNullOrEmpty(workspace))
            workspace = Path.GetTempFileName().Replace(".tmp", "");

        this.Workspace = Path.GetFullPath(workspace);

        if (!Directory.Exists(this.Workspace))
            Directory.CreateDirectory(this.Workspace);

        if (string.IsNullOrEmpty(pythonHome))
            pythonHome = defaultPythonHome;

        Runtime.PythonDLL = Directory.GetFiles(pythonHome, "python*.dll").Last();
        PythonEngine.PythonHome = pythonHome!;
        PythonEngine.Initialize();

        this.Run("None");
    }

    public Code Run(string preprocess, string expression)
    {
        var temp = GetTempName();
        var errorPath = $@"{this.Workspace}\{temp}.error";

        string code;

        using (Py.GIL())
        {
            // Indent.
            preprocess = string.Join("\n", preprocess.Split('\n').Select(x => $"    {x}"));

            code = $"""
                try:
                    import arcpy
                    import json

                    arcpy.env.workspace = r"{this.Workspace}"

                    {preprocess.TrimStart()}

                    {temp} = {expression}

                except Exception as exception:
                    with open(r"{errorPath}", "w") as error_file:
                        error_file.write(str(exception))
                """;

            PythonEngine.RunSimpleString(code);
        }

        if (File.Exists(errorPath))
            throw new InvalidOperationException(File.ReadAllText(errorPath));

        return temp;
    }

    public Code Run(string expression)
    {
        return this.Run("", expression);
    }

    public Code Run(string method, object?[] args)
    {
        return this.Run($"{method}({string.Join(", ", args.Select(Format))})");
    }

    public static string GetTempName()
    {
        return "_" + Guid.NewGuid().ToString().Substring(0, 7);
    }

    public static string Format(object? value)
    {
        return value switch
        {
            null => "None",
            Enum @enum => $@"r""{ToEnumString(@enum)}""",
            double or float => $"float({value})",
            string s => $@"r""{s}""",
            IEnumerable values => $"[{string.Join(", ", values.Cast<object>().Select(Format))}]",
            _ => value.ToString()
        };
    }

    private static string ToEnumString<T>(T @enum) where T : Enum
    {
        var attribute = @enum
            .GetType()
            .GetMember(@enum.ToString())
            .Single()
            .GetCustomAttributes(false)
            .OfType<DescriptionAttribute>()
            .SingleOrDefault();

        if (attribute is null)
            return @enum.ToString();

        return attribute.Description;
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
    public _Geocoding geocoding = new();
    public _GeostatisticalAnalyst ga = new();
    public _Intelligence intelligence = new();
    public _LinearReferencing lr = new();
    public _RasterAnalysis ra = new();
    public _SpatialAnalyst sa = new();
    public _SpatialStatistics stats = new();
    public _WorkflowManager wmx = new();
}
