using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisi.MasterData.Contract;
using Pisi.MasterData;

namespace Pisi.Services
{
    //public class Payslip:IPayslipService
    public partial class PisiServices : IPeriodService
    {
        public IList<PayrollPeriod> FindAllPublishedPeriod()
        {
            PeriodRepository repo = new PeriodRepository();
            return repo.LoadAllPeriod();
        }
    }
}
