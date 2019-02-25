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

        public static void GetAllOrdersSQLCommand()
        {
            smsCmd = new SqlCommand("GetOrder", smsConn);
        }

        public static void GetOrderByOrderIdSQLCommand()
        {
            smsCmd = new SqlCommand("GetOrderById", smsConn);
        }

        public static void GetOrderByInventaryIdSQLCommand()
        {
            smsCmd = new SqlCommand("GetOrderById", smsConn);
        }

        public static void GetOrderByInstitutionIdSQLCommand()
        {
            smsCmd = new SqlCommand("GetOrderByInstitutionId", smsConn);
        }

        public static void CreateOrderSQLCommand()
        {
            smsCmd = new SqlCommand("OrderCreate", smsConn);
        }

        public static void UpdateOrderSQLCommand()
        {
            smsCmd = new SqlCommand("UpdateOrder", smsConn);
        }

        public static void DeleteOrderSQLCommand()
        {
            smsCmd = new SqlCommand("DeleteOrder", smsConn);
        }      
    }
}