using NCronJob;

namespace NCronJobBugDemo1.Jobs;

public class YJob : IJob
{
    public Task RunAsync(IJobExecutionContext context, CancellationToken token)
    {
        Console.WriteLine("Job Y was executed.");
        return Task.CompletedTask;
    }
}