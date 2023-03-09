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
        arcpy.management.CreateFileGDB(arcpy.Workspace, "Test.gdb");
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
}
