using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.data.Domain.Payment
{
   partial class Payment:BaseEntity
    {
        public int IdPago { get; set; }
        public Salary.Salary Salary { get; set; }


    }
}
