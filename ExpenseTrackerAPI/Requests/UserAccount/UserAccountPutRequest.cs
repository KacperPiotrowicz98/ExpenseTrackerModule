namespace ExpenseTrackerAPI.Requests.UserAccount
{
    public class UserAccountPutRequest
    {
        public string Login { get; set; }
        public int Password { get; set; }
        public int? AccountingPeriod { get; set; }
        public string Localisation { get; set; }
        public bool? IsActive { get; set; }
    }
}
