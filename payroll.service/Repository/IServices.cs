using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.service.Repository
{
    public interface IServices
    {
        double GetRate(string day, DateTime hourstart, DateTime hourend);
    }
}
