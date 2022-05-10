using payroll.core.Domain.Employee;
using payroll.core.Domain.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.core
{
    /// <summary>
    /// Tranformation Class Transform string in employee object
    /// </summary>
    public class DataTransformation : IDataTransformation
    {
        /// <summary>
        /// Convert String data in object.
        /// </summary>
        /// <param name="Data">The employee entry</param>
        /// <returns></returns>
        public Employee StringTransformation(string data)
        {

           
            Employee employee = new Employee();
            Rate rate;
            try
            {
                employee.Name = data.Split('=')[0];

                string dataday = data.Split('=')[1];
                string[] date = dataday.Split(',');

                foreach (var item in date)
                {
                    rate = new Rate();
                    rate.day = item.Substring(0, 2);
                    string hours = item.Substring(2, item.Length - 2);

                    rate.HourStart = Convert.ToDateTime(hours.Split('-')[0]);
                    rate.HourEnd = Convert.ToDateTime(hours.Split('-')[1]);
                    employee.Rates.Add(rate);

                }
                return employee;
            }
            catch (Exception )
            {

                throw new Exception("Data Invalid Format, Please Check the Entry") ;
            }
            
        }
    }
}
