using BankAppInlämming.Models;
using BankAppInlämming.Repositories.Interfaces;

namespace BankAppInlämming.Repositories
{
    public class AccountRepo : IAccountRepo
    {

        private readonly BankAppContext _context;

        public AccountRepo(BankAppContext context)
        {
            _context = context;
        }

        public int AddAccount(Models.Account account)
        {
            _context.Accounts.Add(account);
          return(_context.SaveChanges());     
        }

        public List<Account> GetAccounts(int id)
        {
            return (_context.Accounts.Where(p => p.CustumerId == id).ToList()); 
        }

        public List<AccountType> GetAllAccountsTypes()
        {
           return(_context.AccountTypes.ToList());
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
