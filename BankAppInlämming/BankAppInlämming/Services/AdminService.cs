using BankAppInlämming.Models;
using BankAppInlämming.Services.Interfaces;
using BankAppInlämming.Repositories.Interfaces;

namespace BankAppInlämming.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepo _adminRepo;

        public AdminService(IAdminRepo adminRepo)
        {
            _adminRepo = adminRepo;
        }

        public int AddAcountType(AccountType accountType)
        {
            return _adminRepo.AddAcountType(accountType);
        }

        public int AddCustomer(string name)
        {
           return (_adminRepo.AddCustomer(name));
        }

        public int AddLoan(Loan loan)
        {
            return(_adminRepo.AddLoan(loan));
        }
    }
}
