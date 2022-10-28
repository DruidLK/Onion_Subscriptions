using Subscriptions.Domain.Customers;

namespace Subscriptions.Domain.Abstractions.IRepositories
{
    public interface IUserRepository
    {
        ValueTask InsertUserAsync(User entity);
        ValueTask UpdateUserAsync(User entity);
    }
}
