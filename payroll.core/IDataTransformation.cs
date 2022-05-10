using payroll.core.Domain.Employee;
using payroll.core.Domain.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.core
{
  public interface IDataTransformation
    {
        Employee StringTransformation(string data);

    }
}
