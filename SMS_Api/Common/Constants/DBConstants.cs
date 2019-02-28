using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Api.Common.Constants
{
	public static class DBConstants
	{
		#region StoredProcedure Names
		public const string GetOrder = "GetOrder";
		public const string GetOrderById = "GetOrderById";
		public const string OrderCreate = "OrderCreate";
		public const string UpdateOrder = "UpdateOrder";
		public const string DeleteOrder = "DeleteOrder";
        public const string InventoryCreate = "InventoryCreate";
        #endregion

    }
}