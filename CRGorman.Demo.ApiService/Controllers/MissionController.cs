using CRGorman.Demo.ApiService.Services;
using CRGorman.Demo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRGorman.Demo.ApiService.Controllers;

[Route("[controller]")]
public class MissionController(SpeedrunService speedrunService, IDistributedCache distributedCache) : BaseController
{
    // GET: MissionController
    [HttpGet("{id?}")]
    public async Task<ActionResult> GetAsync(int? id)
    {
        if (id.HasValue)
        {
            string cacheKey = $"Mission_{id.Value.ToString()}";
            MissionDto retVal;
            var cached = await distributedCache.GetStringAsync(cacheKey);
            if (cached == null)
            {
                retVal = await speedrunService.GetMission(id.Value);
                distributedCache.SetStringAsync(cacheKey, JsonSerializer.Serialize(retVal));
            }
            else
            {
                retVal = JsonSerializer.Deserialize<MissionDto>(cached);
            }
            return Ok(retVal);
        }
        else
        {
            return Ok(await speedrunService.GetTableOfContentsAsync());
        }
    }

    // POST: MissionController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return NotFound();
        }
    }

    // POST: MissionController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Delete(int id)
    {
        try
        {
            //No need for a real delete command.
            //return Ok(await speedrunService.DeleteMission(id));
            return Ok();
        }
        catch
        {
            return NotFound();
        }
    }
}
