namespace Subscriptions.Contract.UsersDataTransferObjects.Commands
{
    public sealed record UserRequest
        (
            string firstName,
            string lastName,
            string email
        );
}
