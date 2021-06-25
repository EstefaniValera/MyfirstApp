using MyFirstApp.ForeachLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread] //que solo permite que este metodo sea ejecutado por un solo thread; decorador, costum atribute
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new rmForEach()); // un form es una clase , hacer el using ; arrancar la apilcacion con este nuevo formuario

        }
    }
}
