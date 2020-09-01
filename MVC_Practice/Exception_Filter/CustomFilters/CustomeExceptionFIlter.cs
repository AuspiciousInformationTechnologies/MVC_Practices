using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exception_Filter.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Exception_Filter.CustomFilters
{
    public class CustomeExceptionFIlter : FilterAttribute, IExceptionFilter
    {

       
        public void OnException(ExceptionContext filterContext)
        {

            string Reqid = "";
            string spname = "Usp_Error_Log";
            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@GUID",Guid.NewGuid().ToString());
            param[1] = new SqlParameter("@Error_Name",System.Convert.ToString(filterContext.Exception.Source) );
            param[2] = new SqlParameter("@Error_Message", System.Convert.ToString(filterContext.Exception.Message.ToString()));
            param[3] = new SqlParameter("@Error_StackTrace", System.Convert.ToString(filterContext.Exception.StackTrace));
            param[4] = new SqlParameter("@Error_ControllerName", System.Convert.ToString(filterContext.RouteData.Values["controller"]));
            param[5] = new SqlParameter("@Error_ActionName", System.Convert.ToString(filterContext.RouteData.Values["action"]));
            param[6] = new SqlParameter("@Error_Time", System.Convert.ToString(DateTime.Now));
            param[7] = new SqlParameter("@Erro_SystemIP", System.Convert.ToString(""));
            param[8] = new SqlParameter("@Error_MacAddress", System.Convert.ToString(""));
            param[9] = new SqlParameter("@Error_PublicID", System.Convert.ToString(""));
            param[10] = new SqlParameter("@Error_UserName", System.Convert.ToString(""));
            param[11] = new SqlParameter("@Error_SystemName", System.Convert.ToString(""));
            param[12] = new SqlParameter("@Error_Browser", System.Convert.ToString(""));

            ADOContext _ADOContext = new ADOContext();
            DataTable dt = new DataTable();

            dt = _ADOContext.ExecDtSQLProcAdoConnection(spname, param);
            //if (dt != null)
            //{
            //    Reqid = dt.Rows[0]["RequestId"].ToString();
            //}
            filterContext.ExceptionHandled = true;
            
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };

          

        }
    }
}