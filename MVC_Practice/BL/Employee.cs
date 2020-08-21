using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Employee : IEmployee
    {
        public int GetTotalEmployees()
        {
            return 10;
        }
    }
}
