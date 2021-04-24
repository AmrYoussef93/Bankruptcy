using Bankruptcy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bankruptcy.Application.Common.Interfaces
{
    public interface IBankruptcyDbContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Department> Departments { get; set; }
    }
}
