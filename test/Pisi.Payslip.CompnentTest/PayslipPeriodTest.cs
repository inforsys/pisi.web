using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pisi.Payslip.Contract;

namespace Pisi.Payslip.CompnentTest
{
    [TestClass]
    public class PayslipPeriodTest
    {
        [TestMethod]
        public void LoadAllPeriodForAnEmployee()
        {
            PayslipRepository payRepo = new PayslipRepository();
            IList<PayslipPeriod> list = payRepo.LoadPayslipPeriodForEmployee("0007");
            Assert.IsTrue(list.Count > 0);
        }
    }
}
