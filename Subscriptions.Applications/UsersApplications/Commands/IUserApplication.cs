namespace Subscriptions.Applications.UsersApplications.Commands
{
    public interface IUserApplication
    {
        Task RegisterUser(string firstName, string lastName, string email);
    }
}