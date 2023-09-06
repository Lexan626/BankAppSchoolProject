using System;
using System.Collections.Generic;

namespace BankAppInlämming.Models
{
    public partial class Loan
    {
        public int LoanId { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }

        public virtual Account? Account { get; set; } = null;
    }
}
