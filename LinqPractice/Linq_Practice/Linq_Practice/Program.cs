using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq_Practice;
using BOL;

namespace Linq_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee {EmployeeName="Prafull Kumar Goswami",ContactNo="9616157858",EmailID="prafullgoswami@gmail.com",ID=1 }

            };

            var basicQuery = (from emp in employee
                           select emp).ToList();

            foreach(var item in basicQuery)
            {

                Console.WriteLine($"ID={item.ID},\n Name={item.EmployeeName},\n Email ID={item.EmailID},\n Contact No={item.ContactNo}");
                Console.ReadLine();
            }


            var basicQuery1 = (from emp1 in employee
                              select new
                              {
                                  emp1.EmployeeName,
                                  emp1.ID,
                                  emp1.ContactNo,
                                  emp1.EmailID,
                              }).ToList();



            foreach (var item in basicQuery1)
            {

                Console.WriteLine($"ID={item.ID},\n Name={item.EmployeeName},\n Email ID={item.EmailID},\n Contact No={item.ContactNo}");
                Console.ReadLine();
            }

        }
    }
}
