using System.Runtime.CompilerServices;

namespace ArcPyNet;

public class WorkflowManager
{
    private static Variable Run(object?[] args, [CallerMemberName] string method = "")
    {
        return ArcPy.Instance.Run($"arcpy.wmx.{method}", args);
    }

    public Variable ClearJobReplicationInfo(params object?[] args) => Run(args);
    public Variable Connect(params object?[] args) => Run(args);
    public Variable CreateJobDataReplica(params object?[] args) => Run(args);
    public Variable CreateJobs(params object?[] args) => Run(args);
    public Variable CreateNewJobs(params object?[] args) => Run(args);
    public Variable CreateWorkflowDatabase(params object?[] args) => Run(args);
    public Variable ExportJobData(params object?[] args) => Run(args);
    public Variable GetJobAOI(params object?[] args) => Run(args);
    public Variable GetJobDataWorkspace(params object?[] args) => Run(args);
    public Variable GetJobParentVersion(params object?[] args) => Run(args);
    public Variable GetJobVersion(params object?[] args) => Run(args);
    public Variable ImportJobData(params object?[] args) => Run(args);
    public Variable PostJobVersion(params object?[] args) => Run(args);
    public Variable PublishWorkflowService(params object?[] args) => Run(args);
    public Variable SynchronizeJobData(params object?[] args) => Run(args);
    public Variable UpgradeWorkflowDatabase(params object?[] args) => Run(args);
    public Variable WorkflowExecutionError(params object?[] args) => Run(args);
    public Variable WorkflowExecutionStepError(params object?[] args) => Run(args);
}
