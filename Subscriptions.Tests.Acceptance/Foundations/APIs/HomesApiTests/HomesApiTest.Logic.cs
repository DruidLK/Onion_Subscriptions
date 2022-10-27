using FluentAssertions;
using Xunit;

namespace Subscriptions.Tests.Acceptance.Foundations.APIs.HomesApiTests
{
    public partial class HomesApiTest
    {
        [Fact]
        public async Task ShouldReturnGetHomesApi()
        {
            // Arrange - Given
            var expectedString =
                "Thank you Mario, but the princess is in another castle!";

            // Act - When
            var actualString =
                await this.apiBrokerTests
                    .GetHomesApi();

            // Assert - Then
            actualString.Should().BeEquivalentTo(expectedString);
        }
    }
}
