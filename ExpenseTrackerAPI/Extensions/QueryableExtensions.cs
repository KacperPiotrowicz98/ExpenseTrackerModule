using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerAPI.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<TEntity> SetTracking<TEntity>(this IQueryable<TEntity> query, bool track)
           where TEntity : class
        {
            return track ? query.AsTracking() : query.AsNoTracking();
        }
    }
}
