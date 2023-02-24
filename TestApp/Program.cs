using ArcPyNet;
using Glidergun;

using var arcpy = ArcPy.Start($"{DateTime.Now:yyyy-MM-dd-HH-mm-ss}");

var dem = new Grid("dem.tif");
var shade = (dem > 70) * dem.Hillshade(z_factor: 0.00001);

shade.Save("hillshade");

Console.WriteLine(shade);
