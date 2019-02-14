using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;
using BackendBankdb.Repositories;

namespace BackendBankdb.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Account CreateAccount(Account account)
        {
            return _accountRepository.CreateAccount(account);
        }

        public void DeleteAccount(int id)
        {
            _accountRepository.DeleteAccount(id);
        }

        public Account ReadAccount(int id)
        {
            return _accountRepository.ReadAccount(id);
        }

        public List<Account> ReadAccounts()
        {
            return _accountRepository.ReadAccounts();
        }

        public Account UpdateAccount(int Id, Account account)
        {
            var savedAccount = _accountRepository.ReadAccount(Id);
                if(savedAccount == null)
            {
                throw new Exception("Account not found");
            }
            else
            {
                return _accountRepository.UpdateAccount(Id, account);
            }
        }


    }
}
