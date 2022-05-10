using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payroll.core.Domain.Employee;
using payroll.core.Domain.Payment;
using payroll.core.Domain.Rate;
using payroll.service.Repository;

namespace payroll.core
{
    /// <summary>
    /// Represent a Payroll Calculation.
    /// </summary>
    public class CalculateTxtPayroll : ICalculatePayroll
    {
        private readonly IServices _iService;
        private readonly IDataTransformation _dataTransformation;
        private double Pay { get; set; }
        public CalculateTxtPayroll()
        {
            _iService = new Services();
            _dataTransformation = new DataTransformation();
        }
        public double CalculateHourofWork(DateTime hourIni, DateTime hourfinally)
        {
            try
            {
                return hourfinally.Subtract(hourIni).TotalHours;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Employee()
        {
            throw new NotImplementedException();
        }
        public double GetRate(string day, DateTime hourstart, DateTime hourend)
        {
            try
            {
                double Amount = _iService.GetRate(day, hourstart, hourend);
                return Amount;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public double Salary(double salary, double rate)
        {
            return Pay += salary * rate;
        }
        /// <summary>
        /// Ensures to use DataTransformation to convert String data to employee object.
        /// </summary>
        /// <param name="employee">The employee object</param>
        /// <returns>double</returns>
        public double CalculateSalary(Employee employee)
        {
            double salary = 0;
            foreach (var item in employee.Rates)
            {
                var rate = GetRate(item.day, item.HourStart, item.HourEnd);
                var hour = CalculateHourofWork(item.HourStart, item.HourEnd);
                salary = Salary(hour, rate);
            }
            return salary;
        }
        /// <summary>
        /// CalculateSalary string ensure to use correct data structure Name=dayhourInitial-hourFinal.
        /// </summary>
        /// <param name="data">The payroll data</param>
        /// <returns>double</returns>

        public Payment CalculateSalary(string data)
        {
            Employee employee = _dataTransformation.StringTransformation(data);
            Payment payment = new Payment();
            double salary = 0;
            foreach (var item in employee.Rates)
            {
                var rate = GetRate(item.day, item.HourStart, item.HourEnd);
                var hour = CalculateHourofWork(item.HourStart, item.HourEnd);
                salary = Salary(hour, rate);
            }
            payment.Employee = employee;
            payment.Salary = salary;

            return payment;
        }
    }
}
