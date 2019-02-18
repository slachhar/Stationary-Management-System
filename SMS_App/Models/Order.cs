using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_App.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int InstitutionId { get; set; }
        public int InventaryId { get; set; }
        public int RequestedQuantity { get; set; }
        public DateTime ExpectedOrderDate { get; set; }
        public int MarkUpId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        
    }
}
