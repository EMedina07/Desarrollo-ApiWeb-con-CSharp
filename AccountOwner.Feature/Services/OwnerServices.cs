using AccountOwner.Core;
using AccountOwner.Core.Repositories;
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
    public class OwnerServices : IOwnerServices
    {
        private readonly IRepositoryContainer repositories = null;
        private readonly IMapper mapper = null;

        public OwnerServices(IRepositoryContainer repositories, IMapper mapper)
        {
            this.repositories = repositories;
            this.mapper = mapper;
        }

        public void CreateOwner(OwnerInputDTO owner)
        {
            Owner ownerDTO = this.mapper.Map<Owner>(owner);

            this.repositories.OwnerRepository.Create(ownerDTO);
            this.repositories.Save();
        }

        public void DeleteOwner(int id)
        {
            Owner owner = this.repositories.OwnerRepository.GetByCondition(o => o.OwnerId == id).FirstOrDefault();

            this.repositories.OwnerRepository.Delete(owner);
            this.repositories.Save();
        }

        public List<OwnerOutputDTO> GetOwners()
        {
            var ownersDTO = this.repositories.OwnerRepository.GetAll();
            var owners = new List<OwnerOutputDTO>();

            foreach (var item in ownersDTO)
            {
                owners.Add(this.mapper.Map<OwnerOutputDTO>(item));
            }

            return owners.ToList();
        }

        public OwnerOutputDTO GetOwnerById(int id)
        {
            var owner = this.GetOwners().Where(o => o.OwnerId == id).FirstOrDefault();
            return owner;
        }

        public void UpdateOwner(int id, OwnerInputDTO owner)
        {
            Owner ownerDTO = this.mapper.Map<Owner>(owner);
            ownerDTO.OwnerId = id;

            this.repositories.OwnerRepository.Update(ownerDTO);
            this.repositories.Save();
        }

        public List<OwnerDetailDTO> GetDetail(int id)
        {
            return this.repositories.AccountRepository
                                    .GetByCondition(a => a.OwnerId == id)
                                    .Select(d => new OwnerDetailDTO()
                                    {
                                        AccountId = d.AccountId,
                                        AccountType = d.AccountType,
                                        CreateDate = d.CreateDate
                                    }).ToList();
        }
    }
}
