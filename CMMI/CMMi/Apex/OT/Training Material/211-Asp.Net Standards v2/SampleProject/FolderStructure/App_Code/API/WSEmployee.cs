using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Controller.Admin;

/// <summary>
/// Summary description for WSEmployee
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WSEmployee : System.Web.Services.WebService {

    public WSEmployee () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    /// <summary>
    /// Determines whether this instance is live.
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public Boolean IsLive() {
        return true;
    }

    /// <summary>
    /// Gets the employee by ID.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns></returns>
    public Model.Admin.Employee GetEmployeeByID(int id)
    {
        Employee _employee = new Employee();

        return _employee.GetEmployeeByID(id);

    }

    /// <summary>
    /// Gets the employee list.
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<Model.Admin.Employee> GetEmployeeList()
    {
        Employee _employee = new Employee();

        return _employee.GetEmployeeList();
    }
    
}

