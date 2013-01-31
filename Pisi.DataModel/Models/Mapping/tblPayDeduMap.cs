using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.DataModel.Models.Mapping
{
    public class tblPayDeduMap : EntityTypeConfiguration<tblPayDedu>
    {
        public tblPayDeduMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.PayrollID, t.DeductionID });

            // Properties
            this.Property(t => t.EmployeeID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PayrollID)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.DeductionID)
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
            this.ToTable("tblPayDedu");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.PayrollID).HasColumnName("PayrollID");
            this.Property(t => t.DeductionID).HasColumnName("DeductionID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.padRate).HasColumnName("padRate");
            this.Property(t => t.padNormal).HasColumnName("padNormal");
            this.Property(t => t.padExcRate).HasColumnName("padExcRate");
            this.Property(t => t.padTaxable).HasColumnName("padTaxable");
            this.Property(t => t.Computer).HasColumnName("Computer");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
        }
    }
}
