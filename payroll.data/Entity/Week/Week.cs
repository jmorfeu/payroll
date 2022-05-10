using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.data.Domain.Week
{
    partial class Week:BaseEntity
    {
        public string ShortDayOfWeek { get; set; }
        public string dayOfWeek { get; set; }
    }
}
