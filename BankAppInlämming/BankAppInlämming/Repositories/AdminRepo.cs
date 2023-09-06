using BankAppInlämming.Models;
using BankAppInlämming.Repositories.Interfaces;

namespace BankAppInlämming.Repositories
{
    public class AdminRepo : IAdminRepo
    {
        private readonly BankAppContext _context;

        public AdminRepo(BankAppContext context)
        {
            _context = context;
        }

        public int AddAcountType(AccountType accountType)
        {
            _context.AccountTypes.Add(accountType);
            _context.SaveChanges();
            return accountType.AccountTypeId;
        }

        public int AddCustomer(string name)
        {
            Customer customer = new Customer();
            customer.Namn = name;
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer.CustomerId;
        }

        public int AddLoan(Loan loan)
        {
            _context.Add(loan);
            _context.Accounts.SingleOrDefault(p => p.AccountId == loan.AccountId).Balance += loan.Amount;
            _context.SaveChanges();
                return loan.LoanId;
        }
    }
}
