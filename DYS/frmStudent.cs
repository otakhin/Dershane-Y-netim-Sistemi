using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DYS.DataAccess.Abstract;
using DYS.DataAccess.Concrete;
using DYS.Entities.Concrete;

namespace DYS
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
            Database.SetInitializer<DYS_NewContext>(null);
        }



        private void frmStudent_Load(object sender, EventArgs e)
        {
            GettAll();
            ClassType();
            Paymenttype();
            Taksitmiktari();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string paymentAmountText = "";
            if (cmbPaymentType.Text == "Nakit")
            {
                if (int.TryParse(txtPayment.Text, out int payment))
                {
                    paymentAmountText = payment.ToString();
                }
            }
            else if (cmbPaymentType.Text == "Taksit")
            {
                if (int.TryParse(txtCalculetedAmaount.Text, out int payment))
                {
                    paymentAmountText = payment.ToString();
                }
            }
            EfStudentDal efStudentDal = new EfStudentDal();
            efStudentDal.Add(new Student
            {
                Name = txtStudentName.Text,
                Surname = txtStudentSurname.Text,
                Phone = Convert.ToInt64(txtStudentPhone.Text),
                Address = txtStudentAddress.Text,
                PaymentAmount = paymentAmountText,
                PaymentInstallment = cmbTaksitMiktar.Text,
                PaymentType = cmbPaymentType.Text,
                ClassType = cmbClassType.Text

            });
            GettAll();
            MessageBox.Show("Ogrenci Eklendi");
            ClearAll();




        }

        private void Taksitmiktari()
        {
            EfStudentDal efStudentDal = new EfStudentDal();
            List<int> taksitMiktari = efStudentDal.TaksitMiktari();
            foreach (var item in taksitMiktari)
            {
                cmbTaksitMiktar.Items.Add(item);
            }
        }
        private void Paymenttype()
        {
            EfStudentDal efStudentDal = new EfStudentDal();
            List<string> paymentType = efStudentDal.PaymentType();
            foreach (var item in paymentType)
            {
                cmbPaymentType.Items.Add(item);
            }

        }


        private void GettAll()
        {
            EfStudentDal efStudentDal = new EfStudentDal();
            dgvStudents.DataSource = efStudentDal.GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            EfStudentDal efStudentDal = new EfStudentDal();
            efStudentDal.Delete(new Student
            {
                Id = Convert.ToInt32(dgvStudents.CurrentRow.Cells[4].Value)
            });

            MessageBox.Show("Ogrenci Silindi");
            GettAll();
            ClearAll();


        }

        private void dgvStudents_DoubleClick(object sender, EventArgs e)
        {
            txtStudentName.Text = dgvStudents.CurrentRow.Cells[5].Value.ToString();
            txtStudentSurname.Text = dgvStudents.CurrentRow.Cells[6].Value.ToString();
            txtStudentPhone.Text = dgvStudents.CurrentRow.Cells[7].Value.ToString();
            txtStudentAddress.Text = dgvStudents.CurrentRow.Cells[8].Value.ToString();
            txtPayment.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
             cmbPaymentType.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
            cmbClassType.Text = dgvStudents.CurrentRow.Cells[3].Value.ToString();



        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbInstlamentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           if (cmbPaymentType.Text == "Taksit")
            {
               
                
                cmbTaksitMiktar.Visible = true;
                txtCalculetedAmaount.Visible = true;
                
               
               
            }
            else
            {
                cmbTaksitMiktar.Visible = false;
                txtCalculetedAmaount.Visible = false;
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EfStudentDal efStudentDal = new EfStudentDal();
            efStudentDal.Update(new Student
            {
                Id = Convert.ToInt32(dgvStudents.CurrentRow.Cells[4].Value),
                Name = txtStudentName.Text,
                Surname = txtStudentSurname.Text,
                Phone = Convert.ToInt64(txtStudentPhone.Text),
                Address = txtStudentAddress.Text,
                PaymentAmount = txtCalculetedAmaount.Text,
                
                PaymentInstallment = cmbTaksitMiktar.Text,

               
                PaymentType = cmbPaymentType.Text,
                ClassType =  cmbClassType.Text
            });
            GettAll();
            MessageBox.Show("Ogrenci Guncellendi");
            ClearAll();
        }



        private void txtPayment_TextChanged(object sender, EventArgs e)
        {

           ClassTypeAmount();

            
           
        }

       
        

        private void cmbClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfStudentDal efStudentDal = new EfStudentDal();

            efStudentDal.ClassType();




        }

        private void ClassType()
        {
            EfStudentDal efStudentDal = new EfStudentDal();
            List<int> classType = efStudentDal.ClassType();
            foreach (var item in classType)
            {
                cmbClassType.Items.Add(item);
            }
        }


        private void ClassTypeAmount()
        {
            

            int  payment8= 10000;
            int payment9 = 12000;
            int payment10 = 15000;
            int payment11 = 18000;
            int payment12 = 20000;


           if (cmbClassType.Text == "8")
            {
                
               txtPayment.Text = payment8.ToString();
            }
            else if (cmbClassType.Text == "9")
            {
                txtPayment.Text = payment9.ToString();
            }
            else if (cmbClassType.Text == "10")
            {
               txtPayment.Text = payment10.ToString();
            }
            else if (cmbClassType.Text == "11")
            {
               txtPayment.Text = payment11.ToString();
            }
            else if (cmbClassType.Text == "12")
            {
                txtPayment.Text = payment12.ToString();
            }

          
        }

        private void cmbTaksitMiktar_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
           taksitHesapla();
            
            

        }
        
        private void taksitHesapla()
        {
            double faiz1 = 1.2;
            double faiz2 = 1.5;

            
            if (cmbTaksitMiktar.Text == "6")
            {
                txtCalculetedAmaount.Text = $"{Convert.ToInt32(txtPayment.Text) * faiz1}";

            }
            else if (cmbTaksitMiktar.Text == "12")
            {
                txtCalculetedAmaount.Text = $"{Convert.ToInt32(txtPayment.Text) * faiz2}";

            }
        }

        private void txtCalculetedAmaount_TextChanged(object sender, EventArgs e)
        {
            txtCalculetedAmaount.ReadOnly = true;
            
        }

        public void ClearAll()
        {
            txtStudentName.Text = "";
            txtStudentSurname.Text = "";
            txtStudentPhone.Text = "";
            txtStudentAddress.Text = "";
            txtPayment.Text = "";
            txtCalculetedAmaount.Text = "";
            cmbPaymentType.Text = "";
            cmbClassType.Text = "";
            cmbTaksitMiktar.Text = "";
            
        }
    }
    

}
