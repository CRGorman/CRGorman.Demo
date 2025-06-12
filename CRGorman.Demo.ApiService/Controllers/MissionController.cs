using CRGorman.Demo.ApiService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using System.Threading.Tasks;

namespace CRGorman.Demo.ApiService.Controllers;

[Route("[controller]")]
public class MissionController(SpeedrunService speedrunService) : BaseController
{
    // GET: MissionController
    [OutputCache]
    [HttpGet]
    public async Task<ActionResult> GetAsync(int? id)
    {
        if (id.HasValue)
        {
            return Ok(await speedrunService.GetMission(id.Value));
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
}
