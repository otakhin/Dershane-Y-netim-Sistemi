using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DYS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            frmStudent frmStudent = new frmStudent();
            frmStudent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacher frmTeacher = new frmTeacher();
            frmTeacher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCourse frmCourse = new frmCourse();
            frmCourse.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment();
            frmPayment.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
