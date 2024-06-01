using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Citizens :  IIdentifalable, INameable, IBirthable
    {
        public Citizens(string id, string name, int age, string birthDate)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthdate = birthDate;
        }
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Birthdate { get; private set; }
    }
}
