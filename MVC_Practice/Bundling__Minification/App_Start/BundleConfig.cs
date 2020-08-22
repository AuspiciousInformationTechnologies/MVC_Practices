using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace Bundling__Minification.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundlescollection)
        {
            var bundle = new ScriptBundle("~/bundles/JS");

            //bundle.Include("~/Content/JS/JavaScript1.js",
            //    "~/Content/JS/JavaScript2.js");

            //bundlescollection.Add(bundle);

            var bundlecss = new ScriptBundle("~/bundles/CSS");

            bundle.Include("~/Content/CSS/StyleSheet1.css",
                "~/Content/CSS/StyleSheet2.css");

            //bundlescollection.Add(bundle);


            bundlescollection.Add(new ScriptBundle("~/bundles/JS").IncludeDirectory("~/Content/JS", "*.js"));
            bundlescollection.Add(new StyleBundle("~/bundles/CSS").Include("~/Content/CSS/StyleSheet1.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}