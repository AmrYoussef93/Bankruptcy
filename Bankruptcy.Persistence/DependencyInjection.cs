using Bankruptcy.Application.Common.Interfaces;
using Bankruptcy.Persistence.Context;
using Bankruptcy.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bankruptcy.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BankruptcyDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BankruptcyDbContext")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
