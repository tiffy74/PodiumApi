using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Podium.API.Models
{
    public class LenderDbContext : DbContext
    {
        public LenderDbContext (DbContextOptions<LenderDbContext> options)
            : base(options)
        {
        }

        public DbSet<Podium.API.Models.Lender> Lender { get; set; }
    }
}
