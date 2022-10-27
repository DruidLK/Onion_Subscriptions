using Subscriptions.Domain.Abstractions.IUnitOfWork;
using Subscriptions.Infrastructure.StorageBroker;

namespace Subscriptions.Infrastructure.Repositories
{
    public sealed class UOW : IUOW
    {
        private readonly StorageBrokerContext storageBrokerContext;

        public UOW(StorageBrokerContext storageBrokerContext) =>
            this.storageBrokerContext = storageBrokerContext;

        public async Task SaveChangesAsync() =>
            await this.storageBrokerContext.SaveChangesAsync();
    }
}
