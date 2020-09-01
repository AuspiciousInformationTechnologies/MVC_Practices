using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLayer
{
    /// <summary>
    /// Country Exceptiop is made  to handle exception related to Country Classes
    /// </summary>
    class CountryException:ApplicationException
    {

        /// <summary>
        /// <param name="message">Exception Message</param>
        /// Constructer that Initialize the exception message
        /// </summary>
        public CountryException(string message):base(message)
        {

        }


        /// <summary>
        /// <param name="message">Exception Message</param>
        ///  <param name="InnerException">Exception Message</param>
        /// Constructer that Initialize the exception message and inner exception  message
        /// </summary>

        public CountryException(string message,Exception InnerException) : base(message,InnerException)
        {

        }





    }
}
