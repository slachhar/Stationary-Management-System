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

        public Order GetOrderByOrderId(int orderId)
        {
            sms.GetOrderByOrderIdSQLCommand();

            sms.smsCmd.CommandType = CommandType.StoredProcedure;
            sms.smsCmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = orderId;
            sms.smsConn.Open();
            sms.SqlReader();
           
            Order order = null;
            while (sms.reader.Read())
            {
                order = new Order();
                order.OrderId = int.Parse(sms.reader["OrderId"].ToString());
                order.InstitutionId = int.Parse(sms.reader["InstitutionId"].ToString());
                order.InventaryId = int.Parse(sms.reader["InventaryId"].ToString());
                order.MarkUpId = int.Parse(sms.reader["MarkUpId"].ToString());
            }
            sms.reader.Close();
            sms.smsConn.Close();
            return order;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            sms.GetAllOrdersSQLCommand();

            sms.smsCmd.CommandType = CommandType.StoredProcedure;
            sms.smsConn.Open();
            sms.SqlReader();
            List<Order> orderList = new List<Order>();
            Order order = null;
            while (sms.reader.Read())
            {
                order = new Order();
                order.OrderId = int.Parse(sms.reader["OrderId"].ToString());
                order.InstitutionId = int.Parse(sms.reader["InstitutionId"].ToString());
                order.InventaryId = int.Parse(sms.reader["InventaryId"].ToString());
                order.MarkUpId = int.Parse(sms.reader["MarkUpId"].ToString());
                orderList.Add(order);
            }
            sms.reader.Close();
            sms.smsConn.Close();
            return orderList;
        }

        //public bool GetOrderByInstitutionId(int institutionId)
        //{
        //    sms.GetOrderByInstitutionIdSQLCommand();

        //    sms.smsCmd.CommandType = CommandType.StoredProcedure;
        //    sms.smsCmd.Parameters.Add("@institutionId", SqlDbType.Int).Value = institutionId;
        //    sms.smssms.Open();
        //    object o = sms.smsCmd.ExecuteScalar();
        //    if (o != null)
        //    {
        //        string id = o.ToString();
        //    }
        //    sms.smssms.Close();
        //    return true;
        //}

        //public bool GetOrderByInventaryId(int inventaryId)
        //{
        //    sms.GetOrderByInventaryIdSQLCommand();

        //    sms.smsCmd.CommandType = CommandType.StoredProcedure;
        //    sms.smsCmd.Parameters.Add("@inventaryId", SqlDbType.Int).Value = inventaryId;
        //    sms.smssms.Open();
        //    object o = sms.smsCmd.ExecuteScalar();
        //    if (o != null)
        //    {
        //        string id = o.ToString();
        //    }
        //    sms.smssms.Close();
        //    return true;
        //}
    }
}