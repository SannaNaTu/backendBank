using BackendBankdb.Models;
using BackendBankdb.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBankdb.Controllers
{
    [Route("api/transactions")]
    [ApiController]
    public class TransactionController : ControllerBase
    { 
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
    
        //GET DATETIME
        [HttpGet("transactions/{startDate}/{endDate?}")]
        public ActionResult<List<Transaction>> ReadTransactionByDate(DateTime startDate, DateTime endDate)
        {
            return new JsonResult(_transactionService.ReadTransaction(startDate, endDate));
        }
        //BY ID
        [HttpGet("{id}")]
        public ActionResult<Transaction> GetTransactions(int id)
        {
            return new JsonResult(_transactionService.ReadTransaction(id));
        }
        // GET api/transactions
        [HttpGet]
        public ActionResult<List<Transaction>> GetTransactions()
        {
            return new JsonResult(_transactionService.ReadTransactions());
        }
        // POST api/transactions
        [HttpPost]
        public ActionResult<Transaction> Post(Transaction transaction)
        {
            return _transactionService.CreateTransaction(transaction);
        }
    }
}
