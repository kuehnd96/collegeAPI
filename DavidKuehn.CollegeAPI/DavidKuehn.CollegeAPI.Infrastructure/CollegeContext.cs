using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DavidKuehn.CollegeAPI.Infrastructure
{
    public class CollegeContext : DbContext
    {
        public DbSet<CollegeEntity> Colleges { get; set; }

        public CollegeContext()
            : base("CollegeContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
