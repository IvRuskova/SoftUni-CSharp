using BankLoan.Models.Contracts;
using BankLoan.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public abstract class Bank : IBank
    {
        //field
        private string name;
        private int capacity;
        private List<ILoan> loans = new List<ILoan>();
        private List<IClient> clients = new List<IClient>();
        
        //ctor
        public Bank(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        //prop
        public string Name
        {
            get => Name; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BankNameNullOrWhiteSpace);
                }
                Name = value;            
            }
        }

        public int Capacity 
        { 
            get => capacity; 
            private set => capacity = value; 
        }

        public IReadOnlyCollection<ILoan> Loans => loans.AsReadOnly();

        public IReadOnlyCollection<IClient> Clients => clients.AsReadOnly();
        
        //methods
        public void AddClient(IClient Client)
        {
            if (clients.Count == Capacity)
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughCapacity);
            }
            clients.Add(Client);
        }

        public void AddLoan(ILoan loan)
        {
             loans.Add(loan);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}, Type: {this.GetType().Name}");
            string AddedClients = clients.Any() ? $"{string.Join(",", clients.GetType().Name)}" : "none";
            sb.AppendLine($"{AddedClients}: ");
            sb.AppendLine($"Loans: {loans.Count}, Sum of Rates: {Loans.Sum(l => l.InterestRate)}");


            sb.AppendLine($"");
            return sb.ToString().TrimEnd();
        }

        public void RemoveClient(IClient Client)
        {
            clients.Remove(Client);
        }

        public double SumRates()
        {
            return Loans.Sum(l=>l.InterestRate);
        }
    }
}
