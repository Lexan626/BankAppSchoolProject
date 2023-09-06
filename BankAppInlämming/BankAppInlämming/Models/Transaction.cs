using System;
using System.Collections.Generic;

namespace BankAppInlämming.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int AccountIdFrom { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int AccountIdto { get; set; }

        public virtual Account? AccountIdFromNavigation { get; set; } = null!;
    }
}
