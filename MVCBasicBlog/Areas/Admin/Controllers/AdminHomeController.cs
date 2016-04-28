using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Areas.Admin.Controllers
{
    public class AdminHomeController : BaseAdminController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}