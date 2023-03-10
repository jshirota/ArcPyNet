using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _WorkflowManager
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.wmx.{method}", args);
    }

    internal _WorkflowManager() { }

    public Code ClearJobReplicationInfo(params object?[] args) => Run(args);
    public Code Connect(params object?[] args) => Run(args);
    public Code CreateJobDataReplica(params object?[] args) => Run(args);
    public Code CreateJobs(params object?[] args) => Run(args);
    public Code CreateNewJobs(params object?[] args) => Run(args);
    public Code CreateWorkflowDatabase(params object?[] args) => Run(args);
    public Code ExportJobData(params object?[] args) => Run(args);
    public Code GetJobAOI(params object?[] args) => Run(args);
    public Code GetJobDataWorkspace(params object?[] args) => Run(args);
    public Code GetJobParentVersion(params object?[] args) => Run(args);
    public Code GetJobVersion(params object?[] args) => Run(args);
    public Code ImportJobData(params object?[] args) => Run(args);
    public Code PostJobVersion(params object?[] args) => Run(args);
    public Code PublishWorkflowService(params object?[] args) => Run(args);
    public Code SynchronizeJobData(params object?[] args) => Run(args);
    public Code UpgradeWorkflowDatabase(params object?[] args) => Run(args);
    public Code WorkflowExecutionError(params object?[] args) => Run(args);
    public Code WorkflowExecutionStepError(params object?[] args) => Run(args);
}
