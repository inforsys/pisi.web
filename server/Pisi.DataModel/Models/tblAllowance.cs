using System;
using System.Collections.Generic;

namespace Pisi.DataModel.Models
{
    public class tblAllowance
    {
        public string AllowanceID { get; set; }
        public string aloName { get; set; }
        public string COAID { get; set; }
        public string CurrencyID { get; set; }
        public bool aloTaxable { get; set; }
        public bool aloAssurance { get; set; }
        public string aloColumn { get; set; }
        public string aloNormal { get; set; }
        public string aloFormula { get; set; }
        public string aloProportional { get; set; }
        public bool aloProrate { get; set; }
        public bool aloSetup { get; set; }
        public Nullable<short> aloSequence { get; set; }
        public bool aloExecute { get; set; }
        public bool aloUnlimited { get; set; }
        public bool aloCheck { get; set; }
        public bool aloTakeHome { get; set; }
        public bool aloOTRate { get; set; }
        public bool aloAbsent { get; set; }
        public bool aloBonus { get; set; }
        public bool aloPesangon { get; set; }
        public bool aloYearlyBonus { get; set; }
        public string Computer { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<bool> alofix { get; set; }
        public Nullable<bool> aloTaxPayByCom { get; set; }
    }
}
