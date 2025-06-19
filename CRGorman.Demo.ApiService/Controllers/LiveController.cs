using CRGorman.Demo.ApiService.Hubs;
using CRGorman.Demo.ApiService.Hubs.Interface;
using CRGorman.Demo.ApiService.Services;
using CRGorman.Demo.SpeedrunData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CRGorman.Demo.ApiService.Controllers;

[Route("[controller]")]
public class LiveController(SpeedrunService speedrunService, IHubContext<LiveHub, ILiveHub> hubContext) : BaseController
{
    [HttpPost]
    public async Task<IActionResult> LiveUpdate(string missionName)
    {
        var currentMission = await speedrunService.GetMission(missionName);
        await hubContext.Clients.All.LiveUpdate(currentMission);
        return Ok(currentMission);
    }
}
