using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Inherence
{
    public class Person
    {
        // guid, name, surname
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Guid = Guid.NewGuid();
        }
        public Person( string name, string surname) : this() // en jaca es super 
        {
            
            Name = name;
            Surname = surname;
        }


        public Person(Guid guid, string name, string surname): this() // en jaca es super 
        {
            Guid = guid;
            Name = name;
            Surname = surname;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Guid.Equals(person.Guid) &&
                   Name == person.Name &&
                   Surname == person.Surname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Guid, Name, Surname);
        }


        // dos contructores , vacio y con parametos, eualas , gethascode


    }
}
