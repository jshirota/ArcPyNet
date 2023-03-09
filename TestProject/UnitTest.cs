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
    public void management_CreateFileGDB()
    {
        arcpy.management.CreateFileGDB(arcpy.Workspace, "Test.gdb");
    }

    [TestMethod]
    public void _Compute()
    {
        for (var i = 0; i < 100; i++)
        {
            var result = arcpy.Run($"{i} * 2");
            Assert.AreEqual(i * 2, result.GetValue<int>());
        }
    }
}
