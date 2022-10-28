namespace Subscriptions.Domain.Abstractions.IDateTimeBrokers
{
    public interface IDateTimeBroker
    {
        DateTimeOffset GetDateTime { get; }
    }
}
