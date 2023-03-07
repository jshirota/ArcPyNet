using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class GeoAI
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.geoai.{method}", args);
    }

    public Variable ClassifyTextUsingDeepLearning(params object?[] args) => Run(args);
    public Variable ExtractEntitiesUsingDeepLearning(params object?[] args) => Run(args);
    public Variable ExtractFeaturesUsingAIModels(params object?[] args) => Run(args);
    public Variable ForecastUsingTimeSeriesModel(params object?[] args) => Run(args);
    public Variable PredictUsingAutoML(params object?[] args) => Run(args);
    public Variable TrainEntityRecognitionModel(params object?[] args) => Run(args);
    public Variable TrainTextClassificationModel(params object?[] args) => Run(args);
    public Variable TrainTextTransformationModel(params object?[] args) => Run(args);
    public Variable TrainTimeSeriesForecastingModel(params object?[] args) => Run(args);
    public Variable TrainUsingAutoDL(params object?[] args) => Run(args);
    public Variable TrainUsingAutoML(params object?[] args) => Run(args);
    public Variable TransformTextUsingDeepLearning(params object?[] args) => Run(args);
}
