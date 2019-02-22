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
        public bool Edit(Order order)
        {
            conn.UpdateSQLCommand();

            conn.smsCmd.CommandType = CommandType.StoredProcedure;
            conn.smsCmd.Parameters.Add("@InstitutionId", SqlDbType.Int).Value = order.InstitutionId;
            conn.smsCmd.Parameters.Add("@InventaryId", SqlDbType.Int).Value = order.InventaryId;
            conn.smsCmd.Parameters.Add("@MarkUpId", SqlDbType.Int).Value = order.MarkUpId;
            conn.smsCmd.Parameters.Add("@ExpectedOrderDate", SqlDbType.DateTime).Value = order.ExpectedOrderDate;
            conn.smsCmd.Parameters.Add("@BufferDaysBeforeDelivery", SqlDbType.Int).Value = order.BufferDaysBeforeDelivery;
            conn.smsCmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = order.CreatedBy;
            conn.smsCmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = order.CreatedOn;
            conn.smsCmd.Parameters.Add("@UpdatedBy", SqlDbType.Int).Value = order.UpdatedBy;
            conn.smsCmd.Parameters.Add("@UpdatedOn", SqlDbType.DateTime).Value = order.UpdatedOn;
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