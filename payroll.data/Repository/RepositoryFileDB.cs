using payroll.data.Domain.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.data.Repository
{
    public class RepositoryFileDB : IRepository
    {
        public List<Rate> Getdata()
        {
           try
            {
                return Getdatabyfile();


            }
          
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public double GetRate(string day, DateTime hourstart, DateTime hourend)
        {
            try
            {
                double Amount = 0;
                var data = (from a in Getdata()
                              where (a.day == day) && ((a.HourStart >= hourstart && a.HourStart >= hourend) ||
                              (a.HourEnd >= hourstart && a.HourEnd >= hourend))
                              select a.Amount);

                if (!data.Any())
                {
                    Amount= (from a in Getdata()
                                  where (a.day == day )
                                  select a.Amount).Last();
                }
                else
                {
                    Amount = data.FirstOrDefault();
                }

                return Amount;
              
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private List<Rate> Getdatabyfile()
        {
            string path = System.Configuration.ConfigurationManager.AppSettings["path"].ToString();
            string[] rate = System.IO.File.ReadAllLines(path);
            List<Rate> RateList = new List<Rate>();

            foreach (var item in rate)
            {

                Rate Rate = new Rate();
                Rate.day = item.Split(',')[0];
                Rate.HourStart = Convert.ToDateTime(item.Split(',')[1]);
                Rate.HourEnd = Convert.ToDateTime(item.Split(',')[2]);
                Rate.Amount = Convert.ToDouble(item.Split(',')[3]);
                RateList.Add(Rate);


            }

            return RateList.ToList();
        }

      
    }
}
