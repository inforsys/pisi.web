using System;
using System.Collections.Generic;

namespace Pisi.DataModel.Models
{
    public class tblPayDedu
    {
        public string EmployeeID { get; set; }
        public string PayrollID { get; set; }
        public string DeductionID { get; set; }
        public string CurrencyID { get; set; }
        public Nullable<decimal> padRate { get; set; }
        public Nullable<decimal> padNormal { get; set; }
        public Nullable<decimal> padExcRate { get; set; }
        public bool padTaxable { get; set; }
        public string Computer { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
    }
}
