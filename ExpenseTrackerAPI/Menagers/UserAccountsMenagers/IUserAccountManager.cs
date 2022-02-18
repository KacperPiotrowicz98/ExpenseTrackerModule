using ExpenseTrackerAPI.Repositorys.UserAccounts.Model;
using ExpenseTrackerAPI.Requests.UserAccount;
using ExpenseTrackerAPI.Responses;
using ExpenseTrackerAPI.Responses.UserAccount;

namespace ExpenseTrackerAPI.Menagers.UserAccountsMenagers
{
    public interface IUserAccountManager
    {
        Task<List<AccountGetResponse>> GetAllUserAccounts();
        Task<AccountGetResponse> GetUserAccountbyId(int id);
        Task<UserAccountCreateResponse> CreateUserAccountAsync(UserAccountCreateRequest? createRequest);
        Task UpdateTeamByIdAsync(int id, UserAccountPutRequest putRequest);


    }
}
