using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Subscriptions.Domain.Abstractions.IDateTimeBrokers;
using Subscriptions.Domain.Abstractions.IRepositories;
using Subscriptions.Domain.Abstractions.IUnitOfWork;
using Subscriptions.Infrastructure.DateTimeBrokers;
using Subscriptions.Infrastructure.Repositories;
using Subscriptions.Infrastructure.Repositories.UsersRepositories;
using Subscriptions.Infrastructure.StorageBroker;

namespace Subscriptions.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<StorageBrokerContext>(config =>
            {
                string connectionString =
                   configuration.GetConnectionString("DefaultConnection");

                config.UseSqlServer(connectionString);
            });

            services.AddScoped<IDateTimeBroker, DateTimeBroker>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUOW, UOW>();
        }
    }
}
