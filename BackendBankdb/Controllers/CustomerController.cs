using BackendBankdb.Models;
using BackendBankdb.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBankdb.Controllers
{
    public class CustomerController
    {
        [Route("api/customers")]
        [ApiController]
        public class CustomersController : ControllerBase
        {
            private readonly ICustomerService _customerService;

            public CustomersController(ICustomerService customerService)
            {
                _customerService = customerService;
            }

            // GET api/customers
            [HttpGet]
            public ActionResult<List<Customer>> GetCustomers()
            {
                return new JsonResult(_customerService.ReadCustomer());
            }

            // POST api/customers
            [HttpPost]
            public ActionResult<Customer> Post(Customer customer)
            {
                return _customerService.CreateCustomer(customer);
            }

            // PUT api/customers/5
            [HttpPut("{id}")]
            public ActionResult<Customer> Put(Customer customer,  int id)
            {
                var updateCustomer = _customerService.UpdateCustomer(customer, id);
            }

            // DELETE api/customers/5
            [HttpDelete("{id}")]
            public ActionResult Delete(int id)
            {
                _customerService.DeleteCustomer(id);
                return new NoContentResult();
            }
        }
    }
}
