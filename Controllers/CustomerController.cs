using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebDemoCodeBootcamp.Models;

namespace WebDemoCodeBootcamp.Controllers
{
    [Route("api/[controller]")] //--> "api/customer"
    public class CustomerController : Controller
    {
        [Route("moikka")] //-->"api/customer/moikka"
        public string GetMoi() {
            return "Moikka";
        }

        [Route("luvut")] //-->"api/customer/luvut"
        public int[] GetLuvut() {
            return new int[] {1, 2, 3, 4, 5};
        }
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
