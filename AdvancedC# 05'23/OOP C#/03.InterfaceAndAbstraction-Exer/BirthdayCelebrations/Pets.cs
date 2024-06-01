using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Pets : INameable, IBirthable
    {
        public Pets(string name, string birthDate) 
        {
            Name = name;
            Birthdate = birthDate;
        }
        public string Name { get; private set; }
        public string Birthdate { get; private set; }
    }
}
