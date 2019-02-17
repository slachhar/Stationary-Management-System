using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Library.Business.Models
{
    public class MarkUp
    {
        public int MarkUpId { get; set; }
        public int InstitutionId { get; set; }
        public decimal Charge { get; set; }
    }
}
