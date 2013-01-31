using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisi.Payslip.Contract;
using Pisi.DataModel.Models;

namespace Pisi.Payslip
{
    public class PayslipRepository
    {
        public IList<PayrollAllowance> LoadAllowanceForEmployee(string employeeid, string periodid)
        {
            using (var db = new pisidataContext())
            {
                var query = from pa in db.tblPayAllows
                            join a in db.tblAllowances on pa.AllowanceID equals a.AllowanceID into joinedpayalloAndAllow
                            where pa.EmployeeID.Equals(employeeid) && pa.PayrollID.Equals(periodid)
                            from pallow in joinedpayalloAndAllow.DefaultIfEmpty()
                            select new
                            {
                                AllowanceID = pa.AllowanceID,
                                PayrollID = pa.PayrollID,
                                AllowanceName = pallow.aloName,
                                CurrencyID = pa.CurrencyID,
                                EmployeeID = pa.EmployeeID,
                                ExcRate =pa.palExcRate,
                                Normal = pa.palNormal,
                                Rate = pa.palRate,
                                Taxable = pa.palTaxAble
                            };
                          
                var list = query.OrderBy(x => x.AllowanceID).ToList();
                IList<PayrollAllowance> resultList = new List<PayrollAllowance>();
                foreach (var a in list)
                {
                    resultList.Add(new PayrollAllowance()
                            {
                                AllowanceID = a.AllowanceID,
                                PayrollID = a.PayrollID,
                                AllowanceName = ToString(a.AllowanceName),
                                CurrencyID = ToString(a.CurrencyID),
                                EmployeeID = a.EmployeeID,
                                ExcRate = ToDecimal(a.ExcRate),
                                Normal = ToDecimal(a.Normal),
                                Rate = ToDecimal(a.Rate),
                                Taxable = ToBool(a.Taxable)
                            });
                }

                return resultList;
            }
        }
        public IList<PayrollDeduction> LoadDeductionForEmployee(string employeeid, string periodid)
        {
            using (var db = new pisidataContext())
            {
                var query = from pd in db.tblPayDedus
                            join d in db.tblDeductions on pd.DeductionID equals d.DeductionID into joinedPayDeduAndDedu
                            where pd.EmployeeID.Equals(employeeid) && pd.PayrollID.Equals(periodid)
                            from dedu in joinedPayDeduAndDedu.DefaultIfEmpty()
                            select new
                            {
                                pd.DeductionID,
                                pd.PayrollID,
                                DeductionName = dedu.dedName,
                                pd.CurrencyID,
                                pd.EmployeeID,
                                ExcRate = pd.padExcRate,
                                Normal = pd.padNormal,
                                Rate = pd.padRate,
                                Taxable = pd.padTaxable
                            };

                var list = query.OrderBy(x => x.DeductionID).ToList();
                IList<PayrollDeduction> resultList = new List<PayrollDeduction>();
                foreach (var a in list)
                {
                    resultList.Add(new PayrollDeduction()
                            {
                                DeductionID = a.DeductionID,
                                PayrollID = a.PayrollID,
                                DeductionName = ToString(a.DeductionName),
                                CurrencyID = ToString(a.CurrencyID),
                                EmployeeID = a.EmployeeID,
                                ExcRate = ToDecimal(a.ExcRate),
                                Normal = ToDecimal(a.Normal),
                                Rate = ToDecimal(a.Rate),
                                Taxable = ToBool(a.Taxable)
                            });
                };
                return resultList;
            }
        }
        public IList<PayslipPeriod> LoadPayslipPeriodForEmployee(string employeeid)
        {
            using (var db = new pisidataContext())
            {
                var query =from p in db.tblPayrolls 
                           join m in db.tblMonths on p.PayrollID equals m.MonthID
                           where p.EmployeeID.Equals(employeeid)
                           select new PayslipPeriod() { Code = m.MonthID , Name = m.monName };


                return query.OrderBy(x=>x.Code).ToList();
            }
        }
        public Payroll LoadPayrollForEmployee(string employeeid, string periodid)
        {
            using (var db = new pisidataContext())
            {
                var query = from p in db.tblPayrolls
                            where p.EmployeeID.Equals(employeeid) && p.PayrollID.Equals(periodid)
                            select p;


                return assemblePayroll(query.FirstOrDefault());
            }
        }

