using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Async_Controller.Models;
using System.Threading.Tasks;

namespace Async_Controller.Controllers
{
    public class HomeController : Controller
    {
        MVC_PracticeEntities me = new MVC_PracticeEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public  async  Task<ActionResult> Index(tbl_Async model)
        {
            if (ModelState.IsValid)
            {
                me.tbl_Async.Add(model);
                await me.SaveChangesAsync();

                RedirectToAction("Index");
            }

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