using System;
using System.Collections.Generic;

namespace Pisi.DataModel.Models
{
    public class tblDeduction
    {
        public string DeductionID { get; set; }
        public string dedName { get; set; }
        public string COAID { get; set; }
        public string CurrencyID { get; set; }
        public bool dedTaxable { get; set; }
        public bool dedAssurance { get; set; }
        public bool dedRefund { get; set; }
        public string dedColumn { get; set; }
        public string dedNormal { get; set; }
        public string dedFormula { get; set; }
        public string dedProportional { get; set; }
        public bool dedProrate { get; set; }
        public bool dedSetup { get; set; }
        public Nullable<short> dedSequence { get; set; }
        public bool dedExecute { get; set; }
        public bool dedUnlimited { get; set; }
        public bool dedCheck { get; set; }
        public bool dedTakeHome { get; set; }
        public bool dedOTRate { get; set; }
        public string Computer { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
    }
}
