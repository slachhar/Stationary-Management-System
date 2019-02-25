using SMS_Api.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMS_Api.Application.Orders
{
    public static  partial class OrderServerCommands
    {
        public static bool UpdateOrder(SMS_Library.Business.Models.Order order)
        {
            StationaryManagementSystem.UpdateOrderSQLCommand();

            StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
            StationaryManagementSystem.smsCmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = order.OrderId;
            StationaryManagementSystem.smsCmd.Parameters.Add("@InstitutionId", SqlDbType.Int).Value = order.InstitutionId;
            StationaryManagementSystem.smsCmd.Parameters.Add("@InventaryId", SqlDbType.Int).Value = order.InventaryId;
            StationaryManagementSystem.smsCmd.Parameters.Add("@MarkUpId", SqlDbType.Int).Value = order.MarkUpId;
            StationaryManagementSystem.smsCmd.Parameters.Add("@ExpectedOrderDate", SqlDbType.DateTime).Value = order.ExpectedOrderDate;
            //StationaryManagementSystem.smsCmd.Parameters.Add("@BufferDaysBeforeDelivery", SqlDbType.Int).Value = order.BufferDaysBeforeDelivery;
            StationaryManagementSystem.smsCmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = order.CreatedBy;
            StationaryManagementSystem.smsCmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = order.CreatedOn;
            StationaryManagementSystem.smsCmd.Parameters.Add("@UpdatedBy", SqlDbType.Int).Value = order.UpdatedBy;
            StationaryManagementSystem.smsCmd.Parameters.Add("@UpdatedOn", SqlDbType.DateTime).Value = order.UpdatedOn;
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