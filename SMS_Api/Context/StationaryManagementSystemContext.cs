using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMS_Api.Context
{
    public static class StationaryManagementSystem
    {
        public static SqlConnection smsConn;
        public static SqlCommand smsCmd;
        public static SqlDataReader reader;		
		static StationaryManagementSystem()
        {
            smsConn = new SqlConnection(ConfigurationManager.ConnectionStrings["StationaryManagementSystemConnectionString"].ConnectionString);
        }
        public static void SqlReader()
        {
            reader = smsCmd.ExecuteReader();
        }
		public static void SetSQLCommand(string storedProcedure)
		{
			smsCmd = new SqlCommand(storedProcedure, smsConn);
		}	    
    }
}