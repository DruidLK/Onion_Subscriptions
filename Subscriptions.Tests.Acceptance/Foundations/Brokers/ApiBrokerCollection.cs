using Xunit;

namespace Subscriptions.Tests.Acceptance.Foundations.Brokers
{
    [CollectionDefinition(nameof(ApiBrokerCollection))]
    public partial class ApiBrokerCollection
        : ICollectionFixture<ApiBrokerTests>
    { }
}
