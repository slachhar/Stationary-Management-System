using SMS_Api.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMS_Api.Application.Orders
{
    public  partial class OrderServerCommands
    {
        public bool GetOrder(Order order)
        {
            conn.GetByIdSQLCommand();

            conn.smsCmd.CommandType = CommandType.StoredProcedure;
            conn.smsCmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = order.InstitutionId;
            conn.smsConn.Open();
            object o = conn.smsCmd.ExecuteScalar();
            if (o != null)
            {
                string id = o.ToString();
            }
            conn.smsConn.Close();
            return true;
        }
    }
}