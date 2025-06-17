using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using BdhLab06.Models;

namespace YourNamespace.Controllers
{
    public class BdhEmployeeController : Controller
    {
        // Static list giả lập dữ liệu
        private static List<BdhEmployee> BdhListEmployee = new List<BdhEmployee>
        {
            new BdhEmployee { BdhId = 1, BdhName = "Nguyễn Văn A", BdhBirthDay = new DateTime(1990, 1, 15), BdhEmail = "vana@example.com", BdhPhone = "0912345678", BdhSalary = 12000000, BdhStatus = true },
            new BdhEmployee { BdhId = 2, BdhName = "Trần Thị B", BdhBirthDay = new DateTime(1985, 5, 20), BdhEmail = "thib@example.com", BdhPhone = "0987654321", BdhSalary = 15000000, BdhStatus = true },
            new BdhEmployee { BdhId = 3, BdhName = "Lê Văn C", BdhBirthDay = new DateTime(1992, 3, 10), BdhEmail = "vanc@example.com", BdhPhone = "0901122334", BdhSalary = 11000000, BdhStatus = false },
            new BdhEmployee { BdhId = 4, BdhName = "Phạm Thị D", BdhBirthDay = new DateTime(1998, 9, 5), BdhEmail = "thid@example.com", BdhPhone = "0911555777", BdhSalary = 10000000, BdhStatus = true },
            // Sinh viên
            new BdhEmployee { BdhId = 2310900044, BdhName = "Bùi Đức Huy", BdhBirthDay = new DateTime(2005, 12, 13), BdhEmail = "buiduchuy2005@gmail.com", BdhPhone = "0973378242", BdhSalary = 0, BdhStatus = false }
        };

        // Action: Hiển thị danh sách nhân viên
        public IActionResult BdhIndex()
        {
            return View(BdhListEmployee);
        }

        // Action GET: Trả về form thêm mới nhân viên
        [HttpGet]
        public IActionResult BdhCreate()
        {
            return View();
        }

        // Action POST: Xử lý form thêm mới nhân viên
        [HttpPost]
        public IActionResult BdhCreateSubmit(BdhEmployee newEmp)
        {
            newEmp.BdhId = BdhListEmployee.Max(e => e.BdhId) + 1;
            BdhListEmployee.Add(newEmp);
            return RedirectToAction("BdhIndex");
        }
    }
}
