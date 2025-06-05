using Microsoft.AspNetCore.Mvc;

namespace CRGorman.Demo.ApiService.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
