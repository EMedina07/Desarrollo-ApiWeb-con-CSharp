using AccountOwner.Shared.DTO.InputDTO;
using AccountOwner.Shared.DTO.OutputDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Feature.Interfaces
{
    public interface IAccountService
    {
        List<OwnerForSelectionDTO> OwnerForSlection();
        void AddAccount(AccountInputDTO account);
    }
}
