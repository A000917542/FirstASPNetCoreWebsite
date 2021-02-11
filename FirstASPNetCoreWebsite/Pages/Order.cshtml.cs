using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstASPNetCoreWebsite.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstASPNetCoreWebsite.Pages
{
    public class OrderModel : PageModel
    {
        [FromForm]
        public Order Order { get; set; } = new Order();

        private List<Customer> Customers { get; set; } = new List<Customer>();

        public IEnumerable<SelectListItem> CustomerList { get; private set; }

        public OrderModel()
        {
            Customer a = new Customer()
            {
                Name = "Brent",
                Email = "brent.ritchie@cambriancollege.ca",
                ID = 4
            };

            Customer b = new Customer()
            {
                Name = "Chris",
                Email = "chris.dude@cambriancollege.ca"
            };

            Customer c = new Customer()
            {
                Name = "Manoir",
                Email = "manoir.dude@cambriancollege.ca"
            };

            Customers.Add(a);
            Customers.Add(b);
            Customers.Add(c);
        }

        public void OnGet()
        {

            //CustomerList = Customers.Select(cust =>
            //{
            //    return new SelectListItem(String.Format("{0} ({1})", cust.Name, cust.Email), cust.Email);
            //});

            List<SelectListItem> list = new List<SelectListItem>();

            foreach(var cust in Customers)
            {
                list.Add(new SelectListItem(cust.Name, cust.Email));
            }

            CustomerList = list;
        }

        public void OnPost()
        {

        }
    }
}
