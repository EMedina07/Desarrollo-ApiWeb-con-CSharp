using AccountOwner.Domain.EF.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Domain.Contracts
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
    }
}
