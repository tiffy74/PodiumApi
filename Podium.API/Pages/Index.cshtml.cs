using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Podium.API.Models;
using Podium.API.Pages.Customers;

namespace Podium.API.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly Podium.API.Models.CstomerDbContext _context;

        public CreateModel(Podium.API.Models.CstomerDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            
            return Page();
        }



        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            // calculate customer age

            var CustomerAge = Customer.DateOfBirth;
            var today = DateTime.Today;
            var Age = today.Year - CustomerAge.Year;

            if (Age < 18)
            {
                return RedirectToPage("./NoAccess");
            }
            if (!ModelState.IsValid)
            {
                
                return Page();
            }
            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();
            // var CustomerId = Customer.Id;
            if (ModelState.IsValid)
            {
                var CustomerId = Customer.Id;
                ViewData["success"] = "Thank you for submitting your details.  Your Customer Id number is:" + "  " + "LTV" + CustomerId;
                return RedirectToPage("./Index");
            }
            
            return RedirectToPage("./Index");
        }
    }
}
