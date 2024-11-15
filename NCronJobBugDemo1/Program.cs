using NCronJob;
using NCronJobBugDemo1;
using NCronJobBugDemo1.Jobs;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddNCronJob(b => b
    .AddJob<XJob>()
    .AddJob<YJob>()
);

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();