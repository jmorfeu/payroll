using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.core.Domain.Payment
{
  public partial class Payment:BaseEntity
    {
        public int IdPago { get; set; }
        public double Salary { get; set; }
        public Employee.Employee Employee { get; set; }

    }
}
