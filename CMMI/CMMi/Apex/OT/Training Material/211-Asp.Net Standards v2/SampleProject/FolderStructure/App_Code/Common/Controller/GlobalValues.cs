using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for GlobalValues
/// </summary>
namespace Common.Controller
{
    public class GlobalValues
    {

        #region Private Member Variables

        private static String _connectionString;

        #endregion

        #region Constructor

        public GlobalValues()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion

        #region Public Properties

        public static String ConnectionString
        {
            get
            {
                if (String.IsNullOrEmpty(_connectionString))
                    _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                return _connectionString;

            }
            set
            {
                _connectionString = value;
            }
        }

        #endregion

    }
}