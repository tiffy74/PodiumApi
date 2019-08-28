using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Podium.API.Models
{
    public class CstomerDbContext : DbContext
    {
        public CstomerDbContext (DbContextOptions<CstomerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Podium.API.Models.Customer> Customer { get; set; }
    }
}
