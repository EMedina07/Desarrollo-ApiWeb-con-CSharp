using System;
using System.Collections.Generic;

#nullable disable

namespace AccountOwner.Domain.EF.Entity
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public int OwnerId { get; set; }
        public string AccountType { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
