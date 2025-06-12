using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Data;
using System.Diagnostics;

var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql").WithLifetime(ContainerLifetime.Session);

var db = sql.AddDatabase("speedrun");

builder.AddProject<Projects.CRGorman_Demo_MigrationService>("migrations").WithReference(db).WaitFor(db);

var cache = builder.AddRedis("cache").WithRedisInsight();

var apiService = builder.AddProject<Projects.CRGorman_Demo_ApiService>("apiservice").WithReference(db).WaitFor(db);
apiService.WithCommand(
    "swagger-ui-docs",
    "Swagger UI",
    executeCommand: async _ =>
    {
        try
        {
            var endpoint = apiService.GetEndpoint("https");
            var url = $"{endpoint.Url}/swagger";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            return new ExecuteCommandResult { Success = true };
        }
        catch (Exception ex)
        {
            return new ExecuteCommandResult { Success = false, ErrorMessage = ex.Message };
        }
    },
    commandOptions: new()
    {
        UpdateState = context => context.ResourceSnapshot.HealthStatus == HealthStatus.Healthy ? ResourceCommandState.Enabled : ResourceCommandState.Disabled,
        IconName = "Document",
        IconVariant = IconVariant.Filled
    });

builder.AddProject<Projects.CRGorman_Demo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
