using CRGorman.Demo.MigrationService;
using CRGorman.Demo.SpeedrunData;

var builder = Host.CreateApplicationBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddHostedService<Worker>();

builder.Services.AddOpenTelemetry()
    .WithTracing(tracing => tracing.AddSource(Worker.ActivitySourceName));
builder.Services.AddOpenTelemetry().WithTracing(tracing => tracing.AddSource(Worker.ActivitySourceName));
builder.AddSqlServerDbContext<SpeedrunContext>(connectionName: "speedrun");

var host = builder.Build();
host.Run();
