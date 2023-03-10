using Glidergun;

using var arcpy = ArcPyNet.ArcPy.Start();

var dem = new Grid("dem.tif");

var shade = (dem > 70) * dem.Hillshade(zFactor: 0.00001);

shade.Save("hillshade");

Console.WriteLine(shade);
