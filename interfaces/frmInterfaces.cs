using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.Interfaces
{
    public partial class frmInterfaces : Form
    {
        public frmInterfaces()
        {
            InitializeComponent();
        }

        private void frmInterfaces_Load(object sender, EventArgs e)
        {
            // interface Polimorphism
            IVehiculo vehiculo = new Avion();
            // una clase implementa una interfaz, y la variable  es del tipo de la interfaz
            vehiculo.Acelerar(1000);
            // no podria acceder al metodo clone - 
            ICloneable clonable = new Avion(); // ojo! SOLO PUEDO ACCEDER A LOS METODOS DE LA INTRFAZ
            clonable.Clone(); 

            //dividir las clases en multiples interfaces y ir abstrayendo las clases; QUE NUESTROS METODOS DEVOLVIERAN INTERFACES
            // ESTO LO VAMOS A USAR PARA EL TESTEO UNITARIO- PRIMERO SE DEFINEN LAS INTERFACES PARA EMULAR EL CODIGO QUE SE TIENE  QUE IMPEMNTAR-








        }
    }
}
