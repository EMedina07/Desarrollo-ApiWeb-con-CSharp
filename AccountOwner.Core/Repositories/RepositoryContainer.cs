using AccountOwner.Domain.Contracts;
using AccountOwner.Domain.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Core.Repositories
{
    public class RepositoryContainer : IRepositoryContainer
    {
        private IOwnerRepository ownerRepository = null;
        private IAccountRepository accountRepository = null;

        private readonly AccountOwnerContext context = null;
        public RepositoryContainer(AccountOwnerContext context)
        {
            this.context = context;
        }

        public IOwnerRepository OwnerRepository
        {
            get
            {
                if(this.ownerRepository == null)
                {
                    this.ownerRepository = new OwnerRepository(this.context);
                }

                return this.ownerRepository;
            }
        }

        public IAccountRepository AccountRepository
        {
            get 
            {
                if (this.accountRepository == null)
                {
                    this.accountRepository = new AccountRepository(this.context);
                }

                return this.accountRepository;
            }
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
