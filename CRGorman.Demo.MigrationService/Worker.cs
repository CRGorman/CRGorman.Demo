using CRGorman.Demo.SpeedrunData;
using CRGorman.Demo.SpeedrunData.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CRGorman.Demo.MigrationService;

public class Worker(IServiceProvider serviceProvider,
    IHostApplicationLifetime hostApplicationLifetime) : BackgroundService
{
    public const string ActivitySourceName = "Migrations";
    private static readonly ActivitySource s_activitySource = new(ActivitySourceName);

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        using var activity = s_activitySource.StartActivity("Migrating database", ActivityKind.Client);

        try
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<SpeedrunContext>();

            await RunMigrationAsync(dbContext, cancellationToken);
            await SeedDataAsync(dbContext, cancellationToken);
        }
        catch (Exception ex)
        {
            activity?.AddException(ex);
            throw;
        }

        hostApplicationLifetime.StopApplication();
    }

    private static async Task RunMigrationAsync(SpeedrunContext dbContext, CancellationToken cancellationToken)
    {
        var strategy = dbContext.Database.CreateExecutionStrategy();
        await strategy.ExecuteAsync(async () =>
        {
            // Run migration in a transaction to avoid partial migration if it fails.
            await dbContext.Database.MigrateAsync(cancellationToken);
        });
    }

    private static async Task SeedDataAsync(SpeedrunContext dbContext, CancellationToken cancellationToken)
    {
        Game freespace = new()
        {
            Name = "Descent: Freespace - The Great War",
            Description = "Starting somewhere",
            Acts = new()
            {
                new()
                {
                    Name = "Darkness Rising",
                    Description = "The slog of a 14 year long war comes to a close at the hands of the destroyers.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "SM1-01A",
                            Name = "Eve of Destruction",
                            Description = "Thirteen 35% PVF Anubis fighters pick a fight with two fresh GTF Apollos and a stationary GTF Fenris."
                        }
                    }
                },
            }
        };

        var strategy = dbContext.Database.CreateExecutionStrategy();
        bool seeded = false;
        await strategy.ExecuteAsync(async () =>
        {
            await using var transaction = await dbContext.Database.BeginTransactionAsync(cancellationToken);
            seeded = await dbContext.Games.AnyAsync(x => x.Id >= 1);
        });

        if (!seeded)
        {
            await strategy.ExecuteAsync(async () =>
            {
                // Seed the database
                await using var transaction = await dbContext.Database.BeginTransactionAsync(cancellationToken);
                await dbContext.Games.AddAsync(freespace, cancellationToken);
                await dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
            });
        }
    }
}
