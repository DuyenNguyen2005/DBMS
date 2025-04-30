namespace Project_DBMS.Employee
{
    partial class DisplayUC
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

        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DataGridView dgvResult;

        private void InitializeComponent()
        {
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.lblEmpDOB = new System.Windows.Forms.Label();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpID
            // 
            this.lblEmpID.Location = new System.Drawing.Point(20, 20);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(100, 23);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblEmpName
            // 
            this.lblEmpName.Location = new System.Drawing.Point(20, 60);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(100, 23);
            this.lblEmpName.TabIndex = 2;
            this.lblEmpName.Text = "Name:";
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(20, 100);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 23);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(20, 140);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(20, 180);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(400, 20);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(100, 23);
            this.lblPosition.TabIndex = 12;
            this.lblPosition.Text = "Position:";
            // 
            // lblHireDate
            // 
            this.lblHireDate.Location = new System.Drawing.Point(400, 60);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(100, 23);
            this.lblHireDate.TabIndex = 14;
            this.lblHireDate.Text = "Hire Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(400, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Active Status:";
            // 
            // lblSalary
            // 
            this.lblSalary.Location = new System.Drawing.Point(400, 140);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(100, 23);
            this.lblSalary.TabIndex = 18;
            this.lblSalary.Text = "Salary:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(120, 20);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(200, 26);
            this.txtEmpID.TabIndex = 1;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(120, 60);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(200, 26);
            this.txtEmpName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 140);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 26);
            this.txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 180);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // cboPosition
            // 
            this.cboPosition.Items.AddRange(new object[] {
            "Storekeeper",
            "Staff",
            "Manager",
            "Administrator"});
            this.cboPosition.Location = new System.Drawing.Point(500, 20);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(200, 28);
            this.cboPosition.TabIndex = 13;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Checked = false;
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(500, 60);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 26);
            this.dtpHireDate.TabIndex = 15;
            // 
            // chkStatus
            // 
            this.chkStatus.Location = new System.Drawing.Point(500, 100);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(104, 24);
            this.chkStatus.TabIndex = 17;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(500, 140);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 26);
            this.txtSalary.TabIndex = 19;
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ColumnHeadersHeight = 34;
            this.dgvResult.Location = new System.Drawing.Point(24, 271);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 62;
            this.dgvResult.Size = new System.Drawing.Size(1121, 376);
            this.dgvResult.TabIndex = 22;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(233, 100);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(87, 24);
            this.rdFemale.TabIndex = 35;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(123, 100);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(68, 24);
            this.rdMale.TabIndex = 34;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // lblEmpDOB
            // 
            this.lblEmpDOB.AutoSize = true;
            this.lblEmpDOB.Location = new System.Drawing.Point(357, 183);
            this.lblEmpDOB.Name = "lblEmpDOB";
            this.lblEmpDOB.Size = new System.Drawing.Size(99, 20);
            this.lblEmpDOB.TabIndex = 36;
            this.lblEmpDOB.Text = "Date of Birth";
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.Checked = false;
            this.dtpEmpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmpDOB.Location = new System.Drawing.Point(500, 183);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(200, 26);
            this.dtpEmpDOB.TabIndex = 37;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(758, 183);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 50);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(758, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 50);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(476, 230);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 26);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(354, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(758, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 50);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DisplayUC
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEmpDOB);
            this.Controls.Add(this.dtpEmpDOB);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.dgvResult);
            this.Name = "DisplayUC";
            this.Size = new System.Drawing.Size(1161, 700);
            this.Load += new System.EventHandler(this.DisplayAndSearchUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label lblEmpDOB;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}
