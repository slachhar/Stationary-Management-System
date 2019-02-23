using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SMS_Api.Application.Orders;
using SMS_Library.Business;

namespace SMS_Api.Controllers
{
    public class OrdersController : ApiController
    {
        // GET: api/Orders
        public IEnumerable<Order> Get()
        {
			return new List<Order>();
        }

        // GET: api/Orders/5
        public Order Get(int id)
        {
            OrderServerCommands orderCreate = new OrderServerCommands();            
            return orderCreate.GetCommand(id);
        }

        // POST: api/Orders
        public void Post(Order order)
        {
            OrderServerCommands orderCreate = new OrderServerCommands();
            orderCreate.CreateCommand(order);
        }

        // PUT: api/Orders/5
        public void Put(int id, Order order)
        {
            OrderServerCommands orderCreate = new OrderServerCommands();
            orderCreate.EditCommand(order);
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
            OrderServerCommands orderCreate = new OrderServerCommands();
            orderCreate.DeleteCommand(id);
        }
    }
}
