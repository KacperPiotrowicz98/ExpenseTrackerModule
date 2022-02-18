namespace ExpenseTrackerAPI.Responses.UserAccount
{
    public record UserAccountCreateResponse
    (
        int Id,
        string Login,
        int Password,
        string Localisation
    );
}
