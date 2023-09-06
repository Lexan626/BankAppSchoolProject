using BankAppInlämming.Models;

namespace BankAppInlämming.Services.Interfaces
{
    public interface IAccountService
    {
        List<Account> GetAccounts(int id);

        Account GetById(int id);

        int AddAccount(Account account);

        List<AccountType> GetAllAccountsTypes();
    }
}
