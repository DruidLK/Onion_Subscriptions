namespace Subscriptions.Contract.UsersDataTransferObjects.Queries
{
    public sealed record UserResponseById
        (
            Guid Id,
            string FirstName,
            string LastName,
            string Email
        );
}
