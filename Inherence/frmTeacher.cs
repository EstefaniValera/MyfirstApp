using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.Inherence
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {

            //intancia de teacher
            Teacher teacher = new Teacher();
            teacher.Name = "Pepe";
            teacher.Surname = "Soto";
            teacher.Subject = "Progrmacion";
            teacher.Salary = 40000.00f;

            MessageBox.Show("El nombre del profesor es:"+teacher.Name + " El salario del professor es:"+teacher.Salary);

            //polimorfismo-polymorphism example with Boxing -poner dentro de la caja
            Person person1 = new Teacher();// la de la izquiers siempre sera la matruska grande; la de la derecha la matrioska pequeña
            person1.Name = "Neus";
            person1.Surname = "Membrado";
            // dentro de persoon tengo un teacher 
            //unboxing : quitar dentro de la caja- uncasting
            ((Teacher)person1).Salary = 50000.00f;
            ((Teacher)person1).Subject = "Mates";
            //se utiliza mucho para crear una de las variable ; testing , abstract factory-cross data base

            MessageBox.Show("El nombre del profesor es:" + person1.Name + " El salario del professor es:" + ((Teacher)person1).Salary);

            //el polymorfismo se ha de usar a diario 
            //associaciones 1:1, 1:n, n:n 
            // en alguno casos, antes de castear - mirar el tipoo
        }
    }
}
