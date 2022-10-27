using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        }
    }
}
