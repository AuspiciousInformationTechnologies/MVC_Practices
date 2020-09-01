using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exception_Filter.CustomFilters;

namespace Exception_Filter.App_Start
{
    public class FilterConfig
    {

        public static void RegisterGlobalFilter(GlobalFilterCollection filters)
        {
            filters.Add(new CustomeExceptionFIlter());
        }
    }
}