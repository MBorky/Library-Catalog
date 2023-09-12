using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int UserId { get; private set; }
        public User (string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            UserId = id;
        }
    }
}
