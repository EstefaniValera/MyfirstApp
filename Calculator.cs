using System; // salen en gris porque no los estas usando ; importa todas las clases que tienes en ese paquete
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //ojo si lo subes s git, no subir codigo de mas

// namespace = paquetes donde voy a contener las clase
// en -net no puedo importar una clase - puedo importa namespace

namespace MyFirstApp
{
    public class Calculator // poner publica
    {
    // por defecto  c# no hace las clases publicas
    //camel casing; la nomenclatura, es un formato que utilizas ; uSAR LA NOMENCLATURA CORRECTA camel casing-pascal casing
    public int Add(int num1, int num2) // calidad de codigo, te lo valida el sonarqube si cumple la nomenclatura del lenguaje
        {
            return num1 + num2;
        }

    public int Substract(int num1, int num2) // calidad de codigo, te lo valida el sonarqube si cumple la nomenclatura del lenguaje
        {
            return num1 - num2;
        }

    public int Multiply(int num1, int num2) // calidad de codigo, te lo valida el sonarqube si cumple la nomenclatura del lenguaje
        {
            return num1 * num2;
        }

    public int Divide(int num1, int num2) // calidad de codigo, te lo valida el sonarqube si cumple la nomenclatura del lenguaje
        {
            return num1 / num2;
        }
    }
}
