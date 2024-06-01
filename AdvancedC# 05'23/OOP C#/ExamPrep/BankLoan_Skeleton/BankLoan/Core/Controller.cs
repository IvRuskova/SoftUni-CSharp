using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BankLoan.Core.Contracts;
using BankLoan.Models;
using BankLoan.Models.Contracts;
using BankLoan.Repositories;
using BankLoan.Utilities.Messages;

namespace BankLoan.Core
{
    public class Controller : IController
    {
        private LoanRepository loans = new LoanRepository();
        private BankRepository banks= new BankRepository();
        public string AddBank(string bankTypeName, string name)
        {
            IBank bank;
            if (bankTypeName == nameof(CentralBank))
            {
                bank = new CentralBank(name);
            }
            else if(bankTypeName == nameof(BranchBank))
            {
                bank = new BranchBank(name);
            }
            else
            {
                throw new AggregateException(ExceptionMessages.BankTypeInvalid);
            }
            banks.AddModel((Bank)bank);
            return string.Format(OutputMessages.BankSuccessfullyAdded,bankTypeName);
        }

        public string AddClient(string bankName, string clientTypeName, string clientName, string id, double income)
        {
           
        }

        public string AddLoan(string loanTypeName)
        {
            ILoan loan;
            if (loanTypeName == nameof(MortgageLoan))
            {
                loan = new MortgageLoan();
            }
            else if (loanTypeName == nameof(StudentLoan))
            {
                loan = new StudentLoan();
            }
            else
            {
                throw new AggregateException(ExceptionMessages.LoanTypeInvalid);
            }
            loans.AddModel((Loan)loan);
            return string.Format(OutputMessages.LoanSuccessfullyAdded, loanTypeName);
        }

        public string FinalCalculation(string bankName)
        {
            IBank currentBank = banks.FirstModel(bankName);
            double sum = currentBank.Clients.Sum(c => c.Income) + currentBank.Loans.Sum(l => l.Amount);
            return string.Format(OutputMessages.BankFundsCalculated, bankName, $"{sum:f2}");
        }

        public string ReturnLoan(string bankName, string loanTypeName)
        {
            ILoan currentLoan = loans.FirstModel(loanTypeName);
            if (currentLoan is null)
            {
                return string.Format(ExceptionMessages.MissingLoanFromType, loanTypeName);
            }
            IBank currentBank = banks.FirstModel(bankName);
            currentBank.AddLoan(currentLoan);
            loans.RemoveModel((Loan)currentLoan);
            return string.Format(OutputMessages.LoanReturnedSuccessfully, bankName);
        }

        public string Statistics()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var bank in banks.Models)
            {
                sb.AppendLine(bank.GetStatistics());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
