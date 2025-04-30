namespace Project_DBMS.Statictics
{
    partial class OtherStatictics
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
            this.lb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtgvTransaction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(46, 45);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(249, 25);
            this.lb.TabIndex = 5;
            this.lb.Text = "CHỌN LOẠI GIAO DỊCH";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EmployeeSalesStatistic",
            "ImportStatistic",
            "ProductInOutSummary",
            "ProductInventoryStatus",
            "RecentCustomerPurchases",
            "RevenueStatistic",
            "SupplierImportStatistic",
            "TopMonthlyCustomers",
            "VIPCustomers",
            "vw_Top5BestSellingProductsByMonth"});
            this.comboBox1.Location = new System.Drawing.Point(327, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtgvTransaction
            // 
            this.dtgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTransaction.Location = new System.Drawing.Point(51, 113);
            this.dtgvTransaction.Name = "dtgvTransaction";
            this.dtgvTransaction.RowHeadersWidth = 62;
            this.dtgvTransaction.RowTemplate.Height = 28;
            this.dtgvTransaction.Size = new System.Drawing.Size(1284, 314);
            this.dtgvTransaction.TabIndex = 6;
            // 
            // OtherStatictics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvTransaction);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.comboBox1);
            this.Name = "OtherStatictics";
            this.Size = new System.Drawing.Size(1578, 499);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dtgvTransaction;
    }
}
