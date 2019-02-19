using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_App.Business.Models
{
    public class Inventary
    {
        public int InventaryId { get; set; }
        public int InventaryTypeId { get; set; }
        public string InventaryName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int MinRequiredQuantity { get; set; }
        public int MaxRequiredQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UndatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public class InventaryType
    {
        public int InventaryTypeId { get; set; }
        public string InventaryTypeName { get; set; }
    }
}
