using BankAppInlämming.Models;
using BankAppInlämming.Services.Interfaces;
using BankAppInlämming.Repositories.Interfaces;

namespace BankAppInlämming.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepo _accountRepo;

        public AccountService(IAccountRepo accountRepo)
        {
            _accountRepo = accountRepo;
        }

        public int AddAccount(Account account)
        {
            return _accountRepo.AddAccount(account);
        }

        public List<Account> GetAccounts(int id)
        {
           return(_accountRepo.GetAccounts(id));

        }

        public List<AccountType> GetAllAccountsTypes()
        {
            return(_accountRepo.GetAllAccountsTypes());
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
