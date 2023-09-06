using BankAppInlämming.Models;
using BankAppInlämming.Repositories.Interfaces;

namespace BankAppInlämming.Repositories
{
    public class TransactionRepo : ITransactionRepo
    {
        private readonly BankAppContext _context;

        public TransactionRepo(BankAppContext context)
        {
            _context = context;
        }

        public void AddTransaction(Models.Transaction transaction)
        {
            transaction.Date = DateTime.Now;
            _context.Transactions.Add(transaction);
            _context.Accounts.SingleOrDefault(x => x.AccountId == transaction.AccountIdFrom).Balance += -transaction.Amount;
            _context.Accounts.SingleOrDefault(y => y.AccountId == transaction.AccountIdto).Balance += transaction.Amount;
            _context.SaveChanges();
        }

        public List<Transaction> GetAllTransactions(int id)
        {
          return(_context.Transactions.Where(p =>p.AccountIdFrom == id || p.AccountIdto == id).ToList());
        }
    }
}
