using AccountOwner.Core;
using AccountOwner.Domain.EF.Entity;
using AccountOwner.Feature.Interfaces;
using AccountOwner.Shared.DTO.InputDTO;
using AccountOwner.Shared.DTO.OutputDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountOwner.Feature.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepositoryContainer repositories = null;
        private readonly IMapper mapper = null;
        public AccountService(IRepositoryContainer repositories, IMapper mapper)
        {
            this.repositories = repositories;
            this.mapper = mapper;
        }
       
        public void AddAccount(AccountInputDTO accountDTO)
        {
            Account account = this.mapper.Map<Account>(accountDTO);

            this.repositories.AccountRepository.Create(account);
            this.repositories.Save();
        }

        public List<OwnerForSelectionDTO> OwnerForSlection()
        {
            return this.repositories.OwnerRepository.GetAll()
                                    .Select(o => new OwnerForSelectionDTO()
                                    {
                                        OwnerId = o.OwnerId,
                                        Name = o.Name
                                    }).ToList();
        }
    }
}
