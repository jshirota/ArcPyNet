using Glidergun;

using var arcpy = ArcPyNet.ArcPy.Start();

//var landsat = new Grid("landsat.img");

var dem = new Grid("dem.tif");

var shade = (dem > 70) * dem.Hillshade(zFactor: 0.00001);

Console.WriteLine(shade.Description);
