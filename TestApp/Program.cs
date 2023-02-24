using ArcPy;
using Glidergun;

using var engine = Engine.Start($"{DateTime.Now:yyyy-MM-dd-HH-mm-ss}");

var dem = new Grid("dem.tif");
var shade = (dem > 70) * dem.Hillshade(z_factor: 0.00001);

shade.Save("hillshade");

Console.WriteLine(shade);
