using System.Diagnostics.CodeAnalysis;

namespace ExpenseTrackerAPI.Repositorys.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class EntityNotFoundException<T> : Exception
    {
        public EntityNotFoundException()
            : base($"Could not find entity of type {typeof(T)}")
        {
        }

        public EntityNotFoundException(string lookupId)
            : base($"Could not find entity of type {typeof(T)} with Id {lookupId}")
        {
        }
    }
}
