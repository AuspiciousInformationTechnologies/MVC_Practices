using Exception_Filter.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exception_Filter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [CustomeExceptionFIlter]
        public ActionResult Index()
        {


            throw new NotImplementedException();

            return View();
        }
    }
}