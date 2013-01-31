using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.DataModel.Models.Mapping
{
    public class tblPayrollMap : EntityTypeConfiguration<tblPayroll>
    {
        public tblPayrollMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.PayrollID });

            // Properties
            this.Property(t => t.EmployeeID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PayrollID)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.DepartmentID)
                .HasMaxLength(10);

            this.Property(t => t.CategoryID)
                .HasMaxLength(5);

            this.Property(t => t.CostCentreID)
                .HasMaxLength(5);

            this.Property(t => t.DesignationID)
                .HasMaxLength(5);

            this.Property(t => t.MaritalID)
                .HasMaxLength(5);

            this.Property(t => t.PaymentID)
                .HasMaxLength(1);

            this.Property(t => t.WifeID)
                .HasMaxLength(10);

            this.Property(t => t.GroupID)
                .HasMaxLength(5);

            this.Property(t => t.CurrencyID)
                .HasMaxLength(3);

            this.Property(t => t.CurOTRate)
                .HasMaxLength(3);

            this.Property(t => t.payDepID)
                .HasMaxLength(6);

            this.Property(t => t.payLastParam)
                .HasMaxLength(200);

            this.Property(t => t.Computer)
                .HasMaxLength(20);

            this.Property(t => t.Operator)
                .HasMaxLength(20);

            this.Property(t => t.NPWP)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tblPayroll");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.PayrollID).HasColumnName("PayrollID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.CostCentreID).HasColumnName("CostCentreID");
            this.Property(t => t.DesignationID).HasColumnName("DesignationID");
            this.Property(t => t.MaritalID).HasColumnName("MaritalID");
            this.Property(t => t.PaymentID).HasColumnName("PaymentID");
            this.Property(t => t.WifeID).HasColumnName("WifeID");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.payWorkDay).HasColumnName("payWorkDay");
            this.Property(t => t.payBase).HasColumnName("payBase");
            this.Property(t => t.payExcBase).HasColumnName("payExcBase");
            this.Property(t => t.CurOTRate).HasColumnName("CurOTRate");
            this.Property(t => t.payOThrs).HasColumnName("payOThrs");
            this.Property(t => t.payOTRate).HasColumnName("payOTRate");
            this.Property(t => t.payExcOTRate).HasColumnName("payExcOTRate");
            this.Property(t => t.payJHTCo).HasColumnName("payJHTCo");
            this.Property(t => t.payJHTEmp).HasColumnName("payJHTEmp");
            this.Property(t => t.payJKK).HasColumnName("payJKK");
            this.Property(t => t.payJKM).HasColumnName("payJKM");
            this.Property(t => t.payJPK).HasColumnName("payJPK");
            this.Property(t => t.payTax).HasColumnName("payTax");
            this.Property(t => t.payTaxAllowance).HasColumnName("payTaxAllowance");
            this.Property(t => t.payGrossTax).HasColumnName("payGrossTax");
            this.Property(t => t.payGrossAssure).HasColumnName("payGrossAssure");
            this.Property(t => t.payTitle).HasColumnName("payTitle");
            this.Property(t => t.payNonTaxable).HasColumnName("payNonTaxable");
            this.Property(t => t.TaxID).HasColumnName("TaxID");
            this.Property(t => t.payAssurance).HasColumnName("payAssurance");
            this.Property(t => t.TakeHome).HasColumnName("TakeHome");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.payJHTEmpPaidCo).HasColumnName("payJHTEmpPaidCo");
            this.Property(t => t.payLastBase).HasColumnName("payLastBase");
            this.Property(t => t.payLastOThrs).HasColumnName("payLastOThrs");
            this.Property(t => t.payLastOTRate).HasColumnName("payLastOTRate");
            this.Property(t => t.payDepSave).HasColumnName("payDepSave");
            this.Property(t => t.payDepPaid).HasColumnName("payDepPaid");
            this.Property(t => t.payDepID).HasColumnName("payDepID");
            this.Property(t => t.payBonusTax).HasColumnName("payBonusTax");
            this.Property(t => t.payPesangonGross).HasColumnName("payPesangonGross");
            this.Property(t => t.payBonusAllowTax).HasColumnName("payBonusAllowTax");
            this.Property(t => t.payPesangonTax).HasColumnName("payPesangonTax");
            this.Property(t => t.payPesangonAllowTax).HasColumnName("payPesangonAllowTax");
            this.Property(t => t.payBonusGross).HasColumnName("payBonusGross");
            this.Property(t => t.payRefundTax).HasColumnName("payRefundTax");
            this.Property(t => t.payUnderpaidTax).HasColumnName("payUnderpaidTax");
            this.Property(t => t.payOverpaidTax).HasColumnName("payOverpaidTax");
            this.Property(t => t.payTaxByGov).HasColumnName("payTaxByGov");
            this.Property(t => t.payMonthValue).HasColumnName("payMonthValue");
            this.Property(t => t.payLastParam).HasColumnName("payLastParam");
            this.Property(t => t.Computer).HasColumnName("Computer");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.payMonNum).HasColumnName("payMonNum");
            this.Property(t => t.SubBase).HasColumnName("SubBase");
            this.Property(t => t.OT).HasColumnName("OT");
            this.Property(t => t.SubPayroll).HasColumnName("SubPayroll");
            this.Property(t => t.Allow).HasColumnName("Allow");
            this.Property(t => t.Dedu).HasColumnName("Dedu");
            this.Property(t => t.AllowTax).HasColumnName("AllowTax");
            this.Property(t => t.DeduTax).HasColumnName("DeduTax");
            this.Property(t => t.TaxAllow).HasColumnName("TaxAllow");
            this.Property(t => t.TaxPaid).HasColumnName("TaxPaid");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.payFineTax).HasColumnName("payFineTax");
            this.Property(t => t.payFineTaxAllow).HasColumnName("payFineTaxAllow");
            this.Property(t => t.FineTaxID).HasColumnName("FineTaxID");
            this.Property(t => t.NPWP).HasColumnName("NPWP");
        }
    }
}
