using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Textile_House2020
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
           name: "Default",
           url: "{controller}/{action}/{id}",
           defaults: new {controller = "UserRegistration", action = "Index", id = UrlParameter.Optional },
           namespaces: new string[] { "Textile_House2020.Areas.User.Controllers" }
           ).DataTokens["area"] = "User";


            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "UserRegistration", action = "Index", id = UrlParameter.Optional, areas = "User" },
            //    namespaces: new string[] {"Textile_House2020.Areas.User.Controllers"}
            //);

           
        }
    }
}
