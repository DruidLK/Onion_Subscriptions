namespace Subscriptions.Domain.Abstractions.IUnitOfWork
{
    public interface IUOW
    {
        Task SaveChangesAsync();
    }
}
