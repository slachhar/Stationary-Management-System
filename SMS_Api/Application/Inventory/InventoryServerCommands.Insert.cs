using SMS_Api.Common.Constants;
using SMS_Api.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMS_Api.Application.Inventory
{
    public static partial class InventoryServerCommands
    {
        public static bool CreateInventory(SMS_Library.Business.Models.Inventory inventory)
        {
            try
            {
                StationaryManagementSystem.SetSQLCommand(DBConstants.InventoryCreate);

                StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
                StationaryManagementSystem.smsCmd.Parameters.Add("@InventoryTypeId", SqlDbType.Int).Value = inventory.InventoryTypeId;
                StationaryManagementSystem.smsCmd.Parameters.Add("@InventoryName", SqlDbType.NVarChar).Value = inventory.InventoryName;
                StationaryManagementSystem.smsCmd.Parameters.Add("@UnitPrice", SqlDbType.Int).Value = inventory.UnitPrice;
                StationaryManagementSystem.smsCmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = inventory.Quantity;
                StationaryManagementSystem.smsCmd.Parameters.Add("@MinRequiredQuantity", SqlDbType.Int).Value = inventory.MinRequiredQuantity;
                StationaryManagementSystem.smsCmd.Parameters.Add("@MaxRequiredQuantity", SqlDbType.Int).Value = inventory.MaxRequiredQuantity;
                StationaryManagementSystem.smsCmd.Parameters.Add("@UpdatedBy", SqlDbType.Int).Value = inventory.UpdatedBy;
                StationaryManagementSystem.smsCmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = inventory.CreatedBy;
                StationaryManagementSystem.smsConn.Open();
                object o = StationaryManagementSystem.smsCmd.ExecuteScalar();
                if (o != null)
                {
                    string id = o.ToString();
                }
            }
            finally
            {
                StationaryManagementSystem.smsConn.Close();
            }
            return true;
        }
    }
}