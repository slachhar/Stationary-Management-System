using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMS_Api.Application.Orders
{
    public  partial class OrderServerCommands
    {
        public bool DeleteOrder(int orderId)
        {
            sms.DeleteOrderSQLCommand();

            sms.smsCmd.CommandType = CommandType.StoredProcedure;
            sms.smsCmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = orderId;
            sms.smsConn.Open();
            object o = sms.smsCmd.ExecuteScalar();
            if (o != null)
            {
                string id = o.ToString();
            }
            sms.smsConn.Close();
            return true;
        }
    }
}