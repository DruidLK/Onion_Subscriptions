using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Subscriptions.Infrastructure.StorageBroker
{
    public sealed class StorageBrokerFactory
        : IDesignTimeDbContextFactory<StorageBrokerContext>
    {
        public StorageBrokerContext CreateDbContext(string[] args)
        {
                //var environment =
                //    Environment.GetEnvironmentVariable(variable:"ASPNETCORE_ENVIRONMENT");

                //var configuration = new ConfigurationBuilder()
                //.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BookingApp.API/"))
                //.AddJsonFile(path: "appsettings", optional: false, reloadOnChange: true)
                //.AddJsonFile(path: $"appsettings.{environment}.json")
                //.AddEnvironmentVariables()
                //.Build();

                IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Subscriptions.API"))
                .AddJsonFile("appsettings.Development.json")
                .Build();

                var dbContextBuilder =
                    new DbContextOptionsBuilder<StorageBrokerContext>();

                var connectionString =
                    configuration.GetConnectionString("DefaultConnection");

                dbContextBuilder.UseSqlServer(connectionString);

                return new StorageBrokerContext(dbContextBuilder.Options);
            }
        }
    }
