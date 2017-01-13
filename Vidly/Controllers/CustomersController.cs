using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View(customers.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return HttpNotFound();
            }

            var customer = customers.Where(c => c.Id == id.Value).SingleOrDefault();

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }


        IList<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Doe" },
            new Customer { Id = 2, Name = "Marry Willians" }
        };
    }
}