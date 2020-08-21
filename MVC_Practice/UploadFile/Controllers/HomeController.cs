using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using UploadFile.Models;
namespace UploadFile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase fliefup)
        {

            string path = Server.MapPath("~/App_Data/Images");
            string filename = fliefup.FileName.ToString();
            string filetype = fliefup.ContentType.ToString();
            string fulpath = Path.Combine(path, filename);
            fliefup.SaveAs(fulpath);


          //  string  s1=fliefup.SaveAs()

            return View();
        }


        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadFile(Student Stu)
        {

            string path = Server.MapPath("~/App_Data/Images");
            string filename = Stu.filefup.FileName.ToString();
            string filetype = Stu.filefup.ContentType.ToString();
            string fulpath = Path.Combine(path, filename);
            Stu.filefup.SaveAs(fulpath);


            //  string  s1=fliefup.SaveAs()

            return View();
        }


    
        public FileResult DownloadFile(Student Stu)
        {

            string path = Server.MapPath("~/App_Data/Images");
            string filename = Path.GetFileName("2020-08-17 (5).png");
          //  string filetype = Stu.filefup.ContentType.ToString();
            string fulpath = Path.Combine(path, filename);
            


            //  string  s1=fliefup.SaveAs()

            return File(fulpath,"image/png","CoreFile1.png");
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