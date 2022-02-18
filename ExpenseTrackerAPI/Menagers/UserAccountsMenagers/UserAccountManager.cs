using ExpenseTrackerAPI.EF.Models;
using ExpenseTrackerAPI.Exceptions.Http;
using ExpenseTrackerAPI.Repositorys.Exceptions;
using ExpenseTrackerAPI.Repositorys.UserAccounts.Model;
using ExpenseTrackerAPI.Repositorys.UserAccounts.Model.ExpenseTrackerDataAccess.Repositorys.UserAccounts.Model;
using ExpenseTrackerAPI.Requests.UserAccount;
using ExpenseTrackerAPI.Responses;
using ExpenseTrackerAPI.Responses.UserAccount;
using ExpenseTrackerAPI.Services.UserAccountServices;

namespace ExpenseTrackerAPI.Menagers.UserAccountsMenagers
{
    public class UserAccountManager : IUserAccountManager
    {
        private readonly IUserAccountServices _IUserAccountServices;

        public UserAccountManager(
            IUserAccountServices userAccountServices
            )
        {
            _IUserAccountServices = userAccountServices;
        }

        public async Task<UserAccountCreateResponse> CreateUserAccountAsync(UserAccountCreateRequest? createRequest)
        {
            if (createRequest is null)
            {
                throw new BadRequestException(ExpenseApiDisplayMessages.UserAccountNotFound );
            }
            var userAccountCreateModel = new UserAccountCreateModel(
                createRequest.Login,
                createRequest.Password,
                createRequest.AccountingPeriod,
                createRequest.Localisation,
                createRequest.IsActive,
                createRequest.UserRole
                );
            var useraccount = await _IUserAccountServices.CreateUserAccountAsync(userAccountCreateModel);
            var response = new UserAccountCreateResponse(
                useraccount.Id,
                useraccount.Login,
                useraccount.Password,
                useraccount.Localisation
                );
            return response;
        }

        public async Task<List<AccountGetResponse>> GetAllUserAccounts()
        {
            List<AccountGetResponse> acctRespList = new List<AccountGetResponse>();
            var alluseraccountsEntity = await _IUserAccountServices.GetAllUserAccount();
            foreach (var a in alluseraccountsEntity)
            {
                var acctGetResp = new AccountGetResponse
                (
                    Id: a.Id,
                    Login: a.Login,
                    Localisation: a.Localisation

                );

                acctRespList.Add(acctGetResp);
            }

            return acctRespList;
        }

        public async Task<AccountGetResponse> GetUserAccountbyId(int id)
        {
            var retVal = await _IUserAccountServices.GetUserAccountbyId(id);

            if (retVal is null)
            {
                throw new NotFoundException(ExpenseApiDisplayMessages.UserAccountNotFound);
            }

            return new AccountGetResponse(
                retVal.Id,
                retVal.Login,
                retVal.Localisation
            );
        }

        public async Task UpdateTeamByIdAsync(int id, UserAccountPutRequest putRequest)
        {
            if (putRequest is null)
            {
                throw new BadRequestException();
            }
            try
            {
                await _IUserAccountServices.UpdateTeamByIdAsync(id, putRequest);
            }
            catch (EntityNotFoundException<UserAccount>)
            {
                throw new NotFoundException(ExpenseApiDisplayMessages.UserAccountNotFound);
            }
        }
    }
}
