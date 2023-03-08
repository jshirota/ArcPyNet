using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void TestXY()
    {
        using var arcpy = ArcPyNet.ArcPy.Start();
        arcpy.management.CreateFileGDB(arcpy.Workspace, "Test.gdb");
    }
}
