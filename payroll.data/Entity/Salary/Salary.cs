using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.data.Domain.Salary
{
   partial class Salary:BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime Hour { get; set; }
        public string Currency { get; set; }
    }
}
