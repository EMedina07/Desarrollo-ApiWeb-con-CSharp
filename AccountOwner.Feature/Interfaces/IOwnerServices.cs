using AccountOwner.Domain.EF.Entity;
using AccountOwner.Shared.DTO.InputDTO;
using AccountOwner.Shared.DTO.OutputDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Feature.Interfaces
{
    public interface IOwnerServices
    {
        List<OwnerOutputDTO> GetOwners();
        void CreateOwner(OwnerInputDTO owner);
        void UpdateOwner(int id, OwnerInputDTO owner);
        void DeleteOwner(int id);
        OwnerOutputDTO GetOwnerById(int id);
        List<OwnerDetailDTO> GetDetail(int id);
    }
}
