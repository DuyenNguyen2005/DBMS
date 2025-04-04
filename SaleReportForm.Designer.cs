namespace Project_DBMS
{
    partial class SaleReportForm
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
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.dtgvSaleReport = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSaleReport)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Location = new System.Drawing.Point(205, 494);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Size = new System.Drawing.Size(285, 30);
            this.txtTotalRevenue.TabIndex = 21;
            // 
            // dtgvSaleReport
            // 
            this.dtgvSaleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSaleReport.Location = new System.Drawing.Point(65, 251);
            this.dtgvSaleReport.Name = "dtgvSaleReport";
            this.dtgvSaleReport.RowHeadersWidth = 62;
            this.dtgvSaleReport.RowTemplate.Height = 28;
            this.dtgvSaleReport.Size = new System.Drawing.Size(872, 211);
            this.dtgvSaleReport.TabIndex = 20;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(701, 488);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(236, 42);
            this.btnGenerateReport.TabIndex = 19;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(169, 183);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(321, 33);
            this.cbCustomer.TabIndex = 18;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(616, 125);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(321, 30);
            this.dtpToDate.TabIndex = 17;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(169, 125);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(321, 30);
            this.dtpFromDate.TabIndex = 16;
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Location = new System.Drawing.Point(60, 499);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(139, 25);
            this.lbTotalRevenue.TabIndex = 15;
            this.lbTotalRevenue.Text = "Total Revenue";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(60, 191);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(97, 25);
            this.lbCustomer.TabIndex = 14;
            this.lbCustomer.Text = "Customer";
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.Location = new System.Drawing.Point(528, 130);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(82, 25);
            this.lbToDate.TabIndex = 13;
            this.lbToDate.Text = "To Date";
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Location = new System.Drawing.Point(60, 130);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(103, 25);
            this.lbFromDate.TabIndex = 12;
            this.lbFromDate.Text = "From Date";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(57, 47);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(189, 44);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "Sale Report";
            // 
            // SaleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 581);
            this.Controls.Add(this.txtTotalRevenue);
            this.Controls.Add(this.dtgvSaleReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lbTotalRevenue);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.lbToDate);
            this.Controls.Add(this.lbFromDate);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SaleReportForm";
            this.Text = "Sale Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSaleReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.DataGridView dtgvSaleReport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.Label lbTitle;
    }
}