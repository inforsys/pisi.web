using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Pisi.Payslip.Contract
{

        [ServiceContract(Namespace = "https://pisi.web/service/payslip/0/0/1")]
        public interface IPayslipService
        {
            [OperationContract]
            IList<PayslipPeriod> FindAllPublishedPeriodForEmployee(string employeeid);
            [OperationContract]
            Payroll LoadPayrollForEmployee(string employeeid, string payrollid);
            [OperationContract]
            IList<PayrollAllowance> LoadPayrollAllowances(string employeeid, string payrollid);
            [OperationContract]
            IList<PayrollDeduction> LoadPayrollDeductions(string employeeid, string payrollid);
        }

        public interface IPayslipChannel : IPayslipService, IClientChannel { }

}
