using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCBasicBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/layoutcss").Include(
                        "~/Assets/css/bootstrap.min.css",
                        "~/Assets/css/business-casual.css"));

            bundles.Add(new ScriptBundle("~/bundles/layoutjs").Include(
                "~/Scripts/jquery.js",
                "~/Scripts/bootstrap.min.js"
                ));

           // BundleTable.EnableOptimizations = true;
        }
    }
}