using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Pisi.DataModel.Models.Mapping;

namespace Pisi.DataModel.Models
{
    public class pisidataContext : DbContext
    {
        static pisidataContext()
        {
            Database.SetInitializer<pisidataContext>(null);
        }

		public pisidataContext()
			: base("Name=pisidataContext")
		{
		}

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tblAllowance> tblAllowances { get; set; }
        public DbSet<tblDeduction> tblDeductions { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<tblMonth> tblMonths { get; set; }
        public DbSet<tblPayAllow> tblPayAllows { get; set; }
        public DbSet<tblPayDedu> tblPayDedus { get; set; }
        public DbSet<tblPayroll> tblPayrolls { get; set; }
        public DbSet<tblPeriod> tblPeriods { get; set; }
        public DbSet<tblUserVerification> tblUserVerifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tblAllowanceMap());
            modelBuilder.Configurations.Add(new tblDeductionMap());
            modelBuilder.Configurations.Add(new tblEmployeeMap());
            modelBuilder.Configurations.Add(new tblMonthMap());
            modelBuilder.Configurations.Add(new tblPayAllowMap());
            modelBuilder.Configurations.Add(new tblPayDeduMap());
            modelBuilder.Configurations.Add(new tblPayrollMap());
            modelBuilder.Configurations.Add(new tblPeriodMap());
            modelBuilder.Configurations.Add(new tblUserVerificationMap());
        }
    }
}
