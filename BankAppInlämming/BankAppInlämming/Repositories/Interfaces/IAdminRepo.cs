using BankAppInlämming.Models;
namespace BankAppInlämming.Repositories.Interfaces
{
    public interface IAdminRepo
    {
        int AddCustomer(string name);
        int AddLoan(Loan loan);
        int AddAcountType(AccountType accountType);
    }
}
