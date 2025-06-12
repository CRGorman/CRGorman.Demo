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
            VanityURL = "Freespace",
            Acts = new()
            {
                new()
                {
                    Name = "Darkness Rising",
                    ActNumber = 1,
                    Description = "The slog of a 14 year long war comes to a close with the Ross-128 incident.",
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

        Game silentThreat = new()
        {
            Name = "Descent: Freespace - Silent Threat",
            Description = "Boring...",
            VanityURL = "SilentThreat",
            Acts = new()
            {
                new()
                {
                    Name = "Hades Rebellion",
                    ActNumber = 1,
                    Description = "While the Shivans reak havoc upon the galaxy, rogue elements of the GTI seek to disrupt the shakey Terran-Vasudan alliance.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "MD-01",
                            Name = "Silence All Voices",
                            Description = ""
                        }
                    }
                },
            }
        };


        Game operationTemplar = new()
        {
            Name = "Freespace 2 - Operation Templar",
            Description = "Hammer the Hammer of Light",
            VanityURL = "OperationTemplar",
            Acts = new()
            {
                new()
                {
                    Name = "Operation Templar",
                    ActNumber = 1,
                    Description = "As the end of the Lucifier conflict has passed, the GTA seeks to solidify their alliance with the PVE by eliminating the last refuges of the Hammer of Light.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "Templar-01",
                            Name = "Bringing The Hammer Down",
                            Description = ""
                        }
                    }
                },
            }
        };

        Game freespace2 = new()
        {
            Name = "Freespace 2",
            Description = "The Capella Conflict",
            VanityURL = "Freespace2",
            Acts = new()
            {
                new()
                {
                    Name = "The Neo-Terran Front",
                    ActNumber = 1,
                    Description = "32 Years after the end of the great war, elements of the former GTI rebel against the newly forged Galactic Terran Vasudan Alliance while a dormant enemy lies beyond the Capella system.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "SM1-01",
                            Name = "Surrender, Belisarius!",
                            Description = ""
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
                await dbContext.Games.AddAsync(silentThreat, cancellationToken);
                await dbContext.Games.AddAsync(operationTemplar, cancellationToken);
                await dbContext.Games.AddAsync(freespace2, cancellationToken);
                await dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
            });
        }
    }
}
