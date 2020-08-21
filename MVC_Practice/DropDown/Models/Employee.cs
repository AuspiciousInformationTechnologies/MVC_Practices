using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DropDown.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }

        [Required ]
        
        public int Country { get; set; }
    }

    public class Country
    {

        public int ID { get; set; }
        public string Text { get; set; }
    }
}