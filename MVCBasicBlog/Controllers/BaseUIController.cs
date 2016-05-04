using MVCBasicBlog.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Controllers
{
    public class BaseUIController : Controller
    {
 
        public BlogContext db;
        public BaseUIController()
        {
            db = new BlogContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}