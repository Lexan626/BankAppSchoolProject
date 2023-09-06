using BankAppInlämming.Models;

namespace BankAppInlämming.Services.Interfaces
{
    public interface IAdminService
    {
        int AddCustomer(string name);
        int AddLoan(Loan loan);
        int AddAcountType(AccountType accountType);
    }
}
