namespace ExpenseTrackerAPI.Requests.UserAccount
{
    public class UserAccountCreateRequest
    {
       
        public string? Login { get; set; }
        public int Password { get; set; }

        public int AccountingPeriod { get; set; }

        public string? Localisation { get; set; }

        public Boolean IsActive { get; set; }
        public string? UserRole { get; set; }
    }
}
