using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwner.Shared.DTO.OutputDTO
{
    public class OwnerOutputDTO
    {
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
    }
}
