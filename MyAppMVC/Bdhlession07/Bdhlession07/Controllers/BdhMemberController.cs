using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Bdhlession07.Controllers
{
    public class BdhMemberController : Controller
    {
        public IActionResult BdhIndex()
        {
            return View();
        }
        // GET: TvcMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TvcMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TvcMemberController/Create
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

        // GET: TvcMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TvcMemberController/Edit/5
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

        // GET: TvcMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TvcMemberController/Delete/5
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
