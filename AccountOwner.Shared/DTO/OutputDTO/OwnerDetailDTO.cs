using AccountOwner.Domain.EF.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Shared.DTO.OutputDTO
{
    public class OwnerDetailDTO
    {
        public int AccountId { get; set; }
        public string AccountType { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
