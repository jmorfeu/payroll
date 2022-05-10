using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.core.Domain.Employee
{
  public partial  class Employee: BaseEntity
    {
      public  Employee()
        {
            Rates = new List<Rate.Rate>();
        }
        public string Name { get; set; }
        public List<Rate.Rate> Rates { get; set; }


    }
}
