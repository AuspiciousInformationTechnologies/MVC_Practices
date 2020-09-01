using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL_Business_Object_Layer_;
namespace BAL_Business_Access_Layer_
{
   interface ICountryBAL
    {
        DataTable   getDTCountry();
        DataSet getDSCountry();
        DataSet getDTCountryByCondition(); 
        DataSet getDSCountryByCondition();

        int addNewCountry(Country model);
        int upDateCountry(Country model);
        int deleteCountry(Country model);

        List<Country> getCountryName();
        Dictionary<string,string> getCountryNameandAlphaCode();


    }
}
