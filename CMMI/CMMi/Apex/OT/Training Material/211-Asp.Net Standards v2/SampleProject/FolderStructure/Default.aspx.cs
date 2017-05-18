using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model.Admin;

public partial class _Default : System.Web.UI.Page
{

    #region Supporting Functions

    /// <summary>
    /// Gets the employee by ID.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns></returns>
    private Employee GetEmployeeByID(int id)
    {
        return _wsEmployee.GetEmployeeByID(id);
    }

    #endregion

    #region Global Declaration

    WSEmployee _wsEmployee = new WSEmployee();

    #endregion

    #region Control Events

    /// <summary>
    /// Handles the Click event of the btnSearch control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Employee _employee = GetEmployeeByID(1);
    }

    #endregion

    #region Page Events

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #endregion

}
