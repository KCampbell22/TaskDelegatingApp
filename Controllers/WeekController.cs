using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskDelegatingApp.Controllers
{
    public class WeekController : Controller
    {
        // GET: WeekController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WeekController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WeekController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeekController/Create
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

        // GET: WeekController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WeekController/Edit/5
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

        // GET: WeekController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WeekController/Delete/5
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
