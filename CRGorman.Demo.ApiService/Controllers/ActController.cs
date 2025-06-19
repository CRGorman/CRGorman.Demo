using CRGorman.Demo.ApiService.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRGorman.Demo.ApiService.Controllers;

[Route("[controller]")]
public class ActController(SpeedrunService speedrunService) : BaseController
{
    // GET: Act/5
    [HttpGet("{id}")]
    public async Task<ActionResult> GetAsync(int id)
    {
        return Ok(await speedrunService.GetAct(id));
    }
}
