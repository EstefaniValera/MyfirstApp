using MyFirstApp.ForeachLoop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.frmforLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student(); // Student
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            //genric collections 
            List<Student> studentList = new List<Student>();
            // estoy guardando solo estdudiantes- solo puedo guardar un tipo especifico
            studentList.Add(student);

            for (int i = 0; i < studentList.Count; i++)
            {
               
                MessageBox.Show(studentList [i].Name + " " + studentList[i].Surname);
                
                Console.WriteLine("todos los examenes hacerlo  de forma ordenada");
            }
            
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
