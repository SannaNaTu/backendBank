using BackendBankdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBankdb.Services
{
    public interface ICustomerService
    {
        Customer CreateCustomer(Customer customer);
        List<Customer> ReadCustomer();
     
        Customer ReadCustomer(int id);
        Customer UpdateCustomer(Customer customer, int id);
        void DeleteCustomer(int id);
    }
}
