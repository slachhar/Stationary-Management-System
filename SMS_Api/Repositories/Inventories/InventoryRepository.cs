using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Api.Repositories.Inventories
{
	public class InventoryRepository : IInventoryRepository
	{
		public bool CreateInventoryCommand(Inventary inventary)
		{
			throw new NotImplementedException();
		}

		public bool DeleteInventoryCommand(int inventaryId)
		{
			throw new NotImplementedException();
		}

		public bool EditInventoryCommand(Inventary inventary)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Inventary> GetAllInventoriesCommand()
		{
			throw new NotImplementedException();
		}

		public Inventary GetInventoryByIdCommand(int orderId)
		{
			throw new NotImplementedException();
		}
	}
}