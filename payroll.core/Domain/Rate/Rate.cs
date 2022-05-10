using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.core.Domain.Rate
{
   public partial class Rate:BaseEntity
    {
        public string day { get; set; }
        public DateTime HourStart { get; set; }
        public DateTime HourEnd { get; set; }
       
    }
}
