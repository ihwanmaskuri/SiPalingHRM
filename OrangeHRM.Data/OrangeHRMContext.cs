using System.Data.Entity;
using OrangeHRM.Entities;

namespace OrangeHRM.Data
{
    public class OrangeHRMContext : DbContext
    {
        public OrangeHRMContext() : base("name=OrangeHRMConnectionString")
        {
            // Disable initializer for existing database
            Database.SetInitializer<OrangeHRMContext>(null);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Subunit> Subunits { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Kpi> Kpis { get; set; }
        public DbSet<PerformanceReview> PerformanceReviews { get; set; }
        public DbSet<JobVacancy> JobVacancies { get; set; }
        public DbSet<JobCandidate> JobCandidates { get; set; }
        public DbSet<PayPeriod> PayPeriods { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }
        public DbSet<EmpBasicSalary> EmpBasicSalaries { get; set; }
        public DbSet<EmpDirectDebit> EmpDirectDebits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Custom mappings if needed
        }
    }
}
