using ExpenseTrackerAPI.EF.Models;
using ExpenseTrackerAPI.Repositorys.UserAccounts.Model.ExpenseTrackerDataAccess.Repositorys.UserAccounts.Model;
using ExpenseTrackerAPI.Requests.UserAccount;

namespace ExpenseTrackerAPI.Services.UserAccountServices
{
    public interface IUserAccountServices
    {
        Task<List<UserAccount>> GetAllUserAccount();
        Task<UserAccount> GetUserAccountbyId(int id);
        Task<UserAccount> CreateUserAccountAsync(UserAccountCreateModel createModel);
        Task UpdateTeamByIdAsync(int id, UserAccountPutRequest putRequest);
    }
}
