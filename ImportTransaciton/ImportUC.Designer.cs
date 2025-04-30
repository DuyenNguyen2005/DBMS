namespace Project_DBMS.ImportTransaciton
{
    partial class SellUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
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

        private void InitializeComponent()
        {
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersWidth = 62;
            this.dataGridViewDetails.Size = new System.Drawing.Size(908, 415);
            this.dataGridViewDetails.TabIndex = 10;
            // 
            // SellUC
            // 
            this.Controls.Add(this.dataGridViewDetails);
            this.Name = "SellUC";
            this.Size = new System.Drawing.Size(908, 415);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
