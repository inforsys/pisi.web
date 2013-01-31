using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pisi.Payslip.Contract
{
    public class PayrollDeduction
    {
        public string EmployeeID { get; set; }
        public string PayrollID { get; set; }
        public string DeductionID { get; set; }
        public string DeductionName { get; set; }
        public string CurrencyID { get; set; }
        public decimal Rate { get; set; }
        public decimal Normal { get; set; }
        public decimal ExcRate { get; set; }
        public bool Taxable { get; set; }
    }
}
