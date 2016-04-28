using MVCBasicBlog.Areas.Admin.Models.Types.Enums;
using MVCBasicBlog.Models.ORM.Context;
using MVCBasicBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Areas.Admin.Models.Attributes
{
    public class RolControl :ActionFilterAttribute
    {
        int number;
        public RolControl(EnumRoles rolenumber)
        {
            number = Convert.ToInt32(rolenumber);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            BlogContext db = new BlogContext();
            string email = HttpContext.Current.User.Identity.Name;
            AdminUser adminuser = db.AdminUsers.FirstOrDefault(x => x.EMail == email);

            string[] roles = adminuser.Roles.Split(';');
            bool yetkiVarMi = false;
            foreach (var item in roles)
            {
                if (number.ToString() == item)
                {
                    yetkiVarMi = true;
                }
            }

            if (!yetkiVarMi)
            {
                HttpContext.Current.Response.Redirect("/Admin/Hata/YetkisizErisim");
            }

        }
    }
}