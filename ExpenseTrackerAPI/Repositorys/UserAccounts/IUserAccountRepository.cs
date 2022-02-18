using ExpenseTrackerAPI.EF.Models;
using ExpenseTrackerAPI.Repositorys.UserAccounts.Model.ExpenseTrackerDataAccess.Repositorys.UserAccounts.Model;
using ExpenseTrackerAPI.Requests.UserAccount;

namespace ExpenseTrackerAPI.Repositorys.UserAccounts
{
    public interface IUserAccountRepository
    {
        
        Task<List<UserAccount>> GetAllUserAccount();
        Task<UserAccount> GetByIdAsync(int id);
        Task<UserAccount> CreateAsync(UserAccountCreateModel model);
        Task UpdateAsync(int id, UserAccountPutRequest putRequest ); 

    }
}
