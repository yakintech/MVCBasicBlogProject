using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCBasicBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

                        routes.MapRoute(
               name: "BlogCat",
               url: "Blog/{category}",
               defaults: new { controller = "Blog", action = "BlogCategory",
                   category = UrlParameter.Optional,
                  }
           );

            routes.MapRoute(
               name: "BlogPost",
               url: "blog/{category}/{title}",
               defaults: new { controller = "Blog", action = "Index",
                   category = UrlParameter.Optional,
                   title = UrlParameter.Optional,}
           );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
