namespace Project_DBMS.SellTransaction
{
    partial class SellDetailUC
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
            this.dtgvValuable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValuable)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvValuable
            // 
            this.dtgvValuable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvValuable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvValuable.Location = new System.Drawing.Point(0, 0);
            this.dtgvValuable.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvValuable.Name = "dtgvValuable";
            this.dtgvValuable.RowHeadersWidth = 62;
            this.dtgvValuable.RowTemplate.Height = 28;
            this.dtgvValuable.Size = new System.Drawing.Size(996, 456);
            this.dtgvValuable.TabIndex = 3;
            // 
            // SellDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvValuable);
            this.Name = "SellDetailUC";
            this.Size = new System.Drawing.Size(996, 456);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValuable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvValuable;
    }
}
