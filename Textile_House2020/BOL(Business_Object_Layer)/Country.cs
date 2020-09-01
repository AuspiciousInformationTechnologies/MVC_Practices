using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BOL_Business_Object_Layer_
{
    ///<summary>
    /// Country Business Entities and Implements  ICountry Interface
    ///</summary>

   public class Country : ICountry
    {

        #region Start
        private Guid _CountryAutoID;
        private int _CountryCode;
        private int _CountryID;
        private string _Name;
        private string _CountryAlphaCode;
        private bool _IsActive;

        #endregion

        #region Properties

        /// <summary>
        /// Auto generated Country GUID , For Unique Identification
        /// </summary>
        public Guid CountryAutoID
        {
            get{ return _CountryAutoID; }

            set
            {
                _CountryAutoID = value;
            }
        }


        /// <summary>
        ///Properties for real world Country Code, Accept Country Code
        /// </summary>
        public int CountryCode
        {
            get
            {
                return _CountryCode;
            }

            set
            {
                _CountryCode = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string CountryAlphaCode
        {
            get
            {
                return _CountryAlphaCode;
            }

            set
            {
                _CountryAlphaCode = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _IsActive;
            }

            set
            {
                _IsActive = value;
            }
        }

        public int CountryID
        {
            get
            {
                return _CountryID;
            }

            set
            {
                _CountryID = value;
            }
        }
        #endregion
    }
}
