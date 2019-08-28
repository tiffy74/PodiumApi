using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Podium.API.Models;

namespace Podium.API.Pages
{
    public class NoAccessModel : PageModel
    {
        private readonly Podium.API.Models.CstomerDbContext _context;

        public NoAccessModel(Podium.API.Models.CstomerDbContext context)
        {
            _context = context;
        }
        
    }
}
