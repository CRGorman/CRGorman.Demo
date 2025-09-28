using CRGorman.Demo.ViewModels;
using CRGorman.Demo.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CRGorman.Demo.Tests
{
    [TestClass]
    public class GuideApiTests
    {
        [TestMethod]
        public async Task CanGetTableOfContents()
        {
            //Arrange
            var appHost =
                await DistributedApplicationTestingBuilder.CreateAsync<Projects.CRGorman_Demo_AppHost>();
            appHost.Services.ConfigureHttpClientDefaults(clientBuilder =>
            {
                clientBuilder.AddStandardResilienceHandler();
            });

            await using var app = await appHost.BuildAsync();
            await app.StartAsync();

            var resourceNotificationService =
                app.Services.GetRequiredService<ResourceNotificationService>();
            await resourceNotificationService
                    .WaitForResourceAsync("apiservice", KnownResourceStates.Running)
                    .WaitAsync(TimeSpan.FromSeconds(300));

            //Act
            var httpClient = app.CreateHttpClient("apiservice");
            var response = await httpClient.GetAsync("/mission");

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var contents = await response.Content.ReadFromJsonAsync<IEnumerable<TableOfContentsDto>>();
            Assert.IsNotNull(contents);
            Assert.AreEqual(4, contents.Count());
        }

        [TestMethod]
        public async Task CanCacheMission()
        {
            //Arrange
            var appHost =
                await DistributedApplicationTestingBuilder.CreateAsync<Projects.CRGorman_Demo_AppHost>();
            appHost.Services.ConfigureHttpClientDefaults(clientBuilder =>
            {
                clientBuilder.AddStandardResilienceHandler();
            });

            await using var app = await appHost.BuildAsync();
            await app.StartAsync();

            var resourceNotificationService =
                app.Services.GetRequiredService<ResourceNotificationService>();
            await resourceNotificationService
                    .WaitForResourceAsync("apiservice", KnownResourceStates.Running)
                    .WaitAsync(TimeSpan.FromSeconds(300));

            //Act
            var httpClient = app.CreateHttpClient("apiservice");
            var response = await httpClient.GetAsync("/mission/");
            response = await httpClient.GetAsync("/mission/");

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var contents = await response.Content.ReadFromJsonAsync<IEnumerable<TableOfContentsDto>>();
            Assert.IsNotNull(contents);
            Assert.AreEqual(4, contents.Count());
        }
    }
}
