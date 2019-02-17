using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Library.Business.Models
{
    public class Institution
    {
        public int InstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public int Rank { get; set; }
        public int InstitutionTypeId { get; set; }
    }

    public class InstitutionType
    {
        public int InstitutionTypeId { get; set; }
        public string InstitutionTypeName { get; set; }
    }
}
