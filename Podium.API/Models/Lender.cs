using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podium.API.Models
{
    public class Lender
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public int InterestRate { get; set; }
        public string LoanType { get; set; }
        public int Ltv { get; set; }
    }
}
