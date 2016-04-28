using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Areas.Admin.Models.VM
{
    public class LoginVM
    {
        public string EMail { get; set; }

        public string Password { get; set; }
    }
}