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
    public class DeleteModel : PageModel
    {
        private readonly FirstASPNetCoreWebsite.Context.DataContext _context;

        public DeleteModel(FirstASPNetCoreWebsite.Context.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FindAsync(id);

            if (Customer != null)
            {
                _context.Customers.Remove(Customer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
