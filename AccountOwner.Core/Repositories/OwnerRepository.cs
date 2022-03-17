using AccountOwner.Domain.Contracts;
using AccountOwner.Domain.EF.Context;
using AccountOwner.Domain.EF.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountOwner.Core.Repositories
{
    public class OwnerRepository : BaseRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(AccountOwnerContext db) : base(db)
        {
           
        }
    }
}
