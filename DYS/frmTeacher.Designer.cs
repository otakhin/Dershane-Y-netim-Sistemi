namespace DYS
{
    partial class frmTeacher
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
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacherAddress = new System.Windows.Forms.TextBox();
            this.txtTeacherPhone = new System.Windows.Forms.TextBox();
            this.txtTeacherSurname = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.txtBranch);
            this.gbStudent.Controls.Add(this.label1);
            this.gbStudent.Controls.Add(this.txtTeacherAddress);
            this.gbStudent.Controls.Add(this.txtTeacherPhone);
            this.gbStudent.Controls.Add(this.txtTeacherSurname);
            this.gbStudent.Controls.Add(this.txtTeacherName);
            this.gbStudent.Controls.Add(this.label8);
            this.gbStudent.Controls.Add(this.label4);
            this.gbStudent.Controls.Add(this.label3);
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStudent.Location = new System.Drawing.Point(58, 54);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(285, 307);
            this.gbStudent.TabIndex = 13;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "TEACHER";
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(126, 216);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(100, 22);
            this.txtBranch.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Branş";
            // 
            // txtTeacherAddress
            // 
            this.txtTeacherAddress.Location = new System.Drawing.Point(126, 177);
            this.txtTeacherAddress.Name = "txtTeacherAddress";
            this.txtTeacherAddress.Size = new System.Drawing.Size(100, 22);
            this.txtTeacherAddress.TabIndex = 16;
            // 
            // txtTeacherPhone
            // 
            this.txtTeacherPhone.Location = new System.Drawing.Point(126, 141);
            this.txtTeacherPhone.Name = "txtTeacherPhone";
            this.txtTeacherPhone.Size = new System.Drawing.Size(100, 22);
            this.txtTeacherPhone.TabIndex = 12;
            // 
            // txtTeacherSurname
            // 
            this.txtTeacherSurname.Location = new System.Drawing.Point(126, 99);
            this.txtTeacherSurname.Name = "txtTeacherSurname";
            this.txtTeacherSurname.Size = new System.Drawing.Size(100, 22);
            this.txtTeacherSurname.TabIndex = 11;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(126, 66);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(100, 22);
            this.txtTeacherName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soy ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(374, 90);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.Size = new System.Drawing.Size(396, 228);
            this.dgvTeachers.TabIndex = 14;
            this.dgvTeachers.DoubleClick += new System.EventHandler(this.dgvTeachers_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(268, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(168, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(62, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.gbStudent);
            this.Name = "frmTeacher";
            this.Text = "frmTeacher";
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeacherAddress;
        private System.Windows.Forms.TextBox txtTeacherPhone;
        private System.Windows.Forms.TextBox txtTeacherSurname;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}