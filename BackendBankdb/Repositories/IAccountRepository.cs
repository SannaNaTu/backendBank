using BackendBankdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBankdb.Repositories
{
   public interface IAccountRepository
    {
        Account CreateAccount(Account account);
        List<Account> ReadAccounts();
        Account ReadAccount(int Id);

        Account UpdateAccount(int Id, Account account);
        void DeleteAccount(int Id);
       
    }
}
