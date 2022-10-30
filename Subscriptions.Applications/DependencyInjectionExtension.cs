using Microsoft.Extensions.DependencyInjection;
using Subscriptions.Applications.UsersApplications.Commands;

namespace Subscriptions.Applications
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IUserApplication, UserApplication>();
        }
    }
}
