using SMS_Api.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMS_Api.Application.Orders
{
    public partial class OrderServerCommands
    {
        public bool CreateOrder(Order order)
        {
            sms.CreateOrderSQLCommand();

            sms.smsCmd.CommandType = CommandType.StoredProcedure;
            sms.smsCmd.Parameters.Add("@InstitutionId", SqlDbType.Int).Value = order.InstitutionId;
            sms.smsCmd.Parameters.Add("@InventaryId", SqlDbType.Int).Value = order.InventaryId;
            sms.smsCmd.Parameters.Add("@MarkUpId", SqlDbType.Int).Value = order.MarkUpId;
            sms.smsCmd.Parameters.Add("@ExpectedOrderDate", SqlDbType.DateTime).Value = order.ExpectedOrderDate;
            sms.smsCmd.Parameters.Add("@BufferDaysBeforeDelivery", SqlDbType.Int).Value = order.BufferDaysBeforeDelivery;
            sms.smsCmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = order.CreatedBy;
            sms.smsCmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = order.CreatedOn;
            sms.smsCmd.Parameters.Add("@UpdatedBy", SqlDbType.Int).Value = order.UpdatedBy;
            sms.smsCmd.Parameters.Add("@UpdatedOn", SqlDbType.DateTime).Value = order.UpdatedOn;
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