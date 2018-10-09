using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebDemoCodeBootcamp.Models;

namespace WebDemoCodeBootcamp.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        public List<Customer> GetCustomers()
        {
            TestikantaContext context = new TestikantaContext();
            List<Customer> customers = ( from c in context.Customer
                                        where c.LastName =="Gates"
                                        select c).ToList();

            return customers;
        }
    }
}
