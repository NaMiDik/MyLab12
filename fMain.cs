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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvStudents.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Surname";
            column.Name = "Прізвище";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "University";
            column.Name = "Факультет";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Вік";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Semester";
            column.Name = "Семестер";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Scholarship";
            column.Name = "Стипендія";
            column.Width = 100;
            gvStudents.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasHostel";
            column.Name = "Гуртожитoк";
            column.Width = 80;
            gvStudents.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasScholarship";
            column.Name = "Стипендія";
            column.Width = 80;
            gvStudents.Columns.Add(column);

            bindSrcStudents.Add(new Student("Дмитро", "Трухін", "ФІІТА", 18, 2, 0, true, false));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            fStudent fs = new fStudent(student);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcStudents.Add(student);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student student = (Student)bindSrcStudents.List[bindSrcStudents.Position];

            fStudent fs = new fStudent(student);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcStudents.List[bindSrcStudents.Position] = student;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcStudents.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі данні будуть втрачені", "Очищеня данних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcStudents.Clear();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
