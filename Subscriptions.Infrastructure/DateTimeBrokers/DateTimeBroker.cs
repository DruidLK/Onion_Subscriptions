using Subscriptions.Domain.Abstractions.IDateTimeBrokers;

namespace Subscriptions.Infrastructure.DateTimeBrokers
{
    public sealed class DateTimeBroker : IDateTimeBroker
    {
        public DateTimeOffset GetDateTime =>
            DateTimeOffset.UtcNow;
    }
}
