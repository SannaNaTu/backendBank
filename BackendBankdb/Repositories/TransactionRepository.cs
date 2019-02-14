using BackendBankdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;
using Microsoft.EntityFrameworkCore;


namespace BackendBankdb.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BackendbankdbContext _context;

        public TransactionRepository(BackendbankdbContext context)
        {
            _context = context;
        }


        public Transaction CreateTransaction(Transaction transaction)
        {
            _context.Add(transaction);
            _context.SaveChanges();
            return transaction;
        }


        public List<Transaction> ReadTransaction(DateTime startDate, DateTime endDate)
        {
            return _context.Transaction
                .Where(t => t.TimeStamp >= startDate && t.TimeStamp <= endDate)
                .ToList();
        }

        public Transaction ReadTransaction(int id)
            {
                return _context.Transaction
                    .AsNoTracking()

                    .FirstOrDefault(t => t.AccountId == id);
            }

            public List<Transaction> ReadTransactions()
            {
                return _context.Transaction.FromSql("Select * From Person").ToList();
            }

            public List<Transaction> Transactions(string LastName, string FisrtName)
            {
                throw new NotImplementedException();
            }

            public Transaction UpdateTranscation(int Id, Transaction transaction)
            {
                _context.Transaction.Update(transaction);
                _context.SaveChanges();
                return transaction;
            }


    }
}
