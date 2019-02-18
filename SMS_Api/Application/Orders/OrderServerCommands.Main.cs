using SMS_Library.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMS_Library.Business;

namespace SMS_Api.Application.Orders
{
    public partial class OrderServerCommands
    {
        public bool CreateCommand(Order order)
        {
            return Create(order);
        }

        public bool DeleteCommand(Order order)
        {
            return Delete(order);
        }

        public Order EditCommand(Order order)
        {
            return Edit(order);
        }
    }
}