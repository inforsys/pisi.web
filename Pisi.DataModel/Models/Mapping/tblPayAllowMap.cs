using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.DataModel.Models.Mapping
{
    public class tblPayAllowMap : EntityTypeConfiguration<tblPayAllow>
    {
        public tblPayAllowMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.PayrollID, t.AllowanceID });

            // Properties
            this.Property(t => t.EmployeeID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PayrollID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AllowanceID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CurrencyID)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.Computer)
                .HasMaxLength(20);

            this.Property(t => t.Operator)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tblPayAllow");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.PayrollID).HasColumnName("PayrollID");
            this.Property(t => t.AllowanceID).HasColumnName("AllowanceID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.palRate).HasColumnName("palRate");
            this.Property(t => t.palNormal).HasColumnName("palNormal");
            this.Property(t => t.palExcRate).HasColumnName("palExcRate");
            this.Property(t => t.palTaxAble).HasColumnName("palTaxAble");
            this.Property(t => t.Computer).HasColumnName("Computer");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
        }
    }
}
