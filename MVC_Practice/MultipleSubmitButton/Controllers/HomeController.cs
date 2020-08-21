using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleSubmitButton.Models;
namespace MultipleSubmitButton.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpPost]
        public ActionResult SaveForm(Customer obj)
        {
            ViewBag.Message = "Customer saved successfully!";
            return View("SaveForm", obj);
        }

        [HttpPost]
        public ActionResult CancelForm(Customer obj)
        {
            ViewBag.Message = "The operation was cancelled!";
            return View("SaveForm", obj);
        }
    }
}