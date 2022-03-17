using AccountOwner.Feature.Interfaces;
using AccountOwner.Shared.DTO.InputDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountOwner.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerServices ownerServices = null;

        public OwnerController(IOwnerServices ownerServices)
        {
            this.ownerServices = ownerServices;
        }

        [HttpGet("GetOwner")]
        public IActionResult GetOwner()
        {
            return Ok(this.ownerServices.GetOwners());
        }

        [HttpGet("GetOwnerByID")]
        public IActionResult GetOwnerByID(int id)
        {
            return Ok(this.ownerServices.GetOwnerById(id));
        }

        [HttpGet("GetOwnerDetail")]
        public IActionResult GetOwnerDetail(int id)
        {
            return Ok(this.ownerServices.GetDetail(id));
        }

        [HttpPost("CreateOwner")]
        public IActionResult CreateOwner([FromBody] OwnerInputDTO owner)
        {
            this.ownerServices.CreateOwner(owner);

            return Ok();
        }

        [HttpPut("UpdateOwner")]
        public IActionResult UpdateOwner(int id, [FromBody] OwnerInputDTO owner)
        {
            this.ownerServices.UpdateOwner(id, owner);

            return Ok();
        }

        [HttpDelete("DeleteOwner")]
        public IActionResult DeleteOwner(int id)
        {
            this.ownerServices.DeleteOwner(id);

            return Ok();
        }
    }
}
