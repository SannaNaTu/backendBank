using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendBankdb.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BackendbankdbContext _context;

        public AccountRepository(BackendbankdbContext context)
        {
            _context = context;
        }

        //CREATE

        public Account CreateAccount(Account account)
        {
            _context.Add(account);
            _context.SaveChanges();
            return account;
        }

        //DELETE
    

        public void DeleteAccount(int Id)
        {
            var deletedAccount = ReadAccount(Id);
            _context.Account.Remove(deletedAccount);
            _context.SaveChanges();
            return;
            
        }

        //READ

        public Account ReadAccount(int Id)
        {
            return _context.Account
                .AsNoTracking()
                
                .FirstOrDefault(p => p.Id == Id);
        }

        public List<Account> ReadAccounts()
        {
            return _context.Account.FromSql("Select * From Account").ToList();
        }

        //UPDATE
    
        public Account UpdateAccount(int Id,Account account)
        {
            _context.Account.Update(account);
            _context.SaveChanges();
            return account;
        }
        // Nämä loput tekemättä!!




    }
}
