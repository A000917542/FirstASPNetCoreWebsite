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
    public class DetailsModel : PageModel
    {
        private readonly FirstASPNetCoreWebsite.Context.DataContext _context;

        public DetailsModel(FirstASPNetCoreWebsite.Context.DataContext context)
        {
            _context = context;
        }

        public FirstASPNetCoreWebsite.Models.Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
