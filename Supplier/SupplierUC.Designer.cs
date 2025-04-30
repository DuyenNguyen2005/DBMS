using System.Windows.Forms;

namespace Project_DBMS.Supplier
{
    partial class SupplierUC
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

        private void InitializeComponent()
        {
            this.textBoxSupID = new System.Windows.Forms.TextBox();
            this.textBoxSupName = new System.Windows.Forms.TextBox();
            this.textBoxSupAddress = new System.Windows.Forms.TextBox();
            this.textBoxSupPhone = new System.Windows.Forms.TextBox();
            this.textBoxSupEmail = new System.Windows.Forms.TextBox();
            this.textBoxSupWebsite = new System.Windows.Forms.TextBox();
            this.dateTimePickerJoinDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.labelSupID = new System.Windows.Forms.Label();
            this.labelSupName = new System.Windows.Forms.Label();
            this.labelSupAddress = new System.Windows.Forms.Label();
            this.labelSupPhone = new System.Windows.Forms.Label();
            this.labelSupEmail = new System.Windows.Forms.Label();
            this.labelSupWebsite = new System.Windows.Forms.Label();
            this.labelJoinDate = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSupID
            // 
            this.textBoxSupID.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupID.Location = new System.Drawing.Point(237, 20);
            this.textBoxSupID.Name = "textBoxSupID";
            this.textBoxSupID.Size = new System.Drawing.Size(200, 33);
            this.textBoxSupID.TabIndex = 0;
            // 
            // textBoxSupName
            // 
            this.textBoxSupName.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupName.Location = new System.Drawing.Point(237, 60);
            this.textBoxSupName.Name = "textBoxSupName";
            this.textBoxSupName.Size = new System.Drawing.Size(200, 33);
            this.textBoxSupName.TabIndex = 1;
            // 
            // textBoxSupAddress
            // 
            this.textBoxSupAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupAddress.Location = new System.Drawing.Point(237, 100);
            this.textBoxSupAddress.Name = "textBoxSupAddress";
            this.textBoxSupAddress.Size = new System.Drawing.Size(200, 33);
            this.textBoxSupAddress.TabIndex = 2;
            // 
            // textBoxSupPhone
            // 
            this.textBoxSupPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupPhone.Location = new System.Drawing.Point(237, 140);
            this.textBoxSupPhone.Name = "textBoxSupPhone";
            this.textBoxSupPhone.Size = new System.Drawing.Size(200, 33);
            this.textBoxSupPhone.TabIndex = 3;
            // 
            // textBoxSupEmail
            // 
            this.textBoxSupEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupEmail.Location = new System.Drawing.Point(237, 180);
            this.textBoxSupEmail.Name = "textBoxSupEmail";
            this.textBoxSupEmail.Size = new System.Drawing.Size(200, 33);
            this.textBoxSupEmail.TabIndex = 4;
            // 
            // textBoxSupWebsite
            // 
            this.textBoxSupWebsite.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupWebsite.Location = new System.Drawing.Point(237, 220);
            this.textBoxSupWebsite.Name = "textBoxSupWebsite";
            this.textBoxSupWebsite.Size = new System.Drawing.Size(200, 33);
            this.textBoxSupWebsite.TabIndex = 5;
            // 
            // dateTimePickerJoinDate
            // 
            this.dateTimePickerJoinDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerJoinDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerJoinDate.Location = new System.Drawing.Point(237, 260);
            this.dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            this.dateTimePickerJoinDate.Size = new System.Drawing.Size(200, 33);
            this.dateTimePickerJoinDate.TabIndex = 6;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStatus.Location = new System.Drawing.Point(237, 300);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(127, 26);
            this.checkBoxStatus.TabIndex = 7;
            this.checkBoxStatus.Text = "Hoạt động";
            // 
            // labelSupID
            // 
            this.labelSupID.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupID.Location = new System.Drawing.Point(30, 20);
            this.labelSupID.Name = "labelSupID";
            this.labelSupID.Size = new System.Drawing.Size(180, 40);
            this.labelSupID.TabIndex = 9;
            this.labelSupID.Text = "Mã nhà cung cấp:";
            // 
            // labelSupName
            // 
            this.labelSupName.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupName.Location = new System.Drawing.Point(30, 60);
            this.labelSupName.Name = "labelSupName";
            this.labelSupName.Size = new System.Drawing.Size(201, 40);
            this.labelSupName.TabIndex = 10;
            this.labelSupName.Text = "Tên nhà cung cấp:";
            // 
            // labelSupAddress
            // 
            this.labelSupAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupAddress.Location = new System.Drawing.Point(30, 100);
            this.labelSupAddress.Name = "labelSupAddress";
            this.labelSupAddress.Size = new System.Drawing.Size(180, 40);
            this.labelSupAddress.TabIndex = 11;
            this.labelSupAddress.Text = "Địa chỉ:";
            // 
            // labelSupPhone
            // 
            this.labelSupPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupPhone.Location = new System.Drawing.Point(30, 140);
            this.labelSupPhone.Name = "labelSupPhone";
            this.labelSupPhone.Size = new System.Drawing.Size(191, 40);
            this.labelSupPhone.TabIndex = 12;
            this.labelSupPhone.Text = "Số điện thoại:";
            // 
            // labelSupEmail
            // 
            this.labelSupEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupEmail.Location = new System.Drawing.Point(30, 180);
            this.labelSupEmail.Name = "labelSupEmail";
            this.labelSupEmail.Size = new System.Drawing.Size(120, 20);
            this.labelSupEmail.TabIndex = 13;
            this.labelSupEmail.Text = "Email:";
            // 
            // labelSupWebsite
            // 
            this.labelSupWebsite.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupWebsite.Location = new System.Drawing.Point(30, 220);
            this.labelSupWebsite.Name = "labelSupWebsite";
            this.labelSupWebsite.Size = new System.Drawing.Size(120, 20);
            this.labelSupWebsite.TabIndex = 14;
            this.labelSupWebsite.Text = "Website:";
            // 
            // labelJoinDate
            // 
            this.labelJoinDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoinDate.Location = new System.Drawing.Point(30, 260);
            this.labelJoinDate.Name = "labelJoinDate";
            this.labelJoinDate.Size = new System.Drawing.Size(180, 33);
            this.labelJoinDate.TabIndex = 15;
            this.labelJoinDate.Text = "Ngày tham gia:";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(30, 300);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(180, 44);
            this.labelStatus.TabIndex = 16;
            this.labelStatus.Text = "Trạng thái:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(875, 233);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(646, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(690, 33);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tìm Kiếm: ";
            // 
            // SupplierUC
            // 
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSupID);
            this.Controls.Add(this.textBoxSupName);
            this.Controls.Add(this.textBoxSupAddress);
            this.Controls.Add(this.textBoxSupPhone);
            this.Controls.Add(this.textBoxSupEmail);
            this.Controls.Add(this.textBoxSupWebsite);
            this.Controls.Add(this.dateTimePickerJoinDate);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.labelSupID);
            this.Controls.Add(this.labelSupName);
            this.Controls.Add(this.labelSupAddress);
            this.Controls.Add(this.labelSupPhone);
            this.Controls.Add(this.labelSupEmail);
            this.Controls.Add(this.labelSupWebsite);
            this.Controls.Add(this.labelJoinDate);
            this.Controls.Add(this.labelStatus);
            this.Name = "SupplierUC";
            this.Size = new System.Drawing.Size(1422, 370);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Các biến control cần khai báo
        private System.Windows.Forms.TextBox textBoxSupID;
        private System.Windows.Forms.TextBox textBoxSupName;
        private System.Windows.Forms.TextBox textBoxSupAddress;
        private System.Windows.Forms.TextBox textBoxSupPhone;
        private System.Windows.Forms.TextBox textBoxSupEmail;
        private System.Windows.Forms.TextBox textBoxSupWebsite;
        private System.Windows.Forms.DateTimePicker dateTimePickerJoinDate;
        private System.Windows.Forms.CheckBox checkBoxStatus;

        // Thêm Label
        private System.Windows.Forms.Label labelSupID;
        private System.Windows.Forms.Label labelSupName;
        private System.Windows.Forms.Label labelSupAddress;
        private System.Windows.Forms.Label labelSupPhone;
        private System.Windows.Forms.Label labelSupEmail;
        private System.Windows.Forms.Label labelSupWebsite;
        private System.Windows.Forms.Label labelJoinDate;
        private System.Windows.Forms.Label labelStatus;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Label label1;
    }
}
