using Xunit;

namespace Subscriptions.Tests.Acceptance.Foundations.APIs.UsersApiTests
{
    public partial class UsersApiTest
    {
        [Fact]
        public async Task ShouldPostUserWhenCalled()
        {
            // Arrange - Given
            var user = CreateUser();

            // Act - when
                await this.apiBrokerTest
                    .PostUserAsync(user);
        }
    }
}
