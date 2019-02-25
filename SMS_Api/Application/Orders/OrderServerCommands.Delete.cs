using SMS_Api.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMS_Api.Application.Orders
{
    public static partial class OrderServerCommands
    {
        public static bool DeleteOrder(int orderId)
        {
            StationaryManagementSystem.DeleteOrderSQLCommand();

            StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
            StationaryManagementSystem.smsCmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = orderId;
            StationaryManagementSystem.smsConn.Open();
            object o = StationaryManagementSystem.smsCmd.ExecuteScalar();
            if (o != null)
            {
                string id = o.ToString();
            }
            StationaryManagementSystem.smsConn.Close();
            return true;
        }
    }
}