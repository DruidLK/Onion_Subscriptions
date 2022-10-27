using Subscriptions.Domain.Customers;

namespace Subscriptions.Applications.UsersApplications
{
    public static class UserFactory
    {
        public static User CreateUser(
            string firstName,
            string lastName,
            string email,
            DateTimeOffset createdDate,
            DateTimeOffset updatedDate) =>

            new User(
                firstName,
                lastName,
                email,
                createdDate,
                updatedDate
                );
    }
}
