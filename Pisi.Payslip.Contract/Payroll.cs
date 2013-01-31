using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pisi.Payslip.Contract
{
    public class Payroll
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
        public short WorkDay { get; set; }
        public decimal Base { get; set; }
        public decimal ExcBase { get; set; }
        public string CurOTRate { get; set; }
        public decimal OThrs { get; set; }
        public decimal OTRate { get; set; }
        public decimal ExcOTRate { get; set; }
        public decimal JHTCo { get; set; }
        public decimal JHTEmp { get; set; }
        public decimal JKK { get; set; }
        public decimal JKM { get; set; }
        public decimal JPK { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAllowance { get; set; }
        public decimal GrossTax { get; set; }
        public decimal GrossAssure { get; set; }
        public decimal Title { get; set; }
        public decimal NonTaxable { get; set; }
        public short TaxID { get; set; }
        public bool Assurance { get; set; }
        public int TakeHome { get; set; }
        public int Bank { get; set; }
        public bool JHTEmpPaidCo { get; set; }
        public decimal LastBase { get; set; }
        public decimal LastOThrs { get; set; }
        public decimal LastOTRate { get; set; }
        public decimal DepSave { get; set; }
        public decimal DepPaid { get; set; }
        public string DepID { get; set; }
        public decimal BonusTax { get; set; }
        public decimal PesangonGross { get; set; }
        public decimal BonusAllowTax { get; set; }
        public decimal PesangonTax { get; set; }
        public decimal PesangonAllowTax { get; set; }
        public decimal BonusGross { get; set; }
        public decimal RefundTax { get; set; }
        public decimal UnderpaidTax { get; set; }
        public decimal OverpaidTax { get; set; }
        public decimal TaxByGov { get; set; }
        public decimal MonthValue { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public decimal SubBase { get; set; }
        public decimal OT { get; set; }
        public decimal SubPayroll { get; set; }
        public decimal Allow { get; set; }
        public decimal Dedu { get; set; }
        public decimal AllowTax { get; set; }
        public decimal DeduTax { get; set; }
        public decimal TaxAllow { get; set; }
        public decimal TaxPaid { get; set; }
        public decimal Total { get; set; }
        public decimal FineTax { get; set; }
        public decimal FineTaxAllow { get; set; }
        public bool FineTaxID { get; set; }
        public string NPWP { get; set; }
    }
}
