using payroll.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll
{
    class Program
    {



        static void Main(string[] args)
        {

            ICalculatePayroll calculatePayroll = new CalculateTxtPayroll();


            Console.WriteLine(" ========================================================");
            Console.WriteLine("|                      Payroll System                    |");
            Console.WriteLine(" ========================================================");
            Console.WriteLine("Ie. Astrid=mo10:00-12:00,th12:00-14:00,su20:00-21:00");
            Console.WriteLine("Please enter Employee's data: ");
            string data = Console.ReadLine();

            try
            {

                var _result = calculatePayroll.CalculateSalary(data);
                Console.WriteLine("The Amount to pay {0} is: {1} USD", _result.Employee.Name, _result.Salary);

            }
            catch (Exception Ex)
            {

                Console.WriteLine(Ex.Message);
            }

            Console.ReadKey();


        }
    }
}
