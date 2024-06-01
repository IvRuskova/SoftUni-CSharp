using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03.MonthlyReport
{
    internal class Program
    {
        static string FormatCurrency(double money)
        {   // formatting the money into 00.00 format
            // use culture info invariant because of potential differences in how the , is used
            return money.ToString("C", CultureInfo.InvariantCulture).Substring(1).Replace(",", "");
        }
        static void Main(string[] args)
        {
            IDictionary<string, double> distributorRecord = new Dictionary<string, double>();
            IDictionary<string, double> customerRecord = new Dictionary<string, double>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArguments = command.Split();
                string commandName = commandArguments[0];
                switch (commandName)
                {
                    case "Deliver":
                        if (commandArguments.Length >= 3)
                        {
                            string distributor = commandArguments[1];
                            if (double.TryParse(commandArguments[2], out double moneySpent))
                            {
                                if (!double.IsNaN(moneySpent))
                                {
                                    if (!distributorRecord.ContainsKey(distributor))
                                    {
                                        // if the record doesn't already contain our distributor, add them to the record
                                        distributorRecord[distributor] = 0;
                                    }
                                    // Keep track of the money spent
                                    distributorRecord[distributor] += moneySpent;
                                }
                            }
                        }
                        break;
                    case "Return":
                        if (commandArguments.Length >= 3)
                        {
                            string distributor = commandArguments[1];
                            if (double.TryParse(commandArguments[2], out double moneyReturned))
                            {
                                if (!double.IsNaN(moneyReturned))
                                {
                                    if (distributorRecord.ContainsKey(distributor))
                                    {
                                        // if the record doesn't already on record, ignore the command
                                        if (distributorRecord[distributor] >= moneyReturned)
                                        {
                                            // Decrease the money of the given distributor with the given amount
                                            distributorRecord[distributor] -= moneyReturned;
                                        }
                                        if (distributorRecord[distributor] == 0)
                                        {
                                            // if the cost of the ingredients becomes 0, you should remove the distributor
                                            distributorRecord.Remove(distributor);
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case "Sell":
                        if (commandArguments.Length >= 3)
                        {
                            string client = commandArguments[1];
                            if (double.TryParse(commandArguments[2], out double moneyEarned))
                            {
                                if (!double.IsNaN(moneyEarned))
                                {
                                    if (!customerRecord.ContainsKey(client))
                                    {
                                        // if the record doesn't already contain our client, add them to the record
                                        customerRecord[client] = 0;
                                    }
                                    // Keep track of the money earned
                                    customerRecord[client] += moneyEarned;
                                }
                            }
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            double income = 0;
            foreach (KeyValuePair<string, double> customer in customerRecord)
            {
                string name = customer.Key;
                // formatting the money into 00.00 format
                // use culture info invariant because of potential differences in how the , is used
                string moneyEarned = FormatCurrency(customer.Value);
                income += customer.Value;
                Console.WriteLine($"{name}: {moneyEarned}");
                //Console.WriteLine("-----------");
            }
            Console.WriteLine("-----------");
            foreach (KeyValuePair<string, double> distributor in distributorRecord)
            {
                string name = distributor.Key;
                // formatting the money into 00.00 format
                // use culture info invariant because of potential differences in how the , is used
                string moneySpent = FormatCurrency(distributor.Value);
                Console.WriteLine($"{name}: {moneySpent}");
                Console.WriteLine("-----------");
            }

            string incomeString = FormatCurrency(income);
            Console.WriteLine($"Total Income: {incomeString}");
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, int> clients = new Dictionary<string, int>();
//            Dictionary<string, int> distributors = new Dictionary<string, int>();
//            int totalIncome = 0;

//            while (true)
//            {
//                string input = Console.ReadLine();
//                if (input == "End")
//                {
//                    break;
//                }

//                string[] command = input.Split(' ');

//                if (command[0] == "Deliver")
//                {
//                    string distributorName = command[1];
//                    int moneySpent = int.Parse(command[2]);

//                    if (!distributors.ContainsKey(distributorName))
//                    {
//                        distributors.Add(distributorName, 0);
//                    }

//                    distributors[distributorName] += moneySpent;
//                }
//                else if (command[0] == "Return")
//                {
//                    string distributorName = command[1];
//                    int moneyReturned = int.Parse(command[2]);

//                    if (!distributors.ContainsKey(distributorName))
//                    {
//                        distributors.Add(distributorName, 0);
//                    }

//                    distributors[distributorName] -= moneyReturned;
//                }
//                else if (command[0] == "Sell")
//                {
//                    string clientName = command[1];
//                    int moneyEarned = int.Parse(command[2]);

//                    if (!clients.ContainsKey(clientName))
//                    {
//                        clients.Add(clientName, 0);
//                    }

//                    clients[clientName] += moneyEarned;
//                    totalIncome += moneyEarned;
//                }
//            }

//            foreach (var kvp in clients.OrderBy(x => x.Key))
//            {
//                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//            }

//            Console.WriteLine("-----------");

//            foreach (var kvp in distributors.OrderBy(x => x.Key))
//            {
//                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//            }

//            Console.WriteLine("-----------");

//            Console.WriteLine($"Total Income: {totalIncome}");
//        }
//    }
//}
