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

namespace DYS
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            GettAll();
            CalculateTotalAmount();
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            
            dgvPaymentStudents.DataSource = efPaymentDal.GetStudents();
            txtStudentId.ReadOnly = true;
            txtStudentPaymentAmount.ReadOnly = true;
            txtStudentPaymentType.ReadOnly = true;
            txtStudentIns.ReadOnly = true;
        }

        private void dgvPaymentStudents_DoubleClick(object sender, EventArgs e)
        {
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            txtStudentId.Text = dgvPaymentStudents.CurrentRow.Cells[4].Value.ToString();
           txtStudentPaymentAmount.Text = dgvPaymentStudents.CurrentRow.Cells[0].Value.ToString();
            txtStudentPaymentType.Text = dgvPaymentStudents.CurrentRow.Cells[2].Value.ToString();
            txtStudentIns.Text = dgvPaymentStudents.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show("Ödeme Bilgileri Getirildi");
            
        }


        private void dgvPaymentStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            efPaymentDal.Add(new Entities.Concrete.Payment
            {
                
                StudentId = Convert.ToInt32(txtStudentId.Text),
                PaymentAmount = txtStudentPaymentAmount.Text,
                PaymentType = txtStudentPaymentType.Text,
                PaymentInstallment = txtStudentIns.Text,
                PaymentDate = dtpPayment.Text.ToString()
                

        });
            MessageBox.Show("Ödeme Eklendi");
            GettAll();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            efPaymentDal.Delete(new Entities.Concrete.Payment
            {
                PaymentId = Convert.ToInt32(dgvPayment.CurrentRow.Cells[0].Value)
                
        });
            MessageBox.Show("Ödeme Silindi");
            GettAll();

            
        }

        private void GettAll()
        {
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            dgvPayment.DataSource = efPaymentDal.GetAll();

        }

        private void dgvPayment_DoubleClick(object sender, EventArgs e)
        {

           txtStudentId.Text = dgvPayment.CurrentRow.Cells[1].Value.ToString();
            txtStudentPaymentAmount.Text = dgvPayment.CurrentRow.Cells[2].Value.ToString();
            txtStudentPaymentType.Text = dgvPayment.CurrentRow.Cells[4].Value.ToString();
            txtStudentIns.Text = dgvPayment.CurrentRow.Cells[3].Value.ToString();
            dtpPayment.Text = dgvPayment.CurrentRow.Cells[5].Value.ToString();

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }


        private void CalculateTotalAmount()
        {
          int totalAmount = 0; // Toplamı tutacak değişkeni döngü dışında tanımlayın

            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                // Her satırdaki ödeme miktarını toplam değişkenine ekleyin
                if (row.Cells[2].Value != null)
                {
                    totalAmount += Convert.ToInt32(row.Cells[2].Value);
                    
                 }
                txtTotalAmount.Text = totalAmount.ToString();
            }
            
        }
    }
}
