using AccountOwner.Domain.Contracts;
using AccountOwner.Domain.EF.Context;
using AccountOwner.Domain.EF.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Core.Repositories
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(AccountOwnerContext db) : base(db)
        {
        }
    }
}
