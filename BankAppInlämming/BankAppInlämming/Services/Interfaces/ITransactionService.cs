using System.Transactions;

namespace BankAppInlämming.Services.Interfaces
{
    public interface ITransactionService
    {
        void AddTransaction(Models.Transaction transaction);

        List<Models.Transaction> GetAllTransactions(int id);
    }

}
