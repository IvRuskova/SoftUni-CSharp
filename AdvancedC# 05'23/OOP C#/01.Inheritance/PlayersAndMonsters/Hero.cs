using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public abstract class Hero
    {
        public Hero(string username, int lavel)
        {
            Username = username;
            Level = lavel;
        }
        public string Username { get; set; }
        public int Level { get; set; }
        public override string ToString()
        {
            return $"Type: {GetType().Name} Username:{Username} Level: {Level}"; 
        }
    }
}
