using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class _WorkflowManager
{
    internal _WorkflowManager() { }
}

public static class _WorkflowManagerExt
{
    private static Code Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.wmx.{method}", args);
    }

    public static Code ClearJobReplicationInfo(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code Connect(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code CreateJobDataReplica(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code CreateJobs(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code CreateNewJobs(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code CreateWorkflowDatabase(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code ExportJobData(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code GetJobAOI(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code GetJobDataWorkspace(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code GetJobParentVersion(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code GetJobVersion(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code ImportJobData(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code PostJobVersion(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code PublishWorkflowService(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code SynchronizeJobData(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code UpgradeWorkflowDatabase(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code WorkflowExecutionError(this _WorkflowManager _, params object?[] args) => Run(args);
    public static Code WorkflowExecutionStepError(this _WorkflowManager _, params object?[] args) => Run(args);
}
