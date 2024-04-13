using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DYS.DataAccess.Abstract;
using DYS.DataAccess.Concrete;
using DYS.Entities.Concrete;

namespace DYS
{
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            EfCourseDal efCourseDal = new EfCourseDal();
            dgvCourses.DataSource = efCourseDal.GetAll();
            dgvTeachersCourse.DataSource = efCourseDal.GetTeachers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EfCourseDal efCourseDal = new EfCourseDal();
            efCourseDal.Add(new Course
            {
                CourseName = txtCourseName.Text,
                CourseTeacher = txtSelectedTeacher.Text

            });
            dgvCourses.DataSource = efCourseDal.GetAll();
            MessageBox.Show("Ders Eklendi");
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EfCourseDal efCourseDal = new EfCourseDal();
            efCourseDal.Update(new Course
            {
                CourseId= Convert.ToInt32(dgvCourses.CurrentRow.Cells[0].Value),
                CourseName= txtCourseName.Text,
                CourseTeacher = txtSelectedTeacher.Text


            });
            dgvCourses.DataSource = efCourseDal.GetAll();
            MessageBox.Show("Ders Güncellendi");
            ClearAll();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            EfCourseDal efCourseDal = new EfCourseDal();
            efCourseDal.Delete(new Course
            {
                CourseId = Convert.ToInt32(dgvCourses.CurrentRow.Cells[0].Value)
            });
            dgvCourses.DataSource = efCourseDal.GetAll();
            MessageBox.Show("Ders Silindi");
            ClearAll();
        } 


        private void dgvCourses_DoubleClick(object sender, EventArgs e)
        {
            txtCourseName.Text = dgvCourses.CurrentRow.Cells[1].Value.ToString();
            txtSelectedTeacher.Text = dgvCourses.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvTeachersCourse_DoubleClick(object sender, EventArgs e)
        {
            string firstName = dgvTeachersCourse.CurrentRow.Cells[2].Value.ToString();
            string lastName = dgvTeachersCourse.CurrentRow.Cells[3].Value.ToString();
            string fullName = $"{firstName} {lastName}";
            txtSelectedTeacher.Text = fullName;
            MessageBox.Show("Öğretmen Seçildi");
           
        }
        private void ClearAll()
        {
            txtCourseName.Text = "";
            txtSelectedTeacher.Text = "";
        }
    }
}
