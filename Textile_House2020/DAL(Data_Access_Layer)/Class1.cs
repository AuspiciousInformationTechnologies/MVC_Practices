using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace DAL_Data_Access_Layer_
{
    public class DataAccessLayer
    {

        private SqlConnection _sqlcon = new SqlConnection();
        private SqlDataAdapter _sqlApdp = new SqlDataAdapter();
        private SqlCommand _sqlcmd = new SqlCommand();
        private  SqlDataReader _sqldr = null;
        DataTable _dt = new DataTable();
        DataSet _ds = new DataSet();
        

        public DataAccessLayer()
        {
            _sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect_texttile"].ConnectionString.ToString());
        }

        public static DataSet ReturnDS(string procedure, SqlParameter[] parameter)
        {
            DataSet _ds = new DataSet();
            return _ds;
        }

        public static DataTable ReturnDT(string procedure, SqlParameter[] parameter)
        {
            DataTable dt = new DataTable();
            return dt; 
        }
    }
}
