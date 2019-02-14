using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;

namespace BackendBankdb.Repositories
{
    public interface IBankRepository
    
            {
        //CRUD
        Bank CreateBank(Bank bank);
        List<Bank> ReadBanks(); //hakee kaiken tiedon listaus
        List<Bank> ReadBank(string name);
        Bank ReadBank(int id); // hakee yksittäisen tiedon,kuormitettu read metodi, 
        //Person Read(string name); 
        Bank UpdateBank(int id, Bank bank);
        void DeleteBank(int Id); //poisto 



    
}
}
