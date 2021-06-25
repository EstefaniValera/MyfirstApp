using System;
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

    }
}
