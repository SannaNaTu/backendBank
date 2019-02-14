using BackendBankdb.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;



namespace BackendBankdb.Controllers
{
    [Route("api/bank")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BanksController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet]
        public ActionResult<List<Bank>> Get()
        {
            return new JsonResult(_bankService.ReadBanks());
        }
        //by id
        [HttpGet("{id}")]
        public ActionResult<Bank> Get(int id)
        {
            return new JsonResult(_bankService.ReadBank(id));
        }



        // POST api/banks
        [HttpPost]
        public ActionResult<Bank> Post(Bank bank)
        {
            return _bankService.CreateBank(bank);
        }

        // PUT api/banks/5
        [HttpPut("{id}")]
        public ActionResult<Bank> Put(int id, Bank bank)
        {
            return _bankService.UpdateBank(id, bank);
        }

        // DELETE api/banks/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _bankService.DeleteBank(id);
            return new NoContentResult();
        }
    }
}
