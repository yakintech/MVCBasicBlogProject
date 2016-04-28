using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Areas.Admin.Controllers
{
    public class HataController : Controller
    {
       
        public ActionResult YetkisizErisim()
        {
            return View();
        }
    }
}