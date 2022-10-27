using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Subscriptions.Domain.Customers;
using Subscriptions.Domain.Users;

namespace Subscriptions.Infrastructure.Configurations.UsersConfig
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(user => user.Id);
            builder.Property(user => user.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(user => user.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(user => user.LastName).HasMaxLength(100).IsRequired();
            builder.Property(user => user.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (UserStatus)Enum.Parse(typeof(UserStatus), v));

            builder.Property(user => user.Email).HasMaxLength(128).IsRequired();
            builder.HasIndex(user => user.Email).IsUnique();
            builder.Property(user => user.MoneySpent).HasColumnType("money");
            builder.Property(user => user.CreatedDate).IsRequired();
            builder.Property(user => user.UpdatedDate).IsRequired();
        }
    }
}
