using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;
using BackendBankdb.Repositories;

namespace BackendBankdb.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankService(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }


        public Bank CreateBank(Bank bank)
        {
            return _bankRepository.CreateBank(bank);
        }

        public void DeleteBank(int id)
        {
            _bankRepository.DeleteBank(id);
        }


        public List<Bank> ReadBank(string name)
        {
            return _bankRepository.ReadBank(name);
        }

        public Bank ReadBank(int id)
        {
            return _bankRepository.ReadBank(id);
        }

        public List<Bank> ReadBanks()
        {
            return _bankRepository.ReadBanks();
        }



        public Bank UpdateBank(int id, Bank bank)
        {
            var savedBank = _bankRepository.ReadBank(id);
            if(savedBank == null)
            {
                throw new Exception("Bank not found");
            }
            else
            {
                return _bankRepository.UpdateBank(id, bank);
            }
        }
    }
}
