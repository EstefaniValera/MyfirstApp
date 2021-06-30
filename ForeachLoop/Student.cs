﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ForeachLoop
{
    public class Student
    {
        // crear las propertities
        public int StudentId { get; set; }  // priemera letra en mayusculas
        //prop tab tab
        //StudentId genera una variable privada por debajo
        //{ get; set; } : leee y escribe la variable privada
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }

        public Student()
        {
        }

        public Student(int studentId, string name, string surname, int age)
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age;
        }

        public override int GetHashCode()
        {
            int hashCode = -1235398547;
            hashCode = hashCode * -1521134295 + StudentId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }
    }
}
