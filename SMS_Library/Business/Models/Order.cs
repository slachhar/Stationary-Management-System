using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Library.Business
{
	public class Order : IOrder
	{
		#region Properties
		public int OrderId { get; set; }
		public int InstitutionId { get; set; }
		public int InstitutionType { get; set; }
		public Dictionary<StationaryItem, int> StationaryItems { get; set; }

		#endregion

		#region Methods
		public virtual bool CreateOrder(Order order)
		{
			throw new NotImplementedException();
		}

		public virtual bool DeleteOrder(Order order)
		{
			throw new NotImplementedException();
		}

		public virtual Order EditOrder(Order order)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
