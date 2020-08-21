using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDown.Models;

namespace DropDown.Controllers
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

        
        public ActionResult TestDropDownList(Employee emp ,string s="")
        {
            Employee emp1 = new Employee();
            //var list = new List<String>() { "India", "America", "Russia", "Japan", "Nepal" };
            //ViewBag.CountryList = list;
            var list = new List<Country>()
            {
                new Country { ID=1,Text="India"},
                new Country { ID=2,Text="America"},
                new Country { ID=3,Text="Russia"},
                new Country { ID=4,Text="Japan"},
                new Country { ID=5,Text="Nepal"},
            };
            ViewBag.CountryList = list;

            if (emp.Country>0)
            {
              emp1 = new Employee()
                {
                    Country = emp.Country,
                    Name=emp.Name
                   
                };
                return View(emp1);
            }
           
            return View();


        }
        [HttpPost]
        public ActionResult TestDropDownList(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("TestDropDownList",emp);
               
            }
            var list = new List<Country>()
            {
                new Country { ID=1,Text="India"},
                new Country { ID=2,Text="America"},
                new Country { ID=3,Text="Russia"},
                new Country { ID=4,Text="Japan"},
                new Country { ID=5,Text="Nepal"},
            };
            ViewBag.CountryList = list;


            return View(emp);

        }
    }
}