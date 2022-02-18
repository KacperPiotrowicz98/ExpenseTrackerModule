using ExpenseTrackerAPI.EF.Models;
using ExpenseTrackerAPI.Repositorys.UserAccounts;
using ExpenseTrackerAPI.Repositorys.UserAccounts.Model.ExpenseTrackerDataAccess.Repositorys.UserAccounts.Model;
using ExpenseTrackerAPI.Requests.UserAccount;

namespace ExpenseTrackerAPI.Services.UserAccountServices
{
    public class UserAccountServices : IUserAccountServices
    {
        private readonly IUserAccountRepository _iUserAccountRepository;
        public UserAccountServices(IUserAccountRepository userAccountRepository)
        {
            _iUserAccountRepository = userAccountRepository;
        }

        public async Task<UserAccount> CreateUserAccountAsync(UserAccountCreateModel createModel)
        {
            var useraccunt = await _iUserAccountRepository.CreateAsync(createModel);
            return useraccunt;
        }

        async Task<List<UserAccount>> IUserAccountServices.GetAllUserAccount()
        {
            var entity = await _iUserAccountRepository.GetAllUserAccount();
            return entity;
        }

        public Task<UserAccount> GetUserAccountbyId(int id)
        {
            var entity = _iUserAccountRepository.GetByIdAsync(id);
            return entity;

        }

        public async Task UpdateTeamByIdAsync(int id, UserAccountPutRequest putRequest)
        {
            await _iUserAccountRepository.UpdateAsync(id, putRequest);
        }
    }
}
