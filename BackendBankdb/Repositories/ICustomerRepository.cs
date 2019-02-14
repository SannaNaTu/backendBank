using BackendBankdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBankdb.Repositories
{
    public interface ICustomerRepository
    {
        Customer CreateCustomer(Customer customer);
 

        List<Customer> ReadCustomer(string name);
        Customer ReadCustomer(int id);
        Customer UpdateCustomer(Customer customer,int id);
        Customer DeleteCustomer(Customer customer);
    }
}
