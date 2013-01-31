using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisi.MasterData.Contract;

namespace Pisi.MasterData.Services
{
    //public class Payslip:IPayslipService
    public partial class PayrollServices : IPayslipService
    {
        public IList<PayrollPeriod> FindAllPublishedPeriod()
        {
            return new List<PayrollPeriod> { 
                new PayrollPeriod{
                    Code = "201301",
                    Name = "Januari 2013"
                }
            };

            //PeriodRepository repo = new PeriodRepository();
            //return repo.LoadAllPeriod();
        }
    }
}
