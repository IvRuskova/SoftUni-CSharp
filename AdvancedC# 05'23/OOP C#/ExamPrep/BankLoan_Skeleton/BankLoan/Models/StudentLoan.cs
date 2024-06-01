using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public class StudentLoan:Loan
    {
        private const double StudentLoanAmount = 10_000;
        private const int StudentLoanInterestRate = 1;

        public StudentLoan() : base(StudentLoanInterestRate,StudentLoanAmount)
        {
        }
    }
}
