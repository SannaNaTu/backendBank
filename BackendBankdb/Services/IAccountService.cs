using BackendBankdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBankdb.Services
{
   public interface IAccountService
    {
        Account CreateAccount(Account account);
        List<Account> ReadAccounts();
        Account ReadAccount(int id);
        Account UpdateAccount(int Id, Account account);
        void DeleteAccount(int id);
    }
}
