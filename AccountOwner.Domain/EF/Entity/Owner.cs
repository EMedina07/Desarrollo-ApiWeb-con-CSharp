using System;
using System.Collections.Generic;

#nullable disable

namespace AccountOwner.Domain.EF.Entity
{
    public partial class Owner
    {
        public Owner()
        {
            Accounts = new HashSet<Account>();
        }

        public int OwnerId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
