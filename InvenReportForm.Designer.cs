namespace Project_DBMS
{
    partial class InvenReportForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.lbTotalInventoryCost = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dtgvInventoryReport = new System.Windows.Forms.DataGridView();
            this.txtTotalInventoryCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventoryReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(57, 47);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(264, 44);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Inventory Report";
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Location = new System.Drawing.Point(60, 135);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(103, 25);
            this.lbFromDate.TabIndex = 1;
            this.lbFromDate.Text = "From Date";
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.Location = new System.Drawing.Point(528, 135);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(82, 25);
            this.lbToDate.TabIndex = 2;
            this.lbToDate.Text = "To Date";
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Location = new System.Drawing.Point(60, 196);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(84, 25);
            this.lbSupplier.TabIndex = 3;
            this.lbSupplier.Text = "Supplier";
            // 
            // lbTotalInventoryCost
            // 
            this.lbTotalInventoryCost.AutoSize = true;
            this.lbTotalInventoryCost.Location = new System.Drawing.Point(60, 504);
            this.lbTotalInventoryCost.Name = "lbTotalInventoryCost";
            this.lbTotalInventoryCost.Size = new System.Drawing.Size(187, 25);
            this.lbTotalInventoryCost.TabIndex = 4;
            this.lbTotalInventoryCost.Text = "Total Inventory Cost";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(169, 130);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(321, 30);
            this.dtpFromDate.TabIndex = 5;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(616, 130);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(321, 30);
            this.dtpToDate.TabIndex = 6;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(169, 188);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(321, 33);
            this.cbSupplier.TabIndex = 7;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(701, 493);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(236, 42);
            this.btnGenerateReport.TabIndex = 8;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // dtgvInventoryReport
            // 
            this.dtgvInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInventoryReport.Location = new System.Drawing.Point(65, 256);
            this.dtgvInventoryReport.Name = "dtgvInventoryReport";
            this.dtgvInventoryReport.RowHeadersWidth = 62;
            this.dtgvInventoryReport.RowTemplate.Height = 28;
            this.dtgvInventoryReport.Size = new System.Drawing.Size(872, 211);
            this.dtgvInventoryReport.TabIndex = 9;
            // 
            // txtTotalInventoryCost
            // 
            this.txtTotalInventoryCost.Location = new System.Drawing.Point(253, 499);
            this.txtTotalInventoryCost.Name = "txtTotalInventoryCost";
            this.txtTotalInventoryCost.Size = new System.Drawing.Size(237, 30);
            this.txtTotalInventoryCost.TabIndex = 10;
            // 
            // InvenReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 581);
            this.Controls.Add(this.txtTotalInventoryCost);
            this.Controls.Add(this.dtgvInventoryReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lbTotalInventoryCost);
            this.Controls.Add(this.lbSupplier);
            this.Controls.Add(this.lbToDate);
            this.Controls.Add(this.lbFromDate);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvenReportForm";
            this.Text = "Inventory Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventoryReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.Label lbTotalInventoryCost;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dtgvInventoryReport;
        private System.Windows.Forms.TextBox txtTotalInventoryCost;
    }
}