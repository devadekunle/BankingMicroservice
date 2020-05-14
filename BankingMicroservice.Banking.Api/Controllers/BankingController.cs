using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingMicroservice.Banking.Application.Interfaces;
using BankingMicroservice.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BankingMicroservice.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {

        private readonly ILogger<BankingController> _logger;
        private readonly IAccountService _accountService;
        public BankingController(ILogger<BankingController> logger, IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }
    }
}
