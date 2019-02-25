using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_Library.Business.Models;

namespace SMS_Library.Repositories
{
	public interface IOrderRepository
	{
		IEnumerable<Order> GetAllOrdersCommand();
		Order GetCommand(int orderId);
		bool CreateCommand(Order order);
		bool DeleteCommand(int orderId);
		bool EditCommand(Order order);

	}
}
