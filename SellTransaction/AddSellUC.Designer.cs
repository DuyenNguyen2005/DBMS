namespace Project_DBMS.SellTransaction
{
    partial class AddSellUC
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtEmp_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImp_ID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(32, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(228, 67);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Mã Khách Hàng";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(32, 197);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(219, 53);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Mã Nhân Viên:";
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(257, 116);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(231, 43);
            this.txtCusID.TabIndex = 25;
            // 
            // txtEmp_ID
            // 
            this.txtEmp_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp_ID.Location = new System.Drawing.Point(257, 194);
            this.txtEmp_ID.Name = "txtEmp_ID";
            this.txtEmp_ID.Size = new System.Drawing.Size(231, 43);
            this.txtEmp_ID.TabIndex = 26;
            this.txtEmp_ID.Text = "STA0242";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 67);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Giao Dịch";
            // 
            // txtImp_ID
            // 
            this.txtImp_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImp_ID.Location = new System.Drawing.Point(257, 49);
            this.txtImp_ID.Name = "txtImp_ID";
            this.txtImp_ID.Size = new System.Drawing.Size(231, 43);
            this.txtImp_ID.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(515, 111);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 48);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddSellUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImp_ID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.txtEmp_ID);
            this.Name = "AddSellUC";
            this.Size = new System.Drawing.Size(688, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtEmp_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImp_ID;
        private System.Windows.Forms.Button btnAdd;
    }
}
