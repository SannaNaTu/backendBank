using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;

namespace BackendBankdb.Services
{
    public interface IBankService
    {
        Bank CreateBank(Bank bank);
        List<Bank> ReadBanks();
        List<Bank> ReadBank(string name);
        Bank ReadBank(int id);
        Bank UpdateBank(int id, Bank bank);
        void DeleteBank(int id);
    }
}
