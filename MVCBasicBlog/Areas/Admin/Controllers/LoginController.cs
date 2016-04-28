using MVCBasicBlog.Areas.Admin.Models.VM;
using MVCBasicBlog.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCBasicBlog.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        //
        private BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginVM model)
        {
            if (db.AdminUsers.Any(x => x.EMail == model.EMail && x.Password == model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.EMail, true);
                return RedirectToAction("Index", "AdminHome");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}