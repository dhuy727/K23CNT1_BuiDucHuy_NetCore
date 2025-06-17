using Microsoft.AspNetCore.Mvc;
using Bdhlession07.Models;

namespace Bdhlession07.Controllers
{
    public class BdhEmployeeController : Controller
    {
        private static List<BdhEmployee> BdhListEmployees = new List<BdhEmployee>
        {
            new BdhEmployee { BdhId = 230001122, BdhName = "Đức Huy", BdhBirthDay = new DateTime(1979, 5, 25), BdhEmail = "chungtrinhj@gmail.com", BdhPhone = "0978611889", BdhSalary = 12000000, BdhStatus = true },
            new BdhEmployee { BdhId = 2, BdhName = "Trần Thị B", BdhBirthDay = new DateTime(1992, 5, 15), BdhEmail = "b@example.com", BdhPhone = "0912233445", BdhSalary = 15000000, BdhStatus = true },
            new BdhEmployee { BdhId = 3, BdhName = "Lê Văn C", BdhBirthDay = new DateTime(1988, 9, 20), BdhEmail = "c@example.com", BdhPhone = "0922123456", BdhSalary = 11000000, BdhStatus = false },
            new BdhEmployee { BdhId = 4, BdhName = "Phạm Thị D", BdhBirthDay = new DateTime(1995, 3, 10), BdhEmail = "d@example.com", BdhPhone = "0933445566", BdhSalary = 13000000, BdhStatus = true },
            new BdhEmployee { BdhId = 5, BdhName = "Đỗ Văn E", BdhBirthDay = new DateTime(1991, 7, 25), BdhEmail = "e@example.com", BdhPhone = "0944567890", BdhSalary = 10000000, BdhStatus = false }
        };
        public IActionResult BdhIndex()
        {
            return View();
        }

        // GET: /BdhEmployee/BdhCreate
        public IActionResult BdhCreate()
        {
            var model = new BdhEmployee();
            return View(model);
        }

        // POST: /BdhEmployee/BdhCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BdhCreate(BdhEmployee model)
        {
            try
            {
                // Tự động sinh mã nếu cần
                if (model.BdhId == 0)
                {
                    model.BdhId = BdhListEmployees.Max(e => e.BdhId) + 1;
                }
                BdhListEmployees.Add(model);
                return RedirectToAction(nameof(BdhIndex));
            }
            catch
            {
                return View();
            }
        }


        //  GET: /BdhEmployee/BdhEdit/id?
        public IActionResult BdhEdit(int id)
        {
            var model = BdhListEmployees.FirstOrDefault(x => x.BdhId == id);
            return View(model);
        }
    }
}
