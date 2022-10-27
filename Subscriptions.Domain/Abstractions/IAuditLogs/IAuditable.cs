using Subscriptions.Domain.Customers;

namespace Subscriptions.Domain.Abstractions.IAuditLogs
{
    public interface IAuditable
    {
        public DateTimeOffset CreatedDate { get; }
        public User CreatedBy { get; }
        public DateTimeOffset UpdatedDate { get; }
        public User UpdatedBy { get; }
    }
}
