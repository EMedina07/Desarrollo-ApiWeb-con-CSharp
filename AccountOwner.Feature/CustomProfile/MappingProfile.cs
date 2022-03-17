using AccountOwner.Domain.EF.Entity;
using AccountOwner.Shared.DTO.InputDTO;
using AccountOwner.Shared.DTO.OutputDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Feature.CustomProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerOutputDTO>();
            CreateMap<OwnerInputDTO, Owner>();
            CreateMap<AccountInputDTO, Account>();
        }
    }
}
