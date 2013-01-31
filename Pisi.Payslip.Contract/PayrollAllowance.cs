using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pisi.Payslip.Contract
{
    public class PayrollAllowance
    {
        public string EmployeeID { get; set; }
        public string PayrollID { get; set; }
        public string AllowanceID { get; set; }
        public string AllowanceName { get; set; }
        public string CurrencyID { get; set; }
        public decimal Rate { get; set; }
        public decimal Normal { get; set; }
        public decimal ExcRate { get; set; }
        public bool Taxable { get; set; }
    }
}
