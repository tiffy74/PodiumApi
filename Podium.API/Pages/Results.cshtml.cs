using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Podium.API.Models;

namespace Podium.API.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly Podium.API.Models.LenderDbContext _context;

        public ResultsModel(Podium.API.Models.LenderDbContext context)
        {
            _context = context;
        }

        public IList<Lender> Lender { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PropertyAmount { get; set; }
        [BindProperty(SupportsGet = true)]
        public float DepositAmount { get; set; }
        public float LTV { get; set; }
        public float CustomerValue { get; set; }
        public float LTVRatio { get; set; }


        public async Task OnGetAsync()
        {
            var lenders = from l in _context.Lender
                          select l;


            if (DepositAmount > 0)
            {
               
                CustomerValue = DepositAmount / PropertyAmount * 100;
                LTVRatio = 100 - CustomerValue;
                lenders = lenders.Where(l => l.Ltv >= LTVRatio);
                    
                
            }
            Lender = await lenders.ToListAsync();

        }
    }
}
