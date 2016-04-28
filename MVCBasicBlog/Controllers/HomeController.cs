using MVCBasicBlog.Models.ORM.Context;
using MVCBasicBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Controllers
{
    public class HomeController : Controller
    {

        private BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            BlogPost blogpost = db.BlogPost.FirstOrDefault(x => x.ID == 4);
            return View(blogpost);
        }
    }
}