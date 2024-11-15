using NCronJob;
using NCronJobBugDemo1.Jobs;

namespace NCronJobBugDemo1;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IRuntimeJobRegistry _runtimeJobRegistry;

    public Worker(ILogger<Worker> logger, IRuntimeJobRegistry runtimeJobRegistry)
    {
        _logger = logger;
        _runtimeJobRegistry = runtimeJobRegistry;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _runtimeJobRegistry.AddJob(n =>
        {
            n.AddJob<XJob>(j => j.WithCronExpression("* * * * *"));
        });
        
        _runtimeJobRegistry.AddJob(n =>
        {
            n.AddJob<YJob>(j => j.WithCronExpression("0,15,30,45 * * * *"));
        });

        return Task.CompletedTask;
    }
}