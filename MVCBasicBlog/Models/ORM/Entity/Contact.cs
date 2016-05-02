using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Models.ORM.Entity
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public string Message { get; set; }
    }
}