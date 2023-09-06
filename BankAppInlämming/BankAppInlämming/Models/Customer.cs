using System;
using System.Collections.Generic;

namespace BankAppInlämming.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Accounts = new HashSet<Account>();
        }

        public int CustomerId { get; set; }
        public string? Namn { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
