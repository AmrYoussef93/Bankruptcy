using Bankruptcy.Application.Common.Interfaces;
using Bankruptcy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bankruptcy.Persistence.Context
{
    public class BankruptcyDbContext : DbContext, IBankruptcyDbContext
    {
        public BankruptcyDbContext(DbContextOptions<BankruptcyDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("dbo");
            builder.ApplyConfigurationsFromAssembly(typeof(BankruptcyDbContext).Assembly);
        }
    }
}
