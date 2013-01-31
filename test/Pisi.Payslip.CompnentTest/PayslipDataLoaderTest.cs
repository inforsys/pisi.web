using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pisi.Payslip.Contract;

namespace Pisi.Payslip.CompnentTest
{
  
    [TestClass]
    public class PayslipDataLoaderTest
    {

        [TestMethod]
        public void LoadPayrollForEmployeeInPeriod()
        {
            PayslipRepository payRepo = new PayslipRepository();
            Payroll payroll=payRepo.LoadPayrollForEmployee("0007", "200402");

            Assert.IsNotNull(payroll);
        }

        [TestMethod]
        public void NullableValueTest()
        {
            short? nullvar = null;
            Assert.IsFalse(nullvar.HasValue);
           // Assert.AreEqual(0, nullvar.Value); error no value
            short nolvar = nullvar.HasValue ? nullvar.Value : new short() ;
            Assert.AreEqual(0, nolvar);
            short? satuvar = 1;
            Assert.AreEqual(1, satuvar.Value);
        }
        [TestMethod]
        public void LoadAllowanceForEmployeeInPeriod()
        {
            PayslipRepository payRepo = new PayslipRepository();
            IList<PayrollAllowance> allowance = payRepo.LoadAllowanceForEmployee("H107", "201212");

            Assert.IsNotNull(allowance);
        }
        [TestMethod]
        public void LoadDeductionForEmployeeInPeriod()
        {
            PayslipRepository payRepo = new PayslipRepository();
            IList<PayrollDeduction> allowance = payRepo.LoadDeductionForEmployee("H107", "201212");

            Assert.IsNotNull(allowance);
        }
    }
}
