using Subscriptions.Tests.Acceptance.Foundations.Brokers;
using Subscriptions.Tests.Acceptance.Foundations.Models.UserModels;
using Xunit;

namespace Subscriptions.Tests.Acceptance.Foundations.APIs.UsersApiTests
{
    [Collection(nameof(ApiBrokerCollection))]
    public partial class UsersApiTest
    {
        private readonly ApiBrokerTests apiBrokerTest;

        public UsersApiTest() =>
            this.apiBrokerTest = new ApiBrokerTests();

        private UserModel CreateUser() =>
            new UserModel("fadi", "dib", "123@hotmail.com");
    }
}
