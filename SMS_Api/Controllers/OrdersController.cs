using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using SMS_Api.Application.Orders;
using SMS_Api.Common.Settings;
using SMS_Library.Repositories;

namespace SMS_Api.Controllers
{
    public class OrdersController : ApiController
    {
		public IOrderRepository OrderRepository { get; set; }
		public OrdersController(IOrderRepository orderRepository)
		{
			this.OrderRepository = orderRepository;
		}
        // GET: api/Orders
        public JsonResult<IEnumerable<SMS_Library.Business.Models.Order>> Get()
        {
            return Json(OrderRepository.GetAllOrdersCommand(), JsonResponseSettings.SetJsonSerializerSettings());
        }

        // GET: api/Orders/5
        public JsonResult<SMS_Library.Business.Models.Order> Get(int id)
        {
            return Json(OrderRepository.GetCommand(id), JsonResponseSettings.SetJsonSerializerSettings());
        }

        // POST: api/Orders
        public void Post(SMS_Library.Business.Models.Order order)
        {
			OrderRepository.CreateCommand(order);
        }

        // PUT: api/Orders/5
        public void Put(int id, SMS_Library.Business.Models.Order order)
        {
			OrderRepository.EditCommand(order);
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
			OrderRepository.DeleteCommand(id);
        }
    }
}
