using System.Web;
using System.Web.Optimization;

namespace Textile_House2020
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
          "~/Scripts/bootstrap.bundle.min.js",
            "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //           "~/Content/bootstrap.css",
            //           "~/dist/css/adminlte.min.css",
            //            "~/plugins/fontawesome-free/css/all.min.css",
            //"~/plugins/summernote/summernote-bs4.min.css",
            // "~/plugins/fullcalendar/main.min.css",
            //"~/plugins/fullcalendar-daygrid/main.min.css",
            //"~/plugins/fullcalendar-bootstrap/main.min.css",
            //           "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.css",
                       "~/dist/css/adminlte.min.css",
                        "~/plugins/fontawesome-free/css/all.min.css",
            "~/plugins/summernote/summernote-bs4.min.css",
             "~/plugins/fullcalendar/main.min.css",
            "~/plugins/fullcalendar-daygrid/main.min.css",
            "~/plugins/datatables-bs4/dataTables.bootstrap4.min.css", 
            "~/plugins/fullcalendar-bootstrap/main.min.css"));

            bundles.Add(new ScriptBundle("~/dist/js").Include(
    "~/dist/js/adminlte.min.js",
    "~/plugins/summernote/summernote-bs4.min.js",
    "~/plugins/datatables/jquery.dataTables.min.js"
    ));


            bundles.Add(new StyleBundle("~/User/Content/css").Include(
                        "~/Areas/User/Content/css/style.css",
                        "~/Areas/User/Content/css/style.scss"
                        ));


            BundleTable.EnableOptimizations = true;
 



        }
    }
}
