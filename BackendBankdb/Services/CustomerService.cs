using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;
using BackendBankdb.Repositories;
using BackendBankdb.Utilities;

namespace BackendBankdb.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

      
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer CreateCustomer(Customer customer)
       
        {
            customer.Psw = PswHash.HashPassword(customer.Psw, "salt");
            return _customerRepository.CreateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }

        public Customer ReadCustomer(int id)
        {
            return _customerRepository.ReadCustomer(id);
        }

        public List<Customer> ReadCustomer()
        {
            throw new NotImplementedException();
        }

        public Customer UpdateCustomer(Customer customer, int id)
        {
            var updateCustomer = _customerRepository.ReadCustomer(id);
            if (updateCustomer == null)
                throw new Exception("Customer not found");
            customer.Psw = PswHash.HashPassword(customer.Psw, "salt");
            return _customerRepository.UpdateCustomer(customer, id);
        }
    }
}
