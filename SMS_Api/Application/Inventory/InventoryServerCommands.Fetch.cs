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
		public static SMS_Library.Business.Models.Inventary GetInventoryByInventoryId(int inventoryId)
		{
			StationaryManagementSystem.SetSQLCommand(DBConstants.GetInventoryById);

			StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
			StationaryManagementSystem.smsCmd.Parameters.Add("@InventoryId", SqlDbType.Int).Value = inventoryId;
			StationaryManagementSystem.smsConn.Open();
			StationaryManagementSystem.SqlReader();

			SMS_Library.Business.Models.Inventary inventory = null;
			while (StationaryManagementSystem.reader.Read())
			{
				inventory = new SMS_Library.Business.Models.Inventary();
				inventory.InventoryId = int.Parse(StationaryManagementSystem.reader["InventoryId"].ToString());
				inventory.InstitutionId = int.Parse(StationaryManagementSystem.reader["InstitutionId"].ToString());
				inventory.InventoryTypeId = int.Parse(StationaryManagementSystem.reader["InventoryTypeId"].ToString());
				inventory.MarkUpId = int.Parse(StationaryManagementSystem.reader["MarkUpId"].ToString());
			}
			StationaryManagementSystem.reader.Close();
			StationaryManagementSystem.smsConn.Close();
			return inventory;
		}

		public static IEnumerable<SMS_Library.Business.Models.Inventary> GetAllInventorys()
		{
			StationaryManagementSystem.SetSQLCommand(DBConstants.GetInventory);

			StationaryManagementSystem.smsCmd.CommandType = CommandType.StoredProcedure;
			StationaryManagementSystem.smsConn.Open();
			StationaryManagementSystem.SqlReader();
			List<SMS_Library.Business.Models.Inventary> inventoryList = new List<SMS_Library.Business.Models.Inventary>();
			SMS_Library.Business.Models.Inventary inventory = null;
			while (StationaryManagementSystem.reader.Read())
			{
				inventory = new SMS_Library.Business.Models.Inventary();
				inventory.InventoryId = int.Parse(StationaryManagementSystem.reader["InventoryId"].ToString());
				inventory.InstitutionId = int.Parse(StationaryManagementSystem.reader["InstitutionId"].ToString());
				inventory.InventoryTypeId = int.Parse(StationaryManagementSystem.reader["InventoryTypeId"].ToString());
				inventory.MarkUpId = int.Parse(StationaryManagementSystem.reader["MarkUpId"].ToString());
				inventoryList.Add(inventory);
			}
			StationaryManagementSystem.reader.Close();
			StationaryManagementSystem.smsConn.Close();
			return inventoryList;
		}

	}
}