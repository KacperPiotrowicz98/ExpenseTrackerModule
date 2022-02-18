using ExpenseTrackerAPI.Services.UserAccountServices;

namespace ExpenseTrackerAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IUserAccountServices, UserAccountServices>();

        }

       
    }
}
