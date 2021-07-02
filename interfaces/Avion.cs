using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Interfaces
{
    public class Avion : IVehiculo, ICloneable   
        // la bombillita implementr interfaz, las interfaces son plantillas , estructuras con los metodos tengo que utilizar
        // , para marcar lo que se tien que programa y para el polymorfism de interfces- que emulo la herencia multiple
    {
        //A partir de ahora la mayoria de nuestro metodos publicos, deberias  de estar implementado en interfaces
        //Interface Segregation Principle
        public void Acelerar(int kmh)
        {
            Console.WriteLine("Acelerando vehiculo");
        }

        public void Aterrizar()
        {
            throw new NotImplementedException();
        }

        public object Clone() //IClonable
        {
            throw new NotImplementedException();
        }

        public void Despegar()
        {
            throw new NotImplementedException();
        }

        public void Frenan()
        {
            throw new NotImplementedException();
        }

        public void Girar(int angulos)
        {
            throw new NotImplementedException();
        }
    }
}
