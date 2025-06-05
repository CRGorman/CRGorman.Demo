using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRGorman.Demo.ApiService.Controllers
{
    public class ActController : Controller
    {
        // GET: ActController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ActController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActController/Create
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
                return View();
            }
        }

        // GET: ActController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActController/Edit/5
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
                return View();
            }
        }

        // GET: ActController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
