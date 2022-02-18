using System.Diagnostics.CodeAnalysis;

namespace ExpenseTrackerAPI
{
    public record ExpenseApiDisplayMessage(int Id, string Name);

    [ExcludeFromCodeCoverage]
    public static class ExpenseApiDisplayMessages
    {
      //Error UserAccount 
       public static ExpenseApiDisplayMessage UserAccountNotFound { get; } = new (00_001, nameof(UserAccountNotFound));

       
    }
}
