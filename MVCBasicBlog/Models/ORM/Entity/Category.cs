using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Models.ORM.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<BlogPost> BlogPost { get; set; }
    }
}