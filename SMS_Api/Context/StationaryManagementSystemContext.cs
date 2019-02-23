using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMS_Api.Context
{
    public  class StationaryManagementSystem
    {
        public  SqlConnection smsConn;
        public  SqlCommand smsCmd;
        public  SqlDataReader reader;

        public StationaryManagementSystem()
        {
            smsConn = new SqlConnection(ConfigurationManager.ConnectionStrings["StationaryManagementSystemConnectionString"].ConnectionString);
        }

        public  void SqlReader()
        {
            reader = smsCmd.ExecuteReader();
        }

        public  void GetOrderSQLCommand()
        {
            smsCmd = new SqlCommand("GetOrder", smsConn);
        }

        public  void GetOrderByOrderIdSQLCommand()
        {
            smsCmd = new SqlCommand("GetOrderById", smsConn);
        }

        public  void GetOrderByInventaryIdSQLCommand()
        {
            smsCmd = new SqlCommand("GetOrderById", smsConn);
        }

        public  void GetOrderByInstitutionIdSQLCommand()
        {
            smsCmd = new SqlCommand("GetOrderByInstitutionId", smsConn);
        }

        public  void CreateOrderSQLCommand()
        {
            smsCmd = new SqlCommand("OrderCreate", smsConn);
        }

        public  void UpdateOrderSQLCommand()
        {
            smsCmd = new SqlCommand("UpdateOrder", smsConn);
        }

        public  void DeleteOrderSQLCommand()
        {
            smsCmd = new SqlCommand("DeleteOrder", smsConn);
        }      
    }
}