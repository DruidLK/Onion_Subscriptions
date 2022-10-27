using Subscriptions.Tests.Acceptance.Foundations.Brokers;
using Xunit;

namespace Subscriptions.Tests.Acceptance.Foundations.APIs.HomesApiTests
{
    [Collection(nameof(ApiBrokerCollection))]
    public partial class HomesApiTest
    {
        private readonly ApiBrokerTests apiBrokerTests;

        public HomesApiTest() =>
            this.apiBrokerTests = new ApiBrokerTests();
    }
}
