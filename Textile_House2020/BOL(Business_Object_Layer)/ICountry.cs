using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL_Business_Object_Layer_
{
    interface ICountry
    {
        Guid CountryAutoID { get; set; }

         int CountryID { get; set; }

         string Name { get; set; }

        string CountryAlphaCode { get; set; }

        bool IsActive { get; set; }
    }
}
