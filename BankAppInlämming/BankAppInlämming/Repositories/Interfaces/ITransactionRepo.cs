using BankAppInlämming.Models;
namespace BankAppInlämming.Repositories.Interfaces
{
    public interface ITransactionRepo
    {
        void AddTransaction(Models.Transaction transaction);

        List<Models.Transaction> GetAllTransactions(int id);
    }
}
