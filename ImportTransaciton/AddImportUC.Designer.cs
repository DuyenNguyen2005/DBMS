namespace Project_DBMS.ImportTransaciton
{
    partial class AddImportUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImp_ID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSup_ID = new System.Windows.Forms.TextBox();
            this.txtEmp_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(552, 169);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 48);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 67);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã Giao Dịch";
            // 
            // txtImp_ID
            // 
            this.txtImp_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImp_ID.Location = new System.Drawing.Point(294, 107);
            this.txtImp_ID.Name = "txtImp_ID";
            this.txtImp_ID.Size = new System.Drawing.Size(231, 43);
            this.txtImp_ID.TabIndex = 35;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(38, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(261, 67);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Mã Nhà Cung Cấp";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(38, 255);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(241, 53);
            this.lblPhone.TabIndex = 31;
            this.lblPhone.Text = "Mã Nhân Viên:";
            // 
            // txtSup_ID
            // 
            this.txtSup_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSup_ID.Location = new System.Drawing.Point(294, 174);
            this.txtSup_ID.Name = "txtSup_ID";
            this.txtSup_ID.Size = new System.Drawing.Size(231, 43);
            this.txtSup_ID.TabIndex = 32;
            // 
            // txtEmp_ID
            // 
            this.txtEmp_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp_ID.Location = new System.Drawing.Point(294, 252);
            this.txtEmp_ID.Name = "txtEmp_ID";
            this.txtEmp_ID.Size = new System.Drawing.Size(231, 43);
            this.txtEmp_ID.TabIndex = 33;
            this.txtEmp_ID.Text = "STP5785";
            // 
            // AddImportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImp_ID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtSup_ID);
            this.Controls.Add(this.txtEmp_ID);
            this.Name = "AddImportUC";
            this.Size = new System.Drawing.Size(830, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImp_ID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtSup_ID;
        private System.Windows.Forms.TextBox txtEmp_ID;
    }
}
