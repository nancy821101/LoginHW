using LoginHW.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginHW.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel pageData)
        {
            if (ModelState.IsValid)//UserController用LoginViewModel
            {
                pageData.Message = $"您使用{pageData.Account}登入成功。";
            }
               
            return View(pageData);
        }
    }
}