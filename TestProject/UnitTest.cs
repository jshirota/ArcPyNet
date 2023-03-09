using ArcPyNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject;

[TestClass]
public class UnitTest
{
    private static ArcPy arcpy = default!;

    [ClassInitialize]
    public static void Init(TestContext _)
    {
        arcpy = ArcPy.Start();
    }

    [TestMethod]
    public void CreateFileGDB()
    {
        arcpy.management.CreateFileGDB(arcpy.Workspace, "Test1.gdb");
    }

    [TestMethod]
    public void CreateFeatureclass()
    {
        var gdb = "Test2.gdb";
        var fc = "City";
        var gdb_path = $@"{arcpy.Workspace}\{gdb}";
        arcpy.management.CreateFileGDB(arcpy.Workspace, gdb);
        arcpy.management.CreateFeatureclass(gdb_path, fc, "POINT", null, "DISABLED", "DISABLED", (Code)"arcpy.SpatialReference(4326)");

        var fields = new[]
        {
            (name: "Name", type: "TEXT", length: 255),
            (name: "Population", type: "LONG", length: 0),
        };

        var code = $"[{string.Join(",", fields.Select(x
            => $"""["{x.name}","{x.type}","{x.name}",255]"""))}]";

        arcpy.management.AddFields($@"{gdb_path}\{fc}", (Code)code);
    }

    record Cat(string Name, int Age);

    [TestMethod]
    public void Evaluate1()
    {
        Assert.AreEqual("Hello 123", ((Code)"'Hello 123'").Evaluate<string>());
        Assert.AreEqual(new Cat("Ben", 1), ((Code)"{'name':'Ben','age':1}").Evaluate<Cat>());
    }

    [TestMethod]
    public void Evaluate2()
    {
        for (var i = 0; i < 100; i++)
        {
            var result = arcpy.Run($"{i} * 2");
            Assert.AreEqual(i * 2, result.Evaluate<int>());
        }
    }

    [TestMethod]
    public void Evaluate3()
    {
        Code code = "arcpy.SpatialReference(4326).exportToString()";
        var wkt = """GEOGCS["GCS_WGS_1984",DATUM["D_WGS_1984",SPHEROID["WGS_1984",6378137.0,298.257223563]],PRIMEM["Greenwich",0.0],UNIT["Degree",0.0174532925199433]];-400 -400 1000000000;-100000 10000;-100000 10000;8.98315284119521E-09;0.001;0.001;IsHighPrecision""";

        Assert.AreEqual(wkt, code.Evaluate<string>());
    }
}
