using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payroll.data.Repository;
namespace payroll.service.Repository
{
    public class Services : IServices
    {
        private readonly IRepository _irepository;
        
        public Services()
        {
            this._irepository =new  RepositoryFileDB();
        }
        public double GetRate(string day, DateTime hourstart, DateTime hourend)
        {
            return _irepository.GetRate(day, hourstart, hourend);
        }
    }
}
