namespace DYS
{
    partial class frmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.txtCalculetedAmaount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbClassType = new System.Windows.Forms.ComboBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTaksitMiktar = new System.Windows.Forms.ComboBox();
            this.gbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.cmbTaksitMiktar);
            this.gbStudent.Controls.Add(this.label6);
            this.gbStudent.Controls.Add(this.txtCalculetedAmaount);
            this.gbStudent.Controls.Add(this.label9);
            this.gbStudent.Controls.Add(this.cmbClassType);
            this.gbStudent.Controls.Add(this.cmbPaymentType);
            this.gbStudent.Controls.Add(this.label1);
            this.gbStudent.Controls.Add(this.label7);
            this.gbStudent.Controls.Add(this.txtStudentAddress);
            this.gbStudent.Controls.Add(this.txtStudentPhone);
            this.gbStudent.Controls.Add(this.txtStudentSurname);
            this.gbStudent.Controls.Add(this.txtStudentName);
            this.gbStudent.Controls.Add(this.label8);
            this.gbStudent.Controls.Add(this.label4);
            this.gbStudent.Controls.Add(this.label3);
            this.gbStudent.Controls.Add(this.label5);
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Controls.Add(this.txtPayment);
            this.gbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStudent.Location = new System.Drawing.Point(26, 67);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(461, 340);
            this.gbStudent.TabIndex = 4;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "STUDENT";
            // 
            // txtCalculetedAmaount
            // 
            this.txtCalculetedAmaount.Location = new System.Drawing.Point(226, 284);
            this.txtCalculetedAmaount.Name = "txtCalculetedAmaount";
            this.txtCalculetedAmaount.Size = new System.Drawing.Size(135, 22);
            this.txtCalculetedAmaount.TabIndex = 27;
            this.txtCalculetedAmaount.TextChanged += new System.EventHandler(this.txtCalculetedAmaount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Taksit Eklenmis Ucret";
            // 
            // cmbClassType
            // 
            this.cmbClassType.FormattingEnabled = true;
            this.cmbClassType.Location = new System.Drawing.Point(226, 159);
            this.cmbClassType.Name = "cmbClassType";
            this.cmbClassType.Size = new System.Drawing.Size(135, 24);
            this.cmbClassType.TabIndex = 25;
            this.cmbClassType.SelectedIndexChanged += new System.EventHandler(this.cmbClassType_SelectedIndexChanged);
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(226, 217);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(135, 24);
            this.cmbPaymentType.TabIndex = 23;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbInstlamentType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Odeme Tipi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sınıfı";
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(226, 129);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(135, 22);
            this.txtStudentAddress.TabIndex = 16;
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Location = new System.Drawing.Point(226, 94);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(135, 22);
            this.txtStudentPhone.TabIndex = 12;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(226, 59);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(135, 22);
            this.txtStudentSurname.TabIndex = 11;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(226, 27);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(135, 22);
            this.txtStudentName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soy Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Odeme Miktari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(226, 189);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(135, 22);
            this.txtPayment.TabIndex = 13;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(522, 79);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(497, 280);
            this.dgvStudents.TabIndex = 5;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            this.dgvStudents.DoubleClick += new System.EventHandler(this.dgvStudents_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(195, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Guncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 22);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Taksit Miktari";
            // 
            // cmbTaksitMiktar
            // 
            this.cmbTaksitMiktar.FormattingEnabled = true;
            this.cmbTaksitMiktar.Location = new System.Drawing.Point(226, 247);
            this.cmbTaksitMiktar.Name = "cmbTaksitMiktar";
            this.cmbTaksitMiktar.Size = new System.Drawing.Size(135, 24);
            this.cmbTaksitMiktar.TabIndex = 29;
            this.cmbTaksitMiktar.SelectedIndexChanged += new System.EventHandler(this.cmbTaksitMiktar_SelectedIndexChanged);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 448);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.gbStudent);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.ComboBox cmbClassType;
        private System.Windows.Forms.TextBox txtCalculetedAmaount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTaksitMiktar;
        private System.Windows.Forms.Label label6;
    }
}