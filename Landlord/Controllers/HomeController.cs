using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Landlord.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.LogInViewModel login)
        {
            if (login.username == null || login.password == null)
            {
                ModelState.AddModelError("", "Fill in the forms");
                return View();
            }
            bool validUser = false;

            validUser = System.Web.Security.FormsAuthentication.Authenticate(login.username, login.password);

            if (validUser)
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(login.username, false);
            }
            ModelState.AddModelError("", "Login not accepted");
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "This page is a placeholder.";

            return View();
        }
    }
}