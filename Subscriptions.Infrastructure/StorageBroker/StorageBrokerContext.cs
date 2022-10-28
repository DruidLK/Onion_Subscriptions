using Microsoft.EntityFrameworkCore;
using Subscriptions.Domain.Customers;

namespace Subscriptions.Infrastructure.StorageBroker
{
    public sealed class StorageBrokerContext : DbContext
    {
        public StorageBrokerContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StorageBrokerContext).Assembly);
        public DbSet<User> Users { get; set; }
    }
}
