using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMS_Api.Context
{
    public class StationaryManagementSystemContext
    {
        public  SqlConnection smsConn;
        public SqlCommand smsCmd;

        public StationaryManagementSystemContext()
        {
            smsConn = new SqlConnection(ConfigurationManager.ConnectionStrings["StationaryManagementSystemConnectionString"].ConnectionString);
        }
        
        public void CreateSQLCommand()
        {
            smsCmd = new SqlCommand("Order_Create", smsConn);
        }
    }
}