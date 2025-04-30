namespace Project_DBMS.Statictics
{
    partial class Transaction
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
            this.dtgvTransaction = new System.Windows.Forms.DataGridView();
            this.dtgvDetail = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTransaction
            // 
            this.dtgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTransaction.Location = new System.Drawing.Point(72, 213);
            this.dtgvTransaction.Name = "dtgvTransaction";
            this.dtgvTransaction.RowHeadersWidth = 62;
            this.dtgvTransaction.RowTemplate.Height = 28;
            this.dtgvTransaction.Size = new System.Drawing.Size(706, 314);
            this.dtgvTransaction.TabIndex = 0;
            this.dtgvTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTransaction_CellClick);
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetail.Location = new System.Drawing.Point(858, 213);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.RowHeadersWidth = 62;
            this.dtgvDetail.RowTemplate.Height = 28;
            this.dtgvDetail.Size = new System.Drawing.Size(706, 314);
            this.dtgvDetail.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NHẬP",
            "BÁN"});
            this.comboBox1.Location = new System.Drawing.Point(72, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(72, 99);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(249, 25);
            this.lb.TabIndex = 3;
            this.lb.Text = "CHỌN LOẠI GIAO DỊCH";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "XÓA GIAO DỊCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtgvDetail);
            this.Controls.Add(this.dtgvTransaction);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(1625, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTransaction;
        private System.Windows.Forms.DataGridView dtgvDetail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button button1;
    }
}
