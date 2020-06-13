using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LightTimeBlog.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}