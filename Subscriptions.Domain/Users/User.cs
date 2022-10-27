using Subscriptions.Domain.Base;
using Subscriptions.Domain.Users;

namespace Subscriptions.Domain.Customers
{
    public sealed class User : Entity
    {
        private User()
        { }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public UserStatus Status { get; private set; }
        public string Email { get; private set; }
        public decimal MoneySpent { get; private set; }
        public DateTimeOffset CreatedDate { get; private set; }
        public DateTimeOffset UpdatedDate { get; private set; }

        //public IEnumerable<Subscription> Subscriptions { get; set; }

        public User(
            string firstName,
            string lastName,
            string email,
            DateTimeOffset createdDate,
            DateTimeOffset updatedDate
            )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Status = UserStatus.Activated;
        }
    }
}
