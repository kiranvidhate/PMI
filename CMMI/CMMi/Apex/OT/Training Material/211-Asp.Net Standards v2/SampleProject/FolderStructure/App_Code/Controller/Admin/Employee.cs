using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Common.Controller;



/// <summary>
/// Summary description for Employee
/// </summary>
namespace Controller.Admin
{
    public class Employee
    {

        #region Private Function

        /// <summary>
        /// Builds the employee item.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        private Model.Admin.Employee BuildEmployeeItem(DataTableReader reader)
        {
            Model.Admin.Employee _employeeItem = new Model.Admin.Employee();

            _employeeItem.ID = Convert.ToInt32(reader["id"]);
            _employeeItem.Name = Convert.ToString(reader["Name"]);
            _employeeItem.Department = Convert.ToString(reader["Department"]);
            _employeeItem.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

            return _employeeItem;

        }


        /// <summary>
        /// Builds the employee list.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        private List<Model.Admin.Employee> BuildEmployeeList(DataTableReader reader)
        {
            List<Model.Admin.Employee> _employeeList = new List<Model.Admin.Employee>();
            while (reader.Read())
            {
                _employeeList.Add(BuildEmployeeItem(reader));
            }
            return _employeeList;

        }

        #endregion 

        #region Constructor

        public Employee()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion

        #region Public Function


        /// <summary>
        /// Gets the employee by ID.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public Model.Admin.Employee GetEmployeeByID(int id)
        {
            List<SqlParameter> employeeParameters = new List<SqlParameter>();

            employeeParameters.Add(new SqlParameter("@id", id));


            DataTableReader reader = DBOPS.SqlHelper.ExecuteTableReader(GlobalValues.ConnectionString, CommandType.StoredProcedure, "GetEmployeeByID", employeeParameters.ToArray());

            if (reader.Read())
            {
                return BuildEmployeeItem(reader);
            }

            //if record does not exist then return a blank object of employee or else you can return a null object.
            return new Model.Admin.Employee();


        }

        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns></returns>
        public List<Model.Admin.Employee> GetEmployeeList()
        {
            List<SqlParameter> employeeParameters = new List<SqlParameter>();

            return BuildEmployeeList(DBOPS.SqlHelper.ExecuteTableReader(GlobalValues.ConnectionString, CommandType.StoredProcedure, "GetEmployeeList", employeeParameters.ToArray()));
        }

        #endregion 
    }

}
