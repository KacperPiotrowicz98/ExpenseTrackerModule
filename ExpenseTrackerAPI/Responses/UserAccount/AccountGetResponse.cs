namespace ExpenseTrackerAPI.Responses
{
    public record AccountGetResponse(
        int Id,
        string? Login,
        string? Localisation);
}
