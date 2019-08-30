using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Podium.API.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LenderDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LenderDbContext>>()))
            {
                // Look for any movies.
                if (context.Lender.Any())
                {
                    return;   // DB has been seeded
                }

                context.Lender.AddRange(
                    new Lender
                    {
                        Id = 1,
                        BankName = "Bank A",
                        InterestRate = 2,
                        LoanType = "Variable",
                        Ltv = 60
                    },

                    new Lender
                    {
                        Id = 2,
                        BankName = "Bank B",
                        InterestRate = 3,
                        LoanType = "Fixed",
                        Ltv = 60
                    },

                    new Lender
                    {
                        Id = 3,
                        BankName = "Bank C",
                        InterestRate = 4,
                        LoanType = "Variable",
                        Ltv = 90
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
