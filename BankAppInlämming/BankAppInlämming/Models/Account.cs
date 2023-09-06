using System;
using System.Collections.Generic;

namespace BankAppInlämming.Models
{
    public partial class Account
    {
        public Account()
        {
            Loans = new HashSet<Loan>();
            Transactions = new HashSet<Transaction>();
        }

        public int AccountId { get; set; }
        public decimal Balance { get; set; }
        public int AccountTypeId { get; set; }
        public int CustumerId { get; set; }

        public virtual AccountType? AccountType { get; set; } = null!;
        public virtual Customer? Custumer { get; set; } = null!;
        public virtual ICollection<Loan>? Loans { get; set; } = null!;
        public virtual ICollection<Transaction>? Transactions { get; set; } = null!;
    }
}
