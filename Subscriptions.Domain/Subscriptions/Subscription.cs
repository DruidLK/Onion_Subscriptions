using Subscriptions.Domain.Abstractions.IAuditLogs;
using Subscriptions.Domain.Customers;
using Subscriptions.Domain.Products;

namespace Subscriptions.Domain.Subscriptions
{
    public sealed class Subscription : IAuditable
    {

        public Guid UserId { get; private set; }
        public Guid ProductId { get; private set; }
        public User User { get; private set; }
        public Product Product { get; private set; }
        public DateTimeOffset CreatedDate { get; private set; }
        public User CreatedBy { get; private set; }
        public DateTimeOffset UpdatedDate { get; private set; }
        public User UpdatedBy { get; private set; }
        public Subscription(
            Guid userId,
            Guid productId,
            User user,
            Product product,
            DateTimeOffset createdDate,
            User createdBy,
            DateTimeOffset updatedDate,
            User updatedBy)
        {
            UserId = userId;
            ProductId = productId;
            User = user;
            Product = product;
            CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            UpdatedDate = updatedDate;
            this.UpdatedBy = updatedBy;
        }
    }
}
