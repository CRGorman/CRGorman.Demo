using AutoMapper;
using CRGorman.Demo.ApiService;
using CRGorman.Demo.ApiService.Hubs;
using CRGorman.Demo.ApiService.Services;
using CRGorman.Demo.SpeedrunData;
using CRGorman.Demo.SpeedrunData.Models;
using CRGorman.Demo.ViewModels;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

builder.AddSqlServerDbContext<SpeedrunContext>(connectionName: "speedrun");

#region Mapper Configurations
//var mapperConfig = new MapperConfiguration(config => config.AddProfile<MapperProfile>());
builder.Services.AddAutoMapper(typeof(MapperProfile));
#endregion

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.AddScoped<SpeedrunService>();

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();
app.MapHub<LiveHub>("/livehub");

app.UseSwaggerUI(options => { options.SwaggerEndpoint("/openapi/v1.json", "OpenAPI V1"); });

if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<SpeedrunContext>();
        context.Database.EnsureCreated();
    }
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days.
    // You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Run();
