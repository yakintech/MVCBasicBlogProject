using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Areas.Admin.Models.VM
{
    public class BlogPostVM : BaseVM
    {

        [Display(Name = "Kategoriler")]
        public IEnumerable<SelectListItem> drpCategories { get; set; }

        [Display(Name="Başlık"),Required]
        public string Title { get; set; }

        [Display(Name="İçerik")]
        public string Content { get; set; }

        public int CategoryID { get; set; }
    }
}