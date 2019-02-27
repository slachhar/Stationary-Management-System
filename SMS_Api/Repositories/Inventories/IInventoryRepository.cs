using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Api.Repositories.Inventories
{
	public interface IInventoryRepository
	{
		IEnumerable<Inventary> GetAllInventoriesCommand();
		Inventary GetInventoryByIdCommand(int orderId);
		bool CreateInventoryCommand(Inventary inventary);
		bool DeleteInventoryCommand(int inventaryId);
		bool EditInventoryCommand(Inventary inventary);
	}
}