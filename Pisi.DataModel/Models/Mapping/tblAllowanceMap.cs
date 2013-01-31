using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.DataModel.Models.Mapping
{
    public class tblAllowanceMap : EntityTypeConfiguration<tblAllowance>
    {
        public tblAllowanceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AllowanceID, t.aloTaxable, t.aloAssurance, t.aloProrate, t.aloSetup, t.aloExecute, t.aloUnlimited, t.aloCheck, t.aloTakeHome, t.aloOTRate, t.aloAbsent, t.aloBonus, t.aloPesangon, t.aloYearlyBonus });

            // Properties
            this.Property(t => t.AllowanceID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.aloName)
                .HasMaxLength(30);

            this.Property(t => t.COAID)
                .HasMaxLength(12);

            this.Property(t => t.CurrencyID)
                .HasMaxLength(3);

            this.Property(t => t.aloColumn)
                .HasMaxLength(2);

            this.Property(t => t.aloNormal)
                .HasMaxLength(4000);

            this.Property(t => t.aloFormula)
                .HasMaxLength(4000);

            this.Property(t => t.aloProportional)
                .HasMaxLength(4000);

            this.Property(t => t.Computer)
                .HasMaxLength(20);

            this.Property(t => t.Operator)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tblAllowance");
            this.Property(t => t.AllowanceID).HasColumnName("AllowanceID");
            this.Property(t => t.aloName).HasColumnName("aloName");
            this.Property(t => t.COAID).HasColumnName("COAID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.aloTaxable).HasColumnName("aloTaxable");
            this.Property(t => t.aloAssurance).HasColumnName("aloAssurance");
            this.Property(t => t.aloColumn).HasColumnName("aloColumn");
            this.Property(t => t.aloNormal).HasColumnName("aloNormal");
            this.Property(t => t.aloFormula).HasColumnName("aloFormula");
            this.Property(t => t.aloProportional).HasColumnName("aloProportional");
            this.Property(t => t.aloProrate).HasColumnName("aloProrate");
            this.Property(t => t.aloSetup).HasColumnName("aloSetup");
            this.Property(t => t.aloSequence).HasColumnName("aloSequence");
            this.Property(t => t.aloExecute).HasColumnName("aloExecute");
            this.Property(t => t.aloUnlimited).HasColumnName("aloUnlimited");
            this.Property(t => t.aloCheck).HasColumnName("aloCheck");
            this.Property(t => t.aloTakeHome).HasColumnName("aloTakeHome");
            this.Property(t => t.aloOTRate).HasColumnName("aloOTRate");
            this.Property(t => t.aloAbsent).HasColumnName("aloAbsent");
            this.Property(t => t.aloBonus).HasColumnName("aloBonus");
            this.Property(t => t.aloPesangon).HasColumnName("aloPesangon");
            this.Property(t => t.aloYearlyBonus).HasColumnName("aloYearlyBonus");
            this.Property(t => t.Computer).HasColumnName("Computer");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.alofix).HasColumnName("alofix");
            this.Property(t => t.aloTaxPayByCom).HasColumnName("aloTaxPayByCom");
        }
    }
}
