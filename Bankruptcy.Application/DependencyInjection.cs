using Bankruptcy.Application.Services.Implementations;
using Bankruptcy.Application.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bankruptcy.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            // register all services here

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}
