namespace Project_DBMS.Customer
{
    partial class CustomerUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;

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

        private void InitializeComponent()
        {
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(22, 97);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(185, 33);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Mã khách hàng:";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(152, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên khách hàng:";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(22, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(175, 40);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(22, 217);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(175, 38);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(239, 97);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(153, 38);
            this.txtCustomerID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(239, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 38);
            this.txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(239, 177);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(153, 38);
            this.txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(239, 217);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(153, 38);
            this.txtAddress.TabIndex = 7;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeight = 34;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(478, 97);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 62;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(709, 250);
            this.dataGridViewCustomers.TabIndex = 12;
            this.dataGridViewCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellClick);
            this.dataGridViewCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(628, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 38);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustomerUC
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(1328, 403);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
