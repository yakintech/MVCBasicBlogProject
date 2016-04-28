using MVCBasicBlog.Areas.Admin.Models.VM;
using MVCBasicBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Areas.Admin.Controllers
{
    public class BlogPostController : BaseAdminController
    {
        public BlogPostController()
        {
            //2. dropdown doldurma yöntemi
            ViewData["drpcategories"] = db.Categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.ID.ToString()
            }).ToList();

        }

        //[OverrideActionFilters]
        public ActionResult AddBlogPost()
        {

            return View(drpCategories());
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddBlogPost(BlogPostVM model)
        {
            if (ModelState.IsValid)
            {
                BlogPost blogpost = new BlogPost();
                blogpost.Title = model.Title;
                blogpost.Content = model.Content;
                blogpost.CategoryID = model.CategoryID;


                foreach (string name in Request.Files)
                {
                    string number = Guid.NewGuid().ToString();
                    string ext = Path.GetExtension(model.AnaResim.FileName);
                    model.AnaResim = Request.Files[name];
                   
                    if (ext == ".jpg" || ext == ".png" || ext == ".jpeg")
                    {
                        string filename = number + model.AnaResim.FileName;
                        blogpost.ImagePath = filename;
                        model.AnaResim.SaveAs(Server.MapPath("~/Areas/Admin/Content/images/BlogPost/" + number + model.AnaResim.FileName));

                    }
                }


                db.BlogPost.Add(blogpost);
                db.SaveChanges();

                ViewBag.IslemDurum = 1;

                return View(drpCategories());
            }
            else
            {
                ViewBag.IslemDurum = 3;
                return View(drpCategories());
            }

        }

        BlogPostVM drpCategories()
        {
            BlogPostVM model = new BlogPostVM();
            model.drpCategories = db.Categories.Where(x => x.IsDeleted == false).Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.ID.ToString()
            }).ToList();

            return model;
        }
    }
}