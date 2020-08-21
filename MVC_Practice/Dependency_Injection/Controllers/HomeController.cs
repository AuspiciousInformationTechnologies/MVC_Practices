using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BL;
namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        readonly public IEmployee _iemployee = null;
        readonly public IStudent _istudent = null;

        public HomeController(IEmployee _iemlpoyee,IStudent _istudent)
        {
            this._iemployee = _iemlpoyee;
            this._istudent = _istudent;
        }
        public ActionResult Index()
        {
            int totalemp=_iemployee.GetTotalEmployees();
            int totalstu = _istudent.GetTotal_Student();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}