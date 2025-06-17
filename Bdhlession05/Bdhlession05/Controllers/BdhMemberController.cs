using Microsoft.AspNetCore.Mvc;
using Bdhlession05.Models.DataModels;

namespace Bdhlession05.Controllers
{
    public class BdhMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BdhGetMember()
        {
            var bdhMember = new BdhMember();
            bdhMember.BdhMemberId = Guid.NewGuid().ToString();
            bdhMember.BdhUserName = "HuyHuy";
            bdhMember.BdhFullName = "Bùi Đức Huy";
            bdhMember.BdhPassword = "123456a@";
            bdhMember.BdhEmail = "buiduchuy@gmail.com";

            ViewBag.bdhMember = bdhMember;
            return View();
        }
    }
}
