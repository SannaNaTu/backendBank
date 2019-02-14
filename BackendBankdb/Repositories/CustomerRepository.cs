using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendBankdb.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendBankdb.Repositories
{
    public class CustomerRepository : ICustomerRepository //JOKU ONGELMA!!

    {
        private readonly BackendbankdbContext _context;

        public CustomerRepository(BackendbankdbContext context)

        

        {
            _context = context;
        }

        public CustomerRepository()
        {
        }

        //create
        public Customer CreateCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
            return customer;

        


         

        }
        //DELETE
        public Customer DeleteCustomer(Customer customer)
        {

            _context.Customer.Remove(customer);
            _context.SaveChanges();
            return customer;
        }


        //UPDATE

        public Customer UpdateCustomer(Customer customer, int id)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return customer;
        }







        public Customer ReadCustomer(int id)
        {
            return _context.Customer
              
              .Include(a => a.Account)
              .FirstOrDefault(p => p.Id == id);
        }



        public List<Customer> ReadCustomer(string name)
        {
            return _context.Customer

         .Include(a => a.Account)
         .ToList();
      
        }
    }
}
