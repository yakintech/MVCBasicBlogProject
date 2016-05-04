using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Models.VM
{
    public class PostVM : SiteBaseVM
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public string Path { get; set; }

        public string Content { get; set; }
    }
}