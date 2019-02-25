using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_Library.Business.Models;
using SMS_Api.Application.Orders;

namespace SMS_Library.Repositories
{
	public class OrderRepository : IOrderRepository
	{
		public IEnumerable<Order> GetAllOrdersCommand()
		{
			return OrderServerCommands.GetAllOrders();
		}

		public Order GetCommand(int orderId)
		{
			return OrderServerCommands.GetOrderByOrderId(orderId);
		}

		public bool CreateCommand(Order order)
		{
			return OrderServerCommands.CreateOrder(order);
		}

		public bool DeleteCommand(int orderId)
		{
			return OrderServerCommands.DeleteOrder(orderId);
		}

		public bool EditCommand(Order order)
		{
			return OrderServerCommands.UpdateOrder(order);
		}
	}
}
