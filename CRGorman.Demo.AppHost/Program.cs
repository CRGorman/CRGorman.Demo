var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql", port: 49155).WithLifetime(ContainerLifetime.Persistent);

var db = sql.AddDatabase("speedrun");

builder.AddProject<Projects.CRGorman_Demo_MigrationService>("migrations").WithReference(db).WaitFor(db);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.CRGorman_Demo_ApiService>("apiservice").WithReference(db).WaitFor(db);

builder.AddProject<Projects.CRGorman_Demo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
