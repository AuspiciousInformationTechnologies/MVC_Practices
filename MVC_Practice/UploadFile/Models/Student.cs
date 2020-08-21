using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UploadFile.Models
{
    public class Student
    {
        public string StudentName { get; set; }
        public HttpPostedFileBase filefup { get; set; }
    }
}