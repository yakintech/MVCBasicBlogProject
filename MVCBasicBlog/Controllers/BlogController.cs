using MVCBasicBlog.Models.ORM.Entity;
using MVCBasicBlog.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Controllers
{
    public class BlogController : BaseUIController
    {
       
        public ActionResult Index(string category, string title)
        {
            BlogPost blogpost = db.BlogPost.FirstOrDefault(x => x.Slug == title);

            PostVM model = new PostVM();
            model.Title = blogpost.Title;
            model.Category = blogpost.Category.Name;
            model.Content = blogpost.Content;
            model.Path = blogpost.ImagePath;

            return View(model);
        }

        public ActionResult BlogCategory(string category)
        {
            List<PostVM> model = db.BlogPost.Where(x => x.Category.Slug == category).Select(x => new PostVM()
            {
                Category = x.Category.Name,
                Title = x.Title
            }).ToList();

            return View(model);
        }
    }
}