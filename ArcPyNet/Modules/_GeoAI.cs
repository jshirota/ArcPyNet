using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _GeoAI
{
    internal _GeoAI() { }
}

public static class _GeoAIExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.geoai.{method}", args);
    }

    public static Code ClassifyTextUsingDeepLearning(this _GeoAI _, params object?[] args) => Run(args);
    public static Code ExtractEntitiesUsingDeepLearning(this _GeoAI _, params object?[] args) => Run(args);
    public static Code ExtractFeaturesUsingAIModels(this _GeoAI _, params object?[] args) => Run(args);
    public static Code ForecastUsingTimeSeriesModel(this _GeoAI _, params object?[] args) => Run(args);
    public static Code PredictUsingAutoML(this _GeoAI _, params object?[] args) => Run(args);
    public static Code TrainEntityRecognitionModel(this _GeoAI _, params object?[] args) => Run(args);
    public static Code TrainTextClassificationModel(this _GeoAI _, params object?[] args) => Run(args);
    public static Code TrainTextTransformationModel(this _GeoAI _, params object?[] args) => Run(args);
    public static Code TrainTimeSeriesForecastingModel(this _GeoAI _, params object?[] args) => Run(args);
    public static Code TrainUsingAutoDL(this _GeoAI _, params object?[] args) => Run(args);
    public static Code TrainUsingAutoML(this _GeoAI _, params object?[] args) => Run(args);
    public static Code TransformTextUsingDeepLearning(this _GeoAI _, params object?[] args) => Run(args);
}
