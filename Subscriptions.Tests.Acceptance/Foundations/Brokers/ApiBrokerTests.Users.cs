using Subscriptions.Tests.Acceptance.Foundations.Models.UserModels;

namespace Subscriptions.Tests.Acceptance.Foundations.Brokers
{
    public partial class ApiBrokerTests
    {
        private const string userUrl = "Api/Users";

        public async ValueTask PostUserAsync(UserModel userModel) =>
            await this.apiFactoryClient
                .PostContentWithNoResponseAsync(userUrl, userModel);
    }
}
