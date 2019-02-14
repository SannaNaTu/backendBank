using BackendBankdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BackendBankdb.Repositories
{
    public interface ITransactionRepository
    {
        Transaction CreateTransaction(Transaction transaction);
        List<Transaction> ReadTransactions();
        List<Transaction> ReadTransaction(DateTime startDate, DateTime endDate);
        List<Transaction> Transactions(string LastName, string FisrtName);
        Transaction ReadTransaction(int id);
        Transaction UpdateTranscation(int Id, Transaction transaction);
    }
}
