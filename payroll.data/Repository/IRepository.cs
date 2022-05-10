using payroll.data.Domain.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.data.Repository
{
    public interface IRepository
    {
        double GetRate(string day, DateTime hourstart, DateTime hourend);
        List<Rate> Getdata();
    }
}
