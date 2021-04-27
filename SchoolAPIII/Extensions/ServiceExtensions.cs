
using Contracts;
using Entities;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace SchoolAPIII.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
    services.AddDbContext<RepositoryContext>(opts =>
        opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("SchoolAPIII")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
           services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}