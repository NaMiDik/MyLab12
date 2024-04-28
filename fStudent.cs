using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLab12
{
    public partial class fStudent : Form
    {
        public Student TheStudent;
        public fStudent(Student s)
        {
            TheStudent = s;
        InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheStudent.Name = tbName.Text.Trim();
            TheStudent.Surname = tbSurname.Text.Trim();
            TheStudent.University = tbUniversity.Text.Trim();
            TheStudent.Age = int.Parse(tbAge.Text.Trim());
            TheStudent.Semester = double.Parse(tbSemester.Text.Trim());
            TheStudent.Scholarship = double.Parse(tbScholarship.Text.Trim());
            TheStudent.HasHostel = chbHasHostel.Checked;
            TheStudent.HasScholarship = chbHasScholarship.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fStudent_Load(object sender, EventArgs e)
        {
            if (TheStudent != null)
            {
                tbName.Text = TheStudent.Name;
                tbSurname.Text = TheStudent.Surname;
                tbUniversity.Text = TheStudent.University;
                tbAge.Text = TheStudent.Age.ToString();
                tbSemester.Text = TheStudent.Semester.ToString("0.00");
                tbScholarship.Text = TheStudent.Scholarship.ToString("0.000");
                chbHasHostel.Checked = TheStudent.HasHostel;
                chbHasScholarship.Checked = TheStudent.HasScholarship;
            }
        }
    }
}
