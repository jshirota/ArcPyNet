using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _GeoAI
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.geoai.{method}", args);
    }

    internal _GeoAI() { }

    public Code ClassifyTextUsingDeepLearning(params object?[] args) => Run(args);
    public Code ExtractEntitiesUsingDeepLearning(params object?[] args) => Run(args);
    public Code ExtractFeaturesUsingAIModels(params object?[] args) => Run(args);
    public Code ForecastUsingTimeSeriesModel(params object?[] args) => Run(args);
    public Code PredictUsingAutoML(params object?[] args) => Run(args);
    public Code TrainEntityRecognitionModel(params object?[] args) => Run(args);
    public Code TrainTextClassificationModel(params object?[] args) => Run(args);
    public Code TrainTextTransformationModel(params object?[] args) => Run(args);
    public Code TrainTimeSeriesForecastingModel(params object?[] args) => Run(args);
    public Code TrainUsingAutoDL(params object?[] args) => Run(args);
    public Code TrainUsingAutoML(params object?[] args) => Run(args);
    public Code TransformTextUsingDeepLearning(params object?[] args) => Run(args);
}
