using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_App.Business.Models
{
    public interface IOrder
    {
        bool Create(IOrder order);
        IOrder Edit(IOrder order);
        bool Delete(IOrder order);
    }
}
