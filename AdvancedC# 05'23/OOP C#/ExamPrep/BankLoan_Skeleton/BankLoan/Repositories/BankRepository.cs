using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLoan.Models;
using BankLoan.Models.Contracts;
using BankLoan.Repositories.Contracts;

namespace BankLoan.Repositories
{
    public class BankRepository : IRepository<Bank>
    {
        private List<Bank> banks;
        public IReadOnlyCollection<Bank> Models => banks.AsReadOnly();

        public void AddModel(Bank model)
        {
            banks.Add(model);
        }

        public Bank FirstModel(string name)
        {
            return banks.FirstOrDefault(l => l.Name == name);
        }

        public bool RemoveModel(Bank model)
        {
           return banks.Remove(model);
        }
    }
}
