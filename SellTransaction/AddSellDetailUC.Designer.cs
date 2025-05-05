namespace Project_DBMS.SellTransaction
{
    partial class AddSellDetailUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.nmdQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtgvSelected = new System.Windows.Forms.DataGridView();
            this.lbAmout = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValuable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvValuable
            // 
            this.dtgvValuable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvValuable.Location = new System.Drawing.Point(35, 105);
            this.dtgvValuable.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvValuable.Name = "dtgvValuable";
            this.dtgvValuable.RowHeadersWidth = 62;
            this.dtgvValuable.RowTemplate.Height = 28;
            this.dtgvValuable.Size = new System.Drawing.Size(407, 244);
            this.dtgvValuable.TabIndex = 0;
            this.dtgvValuable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvValuable_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(181, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(707, 28);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // nmdQuantity
            // 
            this.nmdQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmdQuantity.Location = new System.Drawing.Point(1051, 60);
            this.nmdQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.nmdQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmdQuantity.Name = "nmdQuantity";
            this.nmdQuantity.Size = new System.Drawing.Size(80, 28);
            this.nmdQuantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(923, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(929, 108);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 58);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(929, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 58);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(929, 230);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 58);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtgvSelected
            // 
            this.dtgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSelected.Location = new System.Drawing.Point(485, 105);
            this.dtgvSelected.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvSelected.Name = "dtgvSelected";
            this.dtgvSelected.RowHeadersWidth = 62;
            this.dtgvSelected.RowTemplate.Height = 28;
            this.dtgvSelected.Size = new System.Drawing.Size(403, 244);
            this.dtgvSelected.TabIndex = 8;
            this.dtgvSelected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSelected_CellClick);
            // 
            // lbAmout
            // 
            this.lbAmout.AutoSize = true;
            this.lbAmout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmout.Location = new System.Drawing.Point(923, 318);
            this.lbAmout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAmout.Name = "lbAmout";
            this.lbAmout.Size = new System.Drawing.Size(95, 21);
            this.lbAmout.TabIndex = 9;
            this.lbAmout.Text = "Tổng Tiền: ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(485, 359);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(407, 25);
            this.button2.TabIndex = 26;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddSellDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbAmout);
            this.Controls.Add(this.dtgvSelected);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmdQuantity);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvValuable);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddSellDetailUC";
            this.Size = new System.Drawing.Size(1172, 521);
            this.Load += new System.EventHandler(this.SellDetailUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValuable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvValuable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.NumericUpDown nmdQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgvSelected;
        private System.Windows.Forms.Label lbAmout;
        private System.Windows.Forms.Button button2;
    }
}
