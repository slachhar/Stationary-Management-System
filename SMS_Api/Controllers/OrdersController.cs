using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
            return new Order();
        }

        // POST: api/Orders
        public void Post([FromBody]Order order)
        {
            
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
