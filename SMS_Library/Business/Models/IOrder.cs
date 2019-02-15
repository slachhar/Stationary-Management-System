using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Library.Business
{
	public interface IOrder
	{
		bool CreateOrder(Order order);
		Order EditOrder(Order order);
		bool DeleteOrder(Order order);
	}
}
