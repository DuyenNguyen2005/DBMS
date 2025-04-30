namespace Project_DBMS
{
    partial class AddEmployeeUC
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
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpDOB = new System.Windows.Forms.Label();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblEmpGender = new System.Windows.Forms.Label();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.lblEmpPhone = new System.Windows.Forms.Label();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.lblEmpPosition = new System.Windows.Forms.Label();
            this.cboEmpPosition = new System.Windows.Forms.ComboBox();
            this.lblEmpHireDate = new System.Windows.Forms.Label();
            this.dtpEmpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(51, 98);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(51, 20);
            this.lblEmpName.TabIndex = 2;
            this.lblEmpName.Text = "Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(171, 95);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(300, 26);
            this.txtEmpName.TabIndex = 3;
            // 
            // lblEmpDOB
            // 
            this.lblEmpDOB.AutoSize = true;
            this.lblEmpDOB.Location = new System.Drawing.Point(51, 138);
            this.lblEmpDOB.Name = "lblEmpDOB";
            this.lblEmpDOB.Size = new System.Drawing.Size(99, 20);
            this.lblEmpDOB.TabIndex = 4;
            this.lblEmpDOB.Text = "Date of Birth";
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.Location = new System.Drawing.Point(171, 135);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(300, 26);
            this.dtpEmpDOB.TabIndex = 5;
            // 
            // lblEmpGender
            // 
            this.lblEmpGender.AutoSize = true;
            this.lblEmpGender.Location = new System.Drawing.Point(51, 178);
            this.lblEmpGender.Name = "lblEmpGender";
            this.lblEmpGender.Size = new System.Drawing.Size(63, 20);
            this.lblEmpGender.TabIndex = 6;
            this.lblEmpGender.Text = "Gender";
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Location = new System.Drawing.Point(51, 218);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(68, 20);
            this.lblEmpAddress.TabIndex = 8;
            this.lblEmpAddress.Text = "Address";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(171, 215);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(300, 26);
            this.txtEmpAddress.TabIndex = 9;
            // 
            // lblEmpPhone
            // 
            this.lblEmpPhone.AutoSize = true;
            this.lblEmpPhone.Location = new System.Drawing.Point(51, 258);
            this.lblEmpPhone.Name = "lblEmpPhone";
            this.lblEmpPhone.Size = new System.Drawing.Size(55, 20);
            this.lblEmpPhone.TabIndex = 10;
            this.lblEmpPhone.Text = "Phone";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(171, 255);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(300, 26);
            this.txtEmpPhone.TabIndex = 11;
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Location = new System.Drawing.Point(51, 298);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmpEmail.TabIndex = 12;
            this.lblEmpEmail.Text = "Email";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(171, 295);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(300, 26);
            this.txtEmpEmail.TabIndex = 13;
            // 
            // lblEmpPosition
            // 
            this.lblEmpPosition.AutoSize = true;
            this.lblEmpPosition.Location = new System.Drawing.Point(51, 338);
            this.lblEmpPosition.Name = "lblEmpPosition";
            this.lblEmpPosition.Size = new System.Drawing.Size(65, 20);
            this.lblEmpPosition.TabIndex = 14;
            this.lblEmpPosition.Text = "Position";
            // 
            // cboEmpPosition
            // 
            this.cboEmpPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpPosition.Items.AddRange(new object[] {
            "Storekeeper",
            "Staff",
            "Manager",
            "Administrator"});
            this.cboEmpPosition.Location = new System.Drawing.Point(171, 335);
            this.cboEmpPosition.Name = "cboEmpPosition";
            this.cboEmpPosition.Size = new System.Drawing.Size(300, 28);
            this.cboEmpPosition.TabIndex = 15;
            this.cboEmpPosition.SelectedIndexChanged += new System.EventHandler(this.cboEmpPosition_SelectedIndexChanged);
            // 
            // lblEmpHireDate
            // 
            this.lblEmpHireDate.AutoSize = true;
            this.lblEmpHireDate.Location = new System.Drawing.Point(51, 378);
            this.lblEmpHireDate.Name = "lblEmpHireDate";
            this.lblEmpHireDate.Size = new System.Drawing.Size(77, 20);
            this.lblEmpHireDate.TabIndex = 16;
            this.lblEmpHireDate.Text = "Hire Date";
            // 
            // dtpEmpHireDate
            // 
            this.dtpEmpHireDate.Location = new System.Drawing.Point(171, 378);
            this.dtpEmpHireDate.Name = "dtpEmpHireDate";
            this.dtpEmpHireDate.Size = new System.Drawing.Size(300, 26);
            this.dtpEmpHireDate.TabIndex = 17;
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.AutoSize = true;
            this.lblEmpSalary.Location = new System.Drawing.Point(51, 427);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(53, 20);
            this.lblEmpSalary.TabIndex = 20;
            this.lblEmpSalary.Text = "Salary";
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(171, 424);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(300, 26);
            this.txtEmpSalary.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 50);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(96, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(361, 44);
            this.lbTitle.TabIndex = 31;
            this.lbTitle.Text = "Employee Management";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(171, 178);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(68, 24);
            this.rdMale.TabIndex = 32;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(345, 178);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(87, 24);
            this.rdFemale.TabIndex = 33;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeUC
            // 
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpDOB);
            this.Controls.Add(this.dtpEmpDOB);
            this.Controls.Add(this.lblEmpGender);
            this.Controls.Add(this.lblEmpAddress);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.lblEmpPhone);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.lblEmpEmail);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.lblEmpPosition);
            this.Controls.Add(this.cboEmpPosition);
            this.Controls.Add(this.lblEmpHireDate);
            this.Controls.Add(this.dtpEmpHireDate);
            this.Controls.Add(this.lblEmpSalary);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.btnSave);
            this.Name = "AddEmployeeUC";
            this.Size = new System.Drawing.Size(551, 585);
            this.Load += new System.EventHandler(this.AddEmployeeUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpDOB;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.Label lblEmpGender;
        private System.Windows.Forms.Label lblEmpAddress;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.Label lblEmpPhone;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Label lblEmpPosition;
        private System.Windows.Forms.ComboBox cboEmpPosition;
        private System.Windows.Forms.Label lblEmpHireDate;
        private System.Windows.Forms.DateTimePicker dtpEmpHireDate;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
    }
}
