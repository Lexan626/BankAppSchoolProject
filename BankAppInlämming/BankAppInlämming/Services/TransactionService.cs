using BankAppInlämming.Services.Interfaces;
using System.Transactions;
using BankAppInlämming.Repositories.Interfaces;

namespace BankAppInlämming.Services
{
    public class TransactionService : ITransactionService
    {
        public readonly ITransactionRepo _transactionRepo;

        public TransactionService(ITransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        public void AddTransaction(Models.Transaction transaction)
        {
          _transactionRepo.AddTransaction(transaction);
        }

      
        public List<Models.Transaction> GetAllTransactions(int id)
        {
          return(_transactionRepo.GetAllTransactions(id));
        }
    }
}
