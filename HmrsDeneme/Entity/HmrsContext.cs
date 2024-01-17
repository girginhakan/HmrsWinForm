

using System.Data.Entity;

namespace HmrsDeneme.Entity
{
    internal class HmrsContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public HmrsContext() : base("HmrsContext") { }

    }
}
