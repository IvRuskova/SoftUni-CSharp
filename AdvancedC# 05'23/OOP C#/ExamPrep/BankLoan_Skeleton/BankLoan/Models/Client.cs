using BankLoan.Models.Contracts;
using BankLoan.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public abstract class Client : IClient
    {
        private string name;
        private string id;
        private int interest;
        private double income;

        public Client(string name, string id, int interest, double income)
        {
            name = Name;
            id = Id;
            interest = Interest;
            income = Income;
        }
        public string Name 
        { 
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ClientNameNullOrWhitespace);
                }
                name = value; 
            } 
        }

        public string Id 
        { 
            get => id;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ClientIdNullOrWhitespace);
                }
                id = value;
            }

        }

        //protected setter ?
        public int Interest 
        { 
            get => interest; 
            protected set => interest = value; 
        }

        public double Income 
        { 
            get => income; 
            private set
            {
                if (value <=0)
                {
                    throw new ArgumentException(ExceptionMessages.ClientIncomeBelowZero);
                }
                income = value; 
            }
        }
        public abstract void IncreaseInterest();
    }
}
