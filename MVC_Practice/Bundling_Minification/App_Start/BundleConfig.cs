using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Bundling_Minification.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundle(BundleCollection bndlescollection)
        {
            var bundle = new ScriptBundle("~/bundles/JS");

            bundle.Include(
                            "~/Content/JS/JavaScript1.js",
                            "~/Content/JS/JavaScript2.js",
                            "~/Content/JS/JavaScript3.js"
                );

            bndlescollection.Add(bundle);
            BundleTable.EnableOptimizations = true;
        }
    }
}