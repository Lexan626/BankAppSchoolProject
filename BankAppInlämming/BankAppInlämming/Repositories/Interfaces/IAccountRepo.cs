using BankAppInlämming.Models;
namespace BankAppInlämming.Repositories.Interfaces
{
    public interface IAccountRepo
    {
        List<Account> GetAccounts(int id);

        Account GetById(int id);

        int AddAccount(Account account);

        List<AccountType> GetAllAccountsTypes();
    }
}
