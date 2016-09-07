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
        public IHttpActionResult GetCustomers()
        {
            return Ok(_context.Customers.ToList());
        }

        public Customer Customer(int id)
        {
            return _context.Customers.SingleOrDefault(c => c.Id == id);
        }

       // POST/...
        [HttpPost]
        public IHttpActionResult CreatCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + customer.Id),customer);
        }

        //Put/.../1
        [HttpPut]
        public void UpdateCustomer(int id,Customer customer) {
            if (!ModelState.IsValid)
                throw new HttpRequestException();

            var customerDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerDb.Name = customer.Name;
            customerDb.MembershipeTypeId = customer.MembershipeTypeId;
            customerDb.IsSubscribedToLettler = customer.IsSubscribedToLettler;
            customerDb.Birthday = customer.Birthday;

            _context.SaveChanges();

        }

        // Delet/.../id
        [HttpDelete]
        public void DeleteCustomer(int id) {
            var customerDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerDb);

            _context.SaveChanges();
        }
    }
}
