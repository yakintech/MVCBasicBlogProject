using MVCBasicBlog.Areas.Admin.Models.VM;
using MVCBasicBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Areas.Admin.Controllers
{
    public class AdminUserController : BaseAdminController
    {
        public ActionResult AddAdminUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdminUser(AdminUserVM model)
        {
            if (ModelState.IsValid)
            {
                if (db.AdminUsers.Any(x => x.EMail == model.EMail))
                {
                    ViewBag.IslemDurum = 2;
                    return View();
                }
                AdminUser adminuser = new AdminUser();
                adminuser.EMail = model.EMail;
                adminuser.Password = model.Password;

                db.AdminUsers.Add(adminuser);
                db.SaveChanges();
                ViewBag.IslemDurum = 1;
                return View();
            }
            else
            {
                ViewBag.IslemDurum = 3;
                return View();
            }
        }
    }
}