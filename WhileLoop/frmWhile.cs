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

namespace MyFirstApp.WhileLoop
{
    public partial class frmWhile : Form
    {
        public frmWhile()
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

            var students = new Dictionary<int, Student>();

            students.Add(student.StudentId, student);

            int i = 0;
            while (i < students.Count)
            {
                KeyValuePair<int, Student> entry = students.ElementAt(i);
                if (entry.Value.Name.Equals("Pepe"))
                {
                    Console.WriteLine("Pepe is found"+" : "+entry.Value.Name);
                }
                i++;
            }

            var dicguid = new Dictionary<string, string>();
            Guid g = Guid.NewGuid();
            dicguid.Add(g.ToString(), "jj");
            //el tema de la dll , se ha de ser muy purista 
            int j = 0;
            while (j < dicguid.Count)
            {
                KeyValuePair<string, string> entry = dicguid.ElementAt(j);
                Console.WriteLine("conguid"+entry.Key + " : " + entry.Value);

                j++;
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
