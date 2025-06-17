using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLAB05.Models;
using System.Text.RegularExpressions;

namespace NetCoreMVCLAB05.Controllers
{
    public class BdhAccountController : Controller
    {
        // GET: BdhAccountController
        public ActionResult BdhIndex()
        {
            List<BdhAccount> BdhAccounts = new List<BdhAccount>();
            return View(BdhAccounts);
        }

        // GET: BdhAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BdhAccountController/Create
        public ActionResult BdhCreate()
        {
            BdhAccount model = new BdhAccount();
            return View();
        }

        // POST: BdhAccountController/Create
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

        // GET: BdhAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BdhAccountController/Edit/5
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

        // GET: BdhAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BdhAccountController/Delete/5
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
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone(string phone)
        {
            Regex _isPhone = new Regex(@"^(\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4}))$");

            if (!_isPhone.IsMatch(phone))
            {
                return Json($"Số điện thoại {phone} không đúng định dạng, VD: 0986421127 hoặc 098.421.1127");
            }

            return Json(true);
        }

    }
}
