using SMS_Api.Common.Constants;
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
        public static SMS_Library.Business.Models.Order GetOrderByOrderId(int orderId)
        {
            SMS_Library.Business.Models.Order order = null;
            try
            {
                StationaryManagementSystem.SetSQLCommand(DBConstants.GetOrderById);

                StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
                StationaryManagementSystem.smsCmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = orderId;
                StationaryManagementSystem.smsConn.Open();
                StationaryManagementSystem.SqlReader();

                
                while (StationaryManagementSystem.reader.Read())
                {
                    order = new SMS_Library.Business.Models.Order();
                    order.OrderId = int.Parse(StationaryManagementSystem.reader["OrderId"].ToString());
                    order.InstitutionId = int.Parse(StationaryManagementSystem.reader["InstitutionId"].ToString());
                    order.InventaryId = int.Parse(StationaryManagementSystem.reader["InventaryId"].ToString());
                    order.MarkUpId = int.Parse(StationaryManagementSystem.reader["MarkUpId"].ToString());
                }
            }
            finally
            {
                StationaryManagementSystem.reader.Close();
                StationaryManagementSystem.smsConn.Close();
            }
            return order;
        }

        public static IEnumerable<SMS_Library.Business.Models.Order> GetAllOrders()
        {
            StationaryManagementSystem.SetSQLCommand(DBConstants.GetOrder);

            StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
            StationaryManagementSystem.smsConn.Open();
            StationaryManagementSystem.SqlReader();
            List<SMS_Library.Business.Models.Order> orderList = new List<SMS_Library.Business.Models.Order>();
            SMS_Library.Business.Models.Order order = null;
            while (StationaryManagementSystem.reader.Read())
            {
                order = new SMS_Library.Business.Models.Order();
                order.OrderId = int.Parse(StationaryManagementSystem.reader["OrderId"].ToString());
                order.InstitutionId = int.Parse(StationaryManagementSystem.reader["InstitutionId"].ToString());
                order.InventaryId = int.Parse(StationaryManagementSystem.reader["InventaryId"].ToString());
                order.MarkUpId = int.Parse(StationaryManagementSystem.reader["MarkUpId"].ToString());
                orderList.Add(order);
            }
            StationaryManagementSystem.reader.Close();
            StationaryManagementSystem.smsConn.Close();
            return orderList;
        }

        //public bool GetOrderByInstitutionId(int institutionId)
        //{
        //    StationaryManagementSystem.GetOrderByInstitutionIdSQLCommand();

        //    StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
        //    StationaryManagementSystem.smsCmd.Parameters.Add("@institutionId", SqlDbType.Int).Value = institutionId;
        //    StationaryManagementSystem.smsStationaryManagementSystem.Open();
        //    object o = StationaryManagementSystem.smsCmd.ExecuteScalar();
        //    if (o != null)
        //    {
        //        string id = o.ToString();
        //    }
        //    StationaryManagementSystem.smsStationaryManagementSystem.Close();
        //    return true;
        //}

        //public bool GetOrderByInventaryId(int inventaryId)
        //{
        //    StationaryManagementSystem.GetOrderByInventaryIdSQLCommand();

        //    StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
        //    StationaryManagementSystem.smsCmd.Parameters.Add("@inventaryId", SqlDbType.Int).Value = inventaryId;
        //    StationaryManagementSystem.smsStationaryManagementSystem.Open();
        //    object o = StationaryManagementSystem.smsCmd.ExecuteScalar();
        //    if (o != null)
        //    {
        //        string id = o.ToString();
        //    }
        //    StationaryManagementSystem.smsStationaryManagementSystem.Close();
        //    return true;
        //}
    }
}