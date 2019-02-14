using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendBankdb.Repositories
{
    public class BankRepository : IBankRepository
    {

        private readonly BackendbankdbContext _context;

        public BankRepository(BackendbankdbContext context)
        {
            _context = context;
        }

        //CREATE

        public Bank CreateBank(Bank bank)
        {
            _context.Add(bank);
            _context.SaveChanges();
            return bank;
        }

        //DELETE 

        public void DeleteBank(int id)
        {
            var deletedBank = ReadBank(id);
            _context.Bank.Remove(deletedBank);
            _context.SaveChanges();
            return;
        }

        public List<Bank> ReadBank(string name)
        {
            return _context.Bank.FromSql("Select * From Bank").ToList();
        }

        public Bank ReadBank(int id)
        {
            return _context.Bank
                .AsNoTracking()
                .Include(p => p.Account)
                .Include(p => p.Customer)
                .FirstOrDefault(p => p.Id == id);
        }

        public List<Bank> ReadBanks()
        {
            return _context.Bank.FromSql("Select * From Bank").ToList();
        }

        public Bank UpdateBank(int id,Bank bank)
        {
            _context.Update(bank);
            _context.SaveChanges();
            return bank;
        }
    }
}
