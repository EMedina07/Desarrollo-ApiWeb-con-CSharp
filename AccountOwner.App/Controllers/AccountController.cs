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
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService = null;
        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpGet("OwnerForSelection")]
        public IActionResult OwnerForSelection()
        {
            return Ok(this.accountService.OwnerForSlection());
        }

        [HttpPost("RegisterAcccount")]
        public IActionResult RegisterAcccount(AccountInputDTO account)
        {
            this.accountService.AddAccount(account);
            return Ok();
        }
    }
}
