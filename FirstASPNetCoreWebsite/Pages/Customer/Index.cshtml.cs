using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstASPNetCoreWebsite.Context;
using FirstASPNetCoreWebsite.Models;

namespace FirstASPNetCoreWebsite.Pages.CustomerPage
{
    public class IndexModel : PageModel
    {
        private readonly FirstASPNetCoreWebsite.Context.DataContext _context;

        public IndexModel(FirstASPNetCoreWebsite.Context.DataContext context)
        {
            _context = context;
        }

        public IList<FirstASPNetCoreWebsite.Models.Customer> Customer { get;set; }
        public String SqlText { get; set; }

        public async Task OnGetAsync()
        {
            var query = _context.Customers.Where(cust => cust.AmountSpent >= 50.00M).OrderBy(cust => cust.Password.Length).ThenByDescending(cust => cust.AmountSpent).AsQueryable();
            SqlText = query.ToQueryString();
            Customer = await query.ToListAsync();
        }
    }
}
