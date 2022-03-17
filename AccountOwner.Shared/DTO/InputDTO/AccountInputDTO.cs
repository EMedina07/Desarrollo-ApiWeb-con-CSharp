using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Shared.DTO.InputDTO
{
    public class AccountInputDTO
    {
        public int OwnerId { get; set; }
        public string AccountType { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
