using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
namespace Model.Admin
{
    public class Employee
    {
        #region Constructors

        public Employee()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion

        #region Public Properties

      
        public int ID { get; set; }
        public String Name { get; set; }
        public String Department { get; set; }
        public DateTime DateOfBirth { get; set; }

        #endregion
    }
}