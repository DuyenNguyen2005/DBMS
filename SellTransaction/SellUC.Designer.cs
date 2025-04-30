namespace Project_DBMS.SellTransaction
{
    partial class SellUC
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
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.dtgvDetail = new System.Windows.Forms.DataGridView();
            this.cboPro_ID = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.dateTimePickerImpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSupID = new System.Windows.Forms.ComboBox();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(92, 268);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(200, 26);
            this.numericUpDownPrice.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 34;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(601, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 53);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update Detail";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(434, 236);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(101, 53);
            this.btnDeleteDetail.TabIndex = 32;
            this.btnDeleteDetail.Text = "Delete Detai";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetail.Location = new System.Drawing.Point(91, 542);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.RowHeadersWidth = 62;
            this.dtgvDetail.Size = new System.Drawing.Size(760, 200);
            this.dtgvDetail.TabIndex = 31;
            // 
            // cboPro_ID
            // 
            this.cboPro_ID.FormattingEnabled = true;
            this.cboPro_ID.Location = new System.Drawing.Point(91, 186);
            this.cboPro_ID.Name = "cboPro_ID";
            this.cboPro_ID.Size = new System.Drawing.Size(200, 28);
            this.cboPro_ID.TabIndex = 30;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(91, 236);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 26);
            this.numericUpDownQuantity.TabIndex = 29;
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(91, 311);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersWidth = 62;
            this.dataGridViewDetails.Size = new System.Drawing.Size(760, 200);
            this.dataGridViewDetails.TabIndex = 28;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(299, 11);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(100, 23);
            this.btnAddEmployee.TabIndex = 27;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(299, 61);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(100, 23);
            this.btnAddSupplier.TabIndex = 26;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(297, 168);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(91, 62);
            this.btnDeleteTransaction.TabIndex = 25;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(298, 236);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(101, 53);
            this.btnAddDetail.TabIndex = 24;
            this.btnAddDetail.Text = "Add Detail";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(297, 90);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(100, 72);
            this.btnAddTransaction.TabIndex = 23;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // dateTimePickerImpDate
            // 
            this.dateTimePickerImpDate.Location = new System.Drawing.Point(91, 111);
            this.dateTimePickerImpDate.Name = "dateTimePickerImpDate";
            this.dateTimePickerImpDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerImpDate.TabIndex = 22;
            // 
            // cmbSupID
            // 
            this.cmbSupID.FormattingEnabled = true;
            this.cmbSupID.Location = new System.Drawing.Point(91, 61);
            this.cmbSupID.Name = "cmbSupID";
            this.cmbSupID.Size = new System.Drawing.Size(200, 28);
            this.cmbSupID.TabIndex = 21;
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(91, 11);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(200, 28);
            this.cmbEmpID.TabIndex = 20;
            // 
            // SellUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.dtgvDetail);
            this.Controls.Add(this.cboPro_ID);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.dateTimePickerImpDate);
            this.Controls.Add(this.cmbSupID);
            this.Controls.Add(this.cmbEmpID);
            this.Name = "SellUC";
            this.Size = new System.Drawing.Size(943, 753);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.DataGridView dtgvDetail;
        private System.Windows.Forms.ComboBox cboPro_ID;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.DateTimePicker dateTimePickerImpDate;
        private System.Windows.Forms.ComboBox cmbSupID;
        private System.Windows.Forms.ComboBox cmbEmpID;
    }
}