        private Payroll assemblePayroll(tblPayroll p)
        {
            return new Payroll()
            {
                EmployeeID = p.EmployeeID,
                PayrollID = p.PayrollID,
                DepartmentID = ToString(p.DepartmentID),
                CategoryID = ToString(p.CategoryID),
                CostCentreID = ToString(p.CostCentreID),
                DesignationID = ToString(p.DesignationID),
                MaritalID = ToString(p.MaritalID),
                PaymentID = ToString(p.PaymentID),
                WifeID = ToString(p.WifeID),
                GroupID = ToString(p.GroupID),
                CurrencyID = ToString(p.CurrencyID),
                WorkDay = ToShort(p.payWorkDay),
                Base = ToDecimal(p.payBase),
                ExcBase = ToDecimal(p.payExcBase),
                CurOTRate = ToString(p.CurOTRate),
                OThrs = ToDecimal(p.payOThrs),
                OTRate = ToDecimal(p.payOTRate),
                ExcOTRate = ToDecimal(p.payExcOTRate),
                JHTCo = ToDecimal(p.payJHTCo),
                JHTEmp = ToDecimal(p.payJHTEmp),
                JKK = ToDecimal(p.payJKK),
                JKM = ToDecimal(p.payJKM),
                JPK = ToDecimal(p.payJPK),
                Tax = ToDecimal(p.payTax),
                TaxAllowance = ToDecimal(p.payTaxAllowance),
                GrossTax = ToDecimal(p.payGrossTax),
                GrossAssure = ToDecimal(p.payGrossAssure),
                Title = ToDecimal(p.payTitle),
                NonTaxable = ToDecimal(p.payNonTaxable),
                TaxID = ToShort(p.TaxID),
                Assurance = p.payAssurance,
                TakeHome = ToInt(p.TakeHome),
                Bank = ToInt(p.Bank),
                JHTEmpPaidCo = p.payJHTEmpPaidCo,
                LastBase = ToDecimal(p.payLastBase),
                LastOThrs = ToDecimal(p.payLastOThrs),
                LastOTRate = ToDecimal(p.payLastOTRate),
                DepSave = ToDecimal(p.payDepSave),
                DepPaid = ToDecimal(p.payDepPaid),
                DepID = ToString(p.payDepID),
                BonusTax = ToDecimal(p.payBonusTax),
                PesangonGross = ToDecimal(p.payPesangonGross),
                BonusAllowTax =ToDecimal( p.payBonusAllowTax),
                PesangonTax = ToDecimal(p.payPesangonTax),
                PesangonAllowTax = ToDecimal(p.payPesangonAllowTax),
                BonusGross = ToDecimal(p.payBonusTax),
                RefundTax = ToDecimal(p.payRefundTax),
                UnderpaidTax = ToDecimal(p.payUnderpaidTax),
                OverpaidTax = ToDecimal(p.payOverpaidTax),
                TaxByGov = ToDecimal(p.payTaxByGov),
                MonthValue = ToDecimal(p.payMonthValue),
                LastUpdate = ToDateTime(p.LastUpdate),
                SubBase = ToDecimal(p.SubBase),
                OT = ToDecimal(p.OT),
                SubPayroll = ToDecimal(p.SubPayroll),
                Allow = ToDecimal(p.Allow),
                Dedu = ToDecimal(p.Dedu),
                AllowTax = ToDecimal(p.AllowTax),
                DeduTax = ToDecimal(p.DeduTax),
                TaxAllow = ToDecimal(p.TaxAllow),
                TaxPaid = ToDecimal(p.TaxPaid),
                Total = ToDecimal(p.Total),
                FineTax = ToDecimal(p.payFineTax),
                FineTaxAllow = ToDecimal(p.payFineTaxAllow),
                FineTaxID = ToBool(p.FineTaxID),
                NPWP =ToString(p.NPWP) 
            };
        }

        private string ToString(string p)
        {
            return p == null ? string.Empty : p;
        }

        private bool ToBool(bool? p)
        {
            return p.HasValue ? p.Value : false;
        }

        private DateTime ToDateTime(DateTime? p)
        {
            return p.HasValue ? p.Value : new DateTime(1900,1,1);
        }

        private int ToInt(int? p)
        {
            return p.HasValue ? p.Value : 0;
        }

        private  short ToShort(short? p)
        {
            return p.HasValue ? p.Value : new short();
        }

        private  decimal ToDecimal(decimal? p)
        {
            return p.HasValue ? p.Value : 0m;
        }



      
    }
}
