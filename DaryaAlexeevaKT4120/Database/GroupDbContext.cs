using Microsoft.EntityFrameworkCore;
using DaryaAlexeevaKT4120.Database.Configurations;

namespace DaryaAlexeevaKT4120.Database
{
    public class GroupDbContext : DbContext
    {
            DbSet<Models.Group> Groups { get; set; }
            DbSet<Models.Specialization> Specializations { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new GroupConfiguration());
                modelBuilder.ApplyConfiguration(new SpecConfiguration());
            }
            public GroupDbContext(DbContextOptions<GroupDbContext> options) : base(options)
            {
            }
    }
}
