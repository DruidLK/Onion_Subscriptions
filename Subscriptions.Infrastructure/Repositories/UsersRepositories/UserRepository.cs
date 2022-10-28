using Subscriptions.Domain.Abstractions.IRepositories;
using Subscriptions.Domain.Customers;
using Subscriptions.Infrastructure.StorageBroker;

namespace Subscriptions.Infrastructure.Repositories.UsersRepositories
{
    public sealed class UserRepository : IUserRepository
    {
        private readonly StorageBrokerContext storageBrokerContext;

        public UserRepository(StorageBrokerContext storageBrokerContext) =>
            this.storageBrokerContext = storageBrokerContext;
        public async ValueTask InsertUserAsync(User entity) =>
            await this.storageBrokerContext.AddAsync(entity);
        public async ValueTask UpdateUserAsync (User entity)
        {
            this.storageBrokerContext.Update(entity);
            await this.storageBrokerContext.SaveChangesAsync();
        }
    }
}
