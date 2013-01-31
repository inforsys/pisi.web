using System;
using System.Collections.Generic;

namespace Pisi.DataModel.Models
{
    public class tblPayroll
    {
        public string EmployeeID { get; set; }
        public string PayrollID { get; set; }
        public string DepartmentID { get; set; }
        public string CategoryID { get; set; }
        public string CostCentreID { get; set; }
        public string DesignationID { get; set; }
        public string MaritalID { get; set; }
        public string PaymentID { get; set; }
        public string WifeID { get; set; }
        public string GroupID { get; set; }
        public string CurrencyID { get; set; }
        public Nullable<short> payWorkDay { get; set; }
        public Nullable<decimal> payBase { get; set; }
        public Nullable<decimal> payExcBase { get; set; }
        public string CurOTRate { get; set; }
        public Nullable<decimal> payOThrs { get; set; }
        public Nullable<decimal> payOTRate { get; set; }
        public Nullable<decimal> payExcOTRate { get; set; }
        public Nullable<decimal> payJHTCo { get; set; }
        public Nullable<decimal> payJHTEmp { get; set; }
        public Nullable<decimal> payJKK { get; set; }
        public Nullable<decimal> payJKM { get; set; }
        public Nullable<decimal> payJPK { get; set; }
        public Nullable<decimal> payTax { get; set; }
        public Nullable<decimal> payTaxAllowance { get; set; }
        public Nullable<decimal> payGrossTax { get; set; }
        public Nullable<decimal> payGrossAssure { get; set; }
        public Nullable<decimal> payTitle { get; set; }
        public Nullable<decimal> payNonTaxable { get; set; }
        public Nullable<short> TaxID { get; set; }
        public bool payAssurance { get; set; }
        public Nullable<int> TakeHome { get; set; }
        public Nullable<int> Bank { get; set; }
        public bool payJHTEmpPaidCo { get; set; }
        public Nullable<decimal> payLastBase { get; set; }
        public Nullable<decimal> payLastOThrs { get; set; }
        public Nullable<decimal> payLastOTRate { get; set; }
        public Nullable<decimal> payDepSave { get; set; }
        public Nullable<decimal> payDepPaid { get; set; }
        public string payDepID { get; set; }
        public Nullable<decimal> payBonusTax { get; set; }
        public Nullable<decimal> payPesangonGross { get; set; }
        public Nullable<decimal> payBonusAllowTax { get; set; }
        public Nullable<decimal> payPesangonTax { get; set; }
        public Nullable<decimal> payPesangonAllowTax { get; set; }
        public Nullable<decimal> payBonusGross { get; set; }
        public Nullable<decimal> payRefundTax { get; set; }
        public Nullable<decimal> payUnderpaidTax { get; set; }
        public Nullable<decimal> payOverpaidTax { get; set; }
        public Nullable<decimal> payTaxByGov { get; set; }
        public Nullable<decimal> payMonthValue { get; set; }
        public string payLastParam { get; set; }
        public string Computer { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<decimal> payMonNum { get; set; }
        public Nullable<decimal> SubBase { get; set; }
        public Nullable<decimal> OT { get; set; }
        public Nullable<decimal> SubPayroll { get; set; }
        public Nullable<decimal> Allow { get; set; }
        public Nullable<decimal> Dedu { get; set; }
        public Nullable<decimal> AllowTax { get; set; }
        public Nullable<decimal> DeduTax { get; set; }
        public Nullable<decimal> TaxAllow { get; set; }
        public Nullable<decimal> TaxPaid { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> payFineTax { get; set; }
        public Nullable<decimal> payFineTaxAllow { get; set; }
        public Nullable<bool> FineTaxID { get; set; }
        public string NPWP { get; set; }
    }
}
