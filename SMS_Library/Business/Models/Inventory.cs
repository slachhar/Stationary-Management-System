using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Library.Business.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int InventoryTypeId { get; set; }
        public string InventoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int MinRequiredQuantity { get; set; }
        public int MaxRequiredQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public class InventoryType
    {
        public int InventoryTypeId { get; set; }
        public string InventoryTypeName { get; set; }
    }
}
