using ExpenseTrackerAPI.Repositorys.UserAccounts;

namespace ExpenseTrackerAPI.Extensions
{
    public static class RepositorysCollectionExtensions
    {
        public static void AddTransientRepositorys(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IUserAccountRepository, UserAccountRepository>();

        }
    }
}
