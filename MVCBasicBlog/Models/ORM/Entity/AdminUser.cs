using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Models.ORM.Entity
{
    public class AdminUser : BaseEntity
    {
        [Required]
        public string EMail { get; set; }

        public string Password { get; set; }

        public string Roles { get; set; }

        public DateTime? LastLoginDate { get; set; }
    }
}