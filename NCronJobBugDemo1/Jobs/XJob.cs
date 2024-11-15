using NCronJob;

namespace NCronJobBugDemo1.Jobs;

public class XJob : IJob
{
    public Task RunAsync(IJobExecutionContext context, CancellationToken token)
    {
        Console.WriteLine("Job X was executed.");
        return Task.CompletedTask;
    }
}