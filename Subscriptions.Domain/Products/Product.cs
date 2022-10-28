using Subscriptions.Domain.Abstractions.IAuditLogs;
using Subscriptions.Domain.Base;
using Subscriptions.Domain.Customers;
using Subscriptions.Domain.Subscriptions;

namespace Subscriptions.Domain.Products
{
    public sealed class Product : Entity, IAuditable
    {
        public string Name { get; private set; }
        public decimal Amount { get; private set; }
        public BillingPeriod BillingPeriod { get; private set; }
        public DateTimeOffset CreatedDate { get; private set; }
        public User CreatedBy { get; private set; }
        public DateTimeOffset UpdatedDate { get; private set; }
        public User UpdatedBy { get; private set; }
        public IEnumerable<Subscription> Subscriptions { get; set; }
        private Product()
        { }

        public Product(
            string name,
            decimal amount,
            BillingPeriod billingPeriod,
            DateTimeOffset createdDate,
            User createdBy,
            DateTimeOffset updatedDate,
            User updatedBy)
        {
            Name = name;
            Amount = amount;
            BillingPeriod = billingPeriod;
            CreatedDate = createdDate;
            CreatedBy = createdBy;
            UpdatedDate = updatedDate;
            UpdatedBy = updatedBy;
        }

    }
}
