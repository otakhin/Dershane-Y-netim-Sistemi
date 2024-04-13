using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DYS.DataAccess.Concrete;
using DYS.Entities.Concrete;

namespace DYS
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            EfTeacherDal efTeacherDal = new EfTeacherDal();
            dgvTeachers.DataSource = efTeacherDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EfTeacherDal efTeacherDal = new EfTeacherDal();
            efTeacherDal.Add(new Teacher
            {
                Name = txtTeacherName.Text,
                Surname = txtTeacherSurname.Text,
                Branch = txtBranch.Text,
                Address = txtTeacherAddress.Text,
                Phone = Convert.ToInt64(txtTeacherPhone.Text)

            });
            dgvTeachers.DataSource = efTeacherDal.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EfTeacherDal efTeacherDal = new EfTeacherDal();
            efTeacherDal.Update(new Teacher 
            {
                Id = Convert.ToInt32(dgvTeachers.CurrentRow.Cells[1].Value),
                Name = txtTeacherName.Text,
                Surname = txtTeacherSurname.Text,
                Branch = txtBranch.Text,
                Address = txtTeacherAddress.Text,
                Phone = Convert.ToInt64(txtTeacherPhone.Text)

            });
            dgvTeachers.DataSource = efTeacherDal.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EfTeacherDal efTeacherDal = new EfTeacherDal();
            efTeacherDal.Delete(new Teacher
            {
                Id = Convert.ToInt32(dgvTeachers.CurrentRow.Cells[1].Value),
            });
            dgvTeachers.DataSource = efTeacherDal.GetAll();
        }

        private void dgvTeachers_DoubleClick(object sender, EventArgs e)
        {

            txtTeacherName.Text = dgvTeachers.CurrentRow.Cells[2].Value.ToString();
            txtTeacherSurname.Text = dgvTeachers.CurrentRow.Cells[3].Value.ToString();
            txtBranch.Text = dgvTeachers.CurrentRow.Cells[0].Value.ToString();
            txtTeacherAddress.Text = dgvTeachers.CurrentRow.Cells[5].Value.ToString();
            txtTeacherPhone.Text = dgvTeachers.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
