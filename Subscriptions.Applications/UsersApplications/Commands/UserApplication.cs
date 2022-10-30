using Subscriptions.Domain.Abstractions.IDateTimeBrokers;
using Subscriptions.Domain.Abstractions.IRepositories;
using Subscriptions.Domain.Abstractions.IUnitOfWork;

namespace Subscriptions.Applications.UsersApplications.Commands
{
    public sealed class UserApplication : IUserApplication
    {
        private readonly IDateTimeBroker dateTimeBroker;
        private readonly IUserRepository userRepository;
        private readonly IUOW uOW;

        public UserApplication(
            IDateTimeBroker dateTimeBroker,
            IUserRepository userRepository,
            IUOW uOW)
        {
            this.dateTimeBroker = dateTimeBroker;
            this.userRepository = userRepository;
            this.uOW = uOW;
        }

        public async Task RegisterUser(string firstName, string lastName, string email)
        {
            try
            {
                //check if email exist throw error validation

                var currentDateTime =
                    this.dateTimeBroker.GetDateTime;

                var user =
                    UserFactory.CreateUser(firstName, lastName, email, currentDateTime, currentDateTime);

                await this.userRepository.InsertUserAsync(user);
                await this.uOW.SaveChangesAsync();

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
