using BankLoan.Models;
using BankLoan.Models.Contracts;
using BankLoan.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Repositories
{
    public class LoanRepository : IRepository<Loan>
    {
        private List<Loan> loans;
        public LoanRepository()
        {
            loans = new List<Loan>();
        }
        public IReadOnlyCollection<Loan> Models => loans.AsReadOnly();
        public void AddModel(Loan model)
        {
             loans.Add(model);
        }

        public Loan FirstModel(string name)
        {
           return loans.FirstOrDefault(l => l.GetType().Name == nameof(loans));
        }

        public bool RemoveModel(Loan model)
        {
           return loans.Remove(model);
        }
    }
}
