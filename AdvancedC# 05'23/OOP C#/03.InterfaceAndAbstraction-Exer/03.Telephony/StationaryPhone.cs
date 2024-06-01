using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : IPhone
    {
        public void Call(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsLetter(number[i]))
                {
                    throw new ArgumentException("Invalid number!");
                }
            }
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
