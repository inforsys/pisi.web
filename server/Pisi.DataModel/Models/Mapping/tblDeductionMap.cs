using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.DataModel.Models.Mapping
{
    public class tblDeductionMap : EntityTypeConfiguration<tblDeduction>
    {
        public tblDeductionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DeductionID, t.dedName, t.dedTaxable, t.dedAssurance, t.dedRefund, t.dedProrate, t.dedSetup, t.dedExecute, t.dedUnlimited, t.dedCheck, t.dedTakeHome, t.dedOTRate });

            // Properties
            this.Property(t => t.DeductionID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.dedName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.COAID)
                .HasMaxLength(10);

            this.Property(t => t.CurrencyID)
                .HasMaxLength(3);

            this.Property(t => t.dedColumn)
                .HasMaxLength(2);

            this.Property(t => t.dedNormal)
                .HasMaxLength(4000);

            this.Property(t => t.dedFormula)
                .HasMaxLength(4000);

            this.Property(t => t.dedProportional)
                .HasMaxLength(4000);

            this.Property(t => t.Computer)
                .HasMaxLength(20);

            this.Property(t => t.Operator)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tblDeduction");
            this.Property(t => t.DeductionID).HasColumnName("DeductionID");
            this.Property(t => t.dedName).HasColumnName("dedName");
            this.Property(t => t.COAID).HasColumnName("COAID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.dedTaxable).HasColumnName("dedTaxable");
            this.Property(t => t.dedAssurance).HasColumnName("dedAssurance");
            this.Property(t => t.dedRefund).HasColumnName("dedRefund");
            this.Property(t => t.dedColumn).HasColumnName("dedColumn");
            this.Property(t => t.dedNormal).HasColumnName("dedNormal");
            this.Property(t => t.dedFormula).HasColumnName("dedFormula");
            this.Property(t => t.dedProportional).HasColumnName("dedProportional");
            this.Property(t => t.dedProrate).HasColumnName("dedProrate");
            this.Property(t => t.dedSetup).HasColumnName("dedSetup");
            this.Property(t => t.dedSequence).HasColumnName("dedSequence");
            this.Property(t => t.dedExecute).HasColumnName("dedExecute");
            this.Property(t => t.dedUnlimited).HasColumnName("dedUnlimited");
            this.Property(t => t.dedCheck).HasColumnName("dedCheck");
            this.Property(t => t.dedTakeHome).HasColumnName("dedTakeHome");
            this.Property(t => t.dedOTRate).HasColumnName("dedOTRate");
            this.Property(t => t.Computer).HasColumnName("Computer");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
        }
    }
}
