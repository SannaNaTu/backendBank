using BackendBankdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBankdb.Services
{
    public interface ITransactionService
    {
        Transaction CreateTransaction(Transaction transaction);
        List<Transaction> ReadTransactions();
        List<Transaction> ReadTransaction(DateTime startDate, DateTime endDate);
        Transaction ReadTransaction(int id);
    }
}

