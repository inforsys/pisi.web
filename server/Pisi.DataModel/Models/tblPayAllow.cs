using System;
using System.Collections.Generic;

namespace Pisi.DataModel.Models
{
    public class tblPayAllow
    {
        public string EmployeeID { get; set; }
        public string PayrollID { get; set; }
        public string AllowanceID { get; set; }
        public string CurrencyID { get; set; }
        public Nullable<decimal> palRate { get; set; }
        public Nullable<decimal> palNormal { get; set; }
        public Nullable<decimal> palExcRate { get; set; }
        public bool palTaxAble { get; set; }
        public string Computer { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
    }
}
