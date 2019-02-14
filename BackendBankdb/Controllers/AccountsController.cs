using BackendBankdb.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;

namespace BackendBankdb.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        //by id
        [HttpGet("{id}")]
        public ActionResult<Account> Get(int Id)
        {
            return new JsonResult(_accountService.ReadAccount(Id));
        }


        // GET api/accounts
        [HttpGet]
        public ActionResult<List<Account>> GetAccounts()
        {
            return new JsonResult(_accountService.ReadAccounts());
        }

        // DELETE api/accounts/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int Id)
        {
            _accountService.DeleteAccount(Id);
            return new NoContentResult();
        }
    }
}
