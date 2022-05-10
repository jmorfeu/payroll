using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace payroll.core.test
{
    [TestClass]
    public class CalculateTxtPayrollTest
    {



        [TestMethod]
        public void CalculateHourofWork()
        {
            CalculateTxtPayroll calculatePayroll = new CalculateTxtPayroll();
            double hours = calculatePayroll.CalculateHourofWork(Convert.ToDateTime("14:00"), Convert.ToDateTime("16:00"));
            Assert.AreEqual(2, hours);
        }

        [TestMethod]
        public void GetRate()
        {

            CalculateTxtPayroll calculatePayroll = new CalculateTxtPayroll();

            Assert.AreEqual(30, calculatePayroll.GetRate("su", Convert.ToDateTime("00:01"), Convert.ToDateTime("08:00")));
            Assert.AreEqual(20, calculatePayroll.GetRate("su", Convert.ToDateTime("10:01"), Convert.ToDateTime("17:00")));
            Assert.AreEqual(25, calculatePayroll.GetRate("su", Convert.ToDateTime("18:30"), Convert.ToDateTime("22:00")));


        }
        [TestMethod]
        public void CalculateSalary()

        {

            CalculateTxtPayroll calculatePayroll = new CalculateTxtPayroll();
            DataTransformation dataTransformation = new DataTransformation();
            string data = "Astrid=mo10:00-12:00,th12:00-14:00,su20:00-21:00";
            

            Assert.AreEqual(85, calculatePayroll.CalculateSalary(dataTransformation.StringTransformation(data)));



        }

    }
}
