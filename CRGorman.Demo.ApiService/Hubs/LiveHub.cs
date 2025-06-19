using CRGorman.Demo.ApiService.Controllers;
using CRGorman.Demo.ApiService.Hubs.Interface;
using CRGorman.Demo.ApiService.Services;
using CRGorman.Demo.ViewModels;
using Microsoft.AspNetCore.SignalR;

namespace CRGorman.Demo.ApiService.Hubs
{
    public class LiveHub(SpeedrunService speedrunService) : Hub<ILiveHub>
    {
        public async Task JoinLiveGroup() { }

        public async Task LiveUpdate(MissionDto mission)
        {
            await Clients.All.LiveUpdate(mission);
        }
    }
}
