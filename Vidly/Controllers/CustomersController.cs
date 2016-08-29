using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer

        //public List<Customer> getcustomer()
        //{
        //    var customer = new List<Customer> {
        //        new Customer {Name="likai1",Id =1 },
        //        new Customer {Name="likai2",Id =2 },
        //   };
        //    return customer;


        //}

        private List<Customer> getcustomer()
        {
            return new List<Customer>
             {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
        public ActionResult Index()
        {

            var ViewModel = new CustomerModels
            {
                Customer = getcustomer()

            };
            var customers = getcustomer();
            return View(ViewModel);
        }


        public ActionResult Details(int id)
        {

            var customer = getcustomer().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

       
    }
}