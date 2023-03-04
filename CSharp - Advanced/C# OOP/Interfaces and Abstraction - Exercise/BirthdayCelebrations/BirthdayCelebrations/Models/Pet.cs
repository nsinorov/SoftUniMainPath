using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BirthdayCelebrations.Models
{
    public class Pet : INameable, IBirthable
    {
        public Pet(string name, string birthDate)
        {
            Name = name;
            Birthdate = birthDate;
        }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
