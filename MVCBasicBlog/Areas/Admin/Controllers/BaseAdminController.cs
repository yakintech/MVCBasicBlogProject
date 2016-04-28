using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBasicBlog.Models.ORM.Context;
using MVCBasicBlog.Areas.Admin.Models.Attributes;


namespace MVCBasicBlog.Areas.Admin.Controllers
{
    [LoginControl]
    public class BaseAdminController : Controller
    {
        public BlogContext db;
        public BaseAdminController()
        {
            db = new BlogContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}