using AccountOwner.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Core
{
    public interface IRepositoryContainer
    {
        public IOwnerRepository OwnerRepository { get; }
        public IAccountRepository AccountRepository { get; }

        void Save();
    }
}
