namespace Subscriptions.Tests.Acceptance.Foundations.Brokers
{
    public partial class ApiBrokerTests
    {
        const string homesUrl = "Api/Homes";

        public async ValueTask<string> GetHomesApi() =>
            await this.apiFactoryClient
                .GetContentStringAsync(homesUrl);
    }
}
