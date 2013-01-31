using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisi.Payslip.Contract;
using Pisi.Payslip;

namespace Pisi.Services
{
    public partial class PisiServices:IPayslipService
    {
       
        public IList<PayslipPeriod> FindAllPublishedPeriodForEmployee(string employeeid)
        {
            return new PayslipRepository().LoadPayslipPeriodForEmployee(employeeid);
        }


        public Payroll LoadPayrollForEmployee(string employeeid, string payrollid)
        {
            return new PayslipRepository().LoadPayrollForEmployee(employeeid, payrollid);
        }

        public IList<PayrollAllowance> LoadPayrollAllowances(string employeeid, string payrollid)
        {
            return new PayslipRepository().LoadAllowanceForEmployee(employeeid, payrollid);
        }

        public IList<PayrollDeduction> LoadPayrollDeductions(string employeeid, string payrollid)
        {
            return new PayslipRepository().LoadDeductionForEmployee(employeeid, payrollid);
        }
    }
}
