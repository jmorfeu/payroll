using payroll.core.Domain.Employee;
using payroll.core.Domain.Payment;
using payroll.core.Domain.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.core
{
    /// <summary>
    /// Represents the method for calculating rates by hour
    /// </summary>
    public   interface ICalculatePayroll
    {
        double Salary(double salary, double rate);
        void Employee();
        double GetRate(string day, DateTime hourIni, DateTime hourfinally);
        double CalculateHourofWork(DateTime hourIni, DateTime hourfinally);
        double CalculateSalary(Employee employee);
        Payment CalculateSalary(string data);
    }
}
