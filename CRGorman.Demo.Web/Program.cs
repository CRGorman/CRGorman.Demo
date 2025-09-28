using CRGorman.Demo.Web;
using CRGorman.Demo.Web.Components;
using CRGorman.Demo.Web.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();
builder.AddRedisOutputCache("cache");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient<GuideApiClient>(client =>
{
    // This URL uses "https+http://" to indicate HTTPS is preferred over HTTP.
    // Learn more about service discovery scheme resolution at https://aka.ms/dotnet/sdschemes.
    client.BaseAddress = new("https+http://apiservice");
});

builder.Services.AddHttpClient<TableOfContents>(client =>
{
    // This URL uses "https+http://" to indicate HTTPS is preferred over HTTP.
    // Learn more about service discovery scheme resolution at https://aka.ms/dotnet/sdschemes.
    client.BaseAddress = new("https+http://apiservice");
});

#region HubBuilder
var hubBuilder = new HubConnectionBuilder()
      .WithUrl(new Uri("https+http://apiservice/livehub"))
      .WithAutomaticReconnect();
var url = builder.Configuration.GetValue<string>("services:apiservice:https:0"); // We need to pull this as the hub builder does not recognize the base address settings. See: https://github.com/dotnet/aspire/issues/1356#issuecomment-1853158142
#endregion

builder.Services.AddSingleton<HubConnection>(client =>
{
    return new HubConnectionBuilder()
      .WithUrl(new Uri(url + "/livehub"))
      .WithAutomaticReconnect()
      .Build();
}).AddServiceDiscovery();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.UseOutputCache();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapDefaultEndpoints();

app.Run();
