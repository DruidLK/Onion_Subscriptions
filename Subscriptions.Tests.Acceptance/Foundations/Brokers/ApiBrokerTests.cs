using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
using Subscriptions.API;

namespace Subscriptions.Tests.Acceptance.Foundations.Brokers
{
    public partial class ApiBrokerTests
    {
        private readonly WebApplicationFactory<Startup> webApplication;
        private readonly HttpClient httpClient;
        private readonly IRESTFulApiFactoryClient apiFactoryClient;

        public ApiBrokerTests()
        {
            this.webApplication = new WebApplicationFactory<Startup>();
            this.httpClient = this.webApplication.CreateClient();
            this.apiFactoryClient = new RESTFulApiFactoryClient(this.httpClient);
        }
    }
}
