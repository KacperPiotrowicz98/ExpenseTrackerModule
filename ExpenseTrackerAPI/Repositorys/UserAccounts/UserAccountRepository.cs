using ExpenseTrackerAPI.EF;
using ExpenseTrackerAPI.EF.Models;
using ExpenseTrackerAPI.Extensions;
using ExpenseTrackerAPI.Repositorys.Exceptions;
using ExpenseTrackerAPI.Repositorys.UserAccounts.Model.ExpenseTrackerDataAccess.Repositorys.UserAccounts.Model;
using ExpenseTrackerAPI.Requests.UserAccount;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerAPI.Repositorys.UserAccounts
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly ExpenseContext _dbcontext;
        private readonly IDbContextFactory<ExpenseContext> _contextFactory;

        public UserAccountRepository(ExpenseContext dbcontext, IDbContextFactory<ExpenseContext> contextFactory)
        {
            _dbcontext = dbcontext;
            _contextFactory = contextFactory;
        }



        public async Task<UserAccount> CreateAsync(UserAccountCreateModel model)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                var userAccount = new UserAccount(
                    model.Login,
                    model.Password,
                    model.AccountingPeriod,
                    model.Localisation,
                    model.IsActive,
                    model.UserRole


                    );
                _ = await context.UserAccounts.AddAsync(userAccount);
                _ = await context.SaveChangesAsync();
                return userAccount;
            }
        }

        public async Task<List<UserAccount>> GetAllUserAccount()
        {

            return await _dbcontext.UserAccounts.ToListAsync();

        }

        public async Task<UserAccount> GetByIdAsync(int id)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return await GetByIdAsync(id, trackChanges: false, context);
            }
        }

        private static async Task<UserAccount> GetByIdAsync(int id, bool trackChanges, ExpenseContext context)
        {
            return await context.UserAccounts.SetTracking(trackChanges).SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, UserAccountPutRequest putRequest)
        {
            using (var dbContext = _contextFactory.CreateDbContext())
            {
                var user = await GetByIdAsync(id, trackChanges: true, dbContext);

                if (user is null)
                {
                    throw new EntityNotFoundException<UserAccount>();
                }

                user.Login = putRequest.Login;
                user.Password = putRequest.Password;
                user.AccountingPeriod = putRequest.AccountingPeriod;
                user.Localisation = putRequest.Localisation;
                user.IsActive = putRequest.IsActive;
                _ = await dbContext.SaveChangesAsync();

            }
        }



    }
}
