namespace ExpenseTrackerAPI.Repositorys.UserAccounts.Model
{
    namespace ExpenseTrackerDataAccess.Repositorys.UserAccounts.Model
    {
        public record UserAccountCreateModel
        (
            string Login,
            int Password,
            int AccountingPeriod,
            string Localisation,
            Boolean IsActive,
            string UserRole


        );
    }
}
