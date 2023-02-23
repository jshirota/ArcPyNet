using Glidergun;

var dem = new Grid("dem.tif");
var shade = (dem > 70) * dem.Hillshade(z_factor: 0.00001);

var temp = Path.GetFileNameWithoutExtension(Path.GetTempFileName());

shade.Save($"{temp}");

ArcPy.Conversion.RasterToASCII(shade, $"{temp}.txt");
