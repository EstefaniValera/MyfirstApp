using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.ForeachLoop
{
    public partial class rmForEach : Form
    {
        public rmForEach()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // descubrir porqwue el nombre me sale difernete
        {
            var student = new Student(); // Student
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentList = new ArrayList(); // DENTRO DEL METODO CON VAR, SIno poner el tipo; lo ideal seria que estuviera definido en ambito de clase
            studentList.Add(student);

            foreach (var _student in studentList)
            {
                //unboxing-polymorphism
                //calcular cuantos estudicantes hay
                MessageBox.Show( ((Student)_student).Name + " "+((Student)_student).Surname);
                // el arralyist utiliza objetos; dentro del objeto estamos poniendo un estudiante-boxing 
                Console.WriteLine("todos los examenes hacerlo ordenada");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
