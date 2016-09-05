using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext _context;

        private CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET/Api/Customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer Customer(int id)
        {
            return _context.Customers.SingleOrDefault(c => c.Id == id);
        }

        // POST/...
        //[HttpPost]
        //public Customer CreatCustomer(Customer customer)
        //{
        //    if(!ModelState)
        //}
    }
}
