using ExpenseTrackerAPI.Menagers.UserAccountsMenagers;

namespace ExpenseTrackerAPI.Extensions
{
    public static class MenagerCollectionExtensions
    {
        public static void AddTransientMenager(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IUserAccountManager, UserAccountManager>();

        }
    }
}
