using Bankruptcy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bankruptcy.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(c => c.Id);
            builder.HasOne(s => s.Department).WithMany(d => d.Students).HasForeignKey(s => s.DepartmentId);
        }
    }
}
