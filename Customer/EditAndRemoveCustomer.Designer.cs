namespace Project_DBMS.Customer
{
    partial class EditAndRemoveCustomer
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(255, 314);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(189, 47);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(191, 67);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Tên khách hàng:";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(30, 179);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(209, 53);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 248);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(191, 60);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(255, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(394, 43);
            this.txtName.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(255, 176);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(394, 43);
            this.txtPhone.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(255, 248);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(394, 43);
            this.txtAddress.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 73);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Khác Hàng";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(255, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(231, 43);
            this.txtid.TabIndex = 30;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(470, 314);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(179, 47);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(508, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 46);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // EditAndRemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Name = "EditAndRemoveCustomer";
            this.Size = new System.Drawing.Size(751, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
    }
}
