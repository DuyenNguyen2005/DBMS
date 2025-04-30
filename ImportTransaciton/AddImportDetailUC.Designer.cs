namespace Project_DBMS.ImportTransaciton
{
    partial class AddImportDetailUC
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
            this.lbAmout = new System.Windows.Forms.Label();
            this.dtgvSelected = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmdQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvValuable = new System.Windows.Forms.DataGridView();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmImp_Price = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValuable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmImp_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAmout
            // 
            this.lbAmout.AutoSize = true;
            this.lbAmout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmout.Location = new System.Drawing.Point(949, 347);
            this.lbAmout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAmout.Name = "lbAmout";
            this.lbAmout.Size = new System.Drawing.Size(145, 31);
            this.lbAmout.TabIndex = 19;
            this.lbAmout.Text = "Tổng Tiền: ";
            // 
            // dtgvSelected
            // 
            this.dtgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSelected.Location = new System.Drawing.Point(511, 134);
            this.dtgvSelected.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvSelected.Name = "dtgvSelected";
            this.dtgvSelected.RowHeadersWidth = 62;
            this.dtgvSelected.RowTemplate.Height = 28;
            this.dtgvSelected.Size = new System.Drawing.Size(403, 244);
            this.dtgvSelected.TabIndex = 18;
            this.dtgvSelected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSelected_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(955, 273);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 58);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(955, 205);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 58);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(955, 137);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 58);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(949, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số lượng:";
            // 
            // nmdQuantity
            // 
            this.nmdQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmdQuantity.Location = new System.Drawing.Point(1077, 32);
            this.nmdQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.nmdQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmdQuantity.Name = "nmdQuantity";
            this.nmdQuantity.Size = new System.Drawing.Size(80, 38);
            this.nmdQuantity.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(207, 56);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(707, 26);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // dtgvValuable
            // 
            this.dtgvValuable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvValuable.Location = new System.Drawing.Point(61, 134);
            this.dtgvValuable.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvValuable.Name = "dtgvValuable";
            this.dtgvValuable.RowHeadersWidth = 62;
            this.dtgvValuable.RowTemplate.Height = 28;
            this.dtgvValuable.Size = new System.Drawing.Size(407, 244);
            this.dtgvValuable.TabIndex = 10;
            this.dtgvValuable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvValuable_CellClick);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.Location = new System.Drawing.Point(61, 398);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(407, 39);
            this.btnAddNewProduct.TabIndex = 20;
            this.btnAddNewProduct.Text = "Refresh";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(949, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Đớn Giá:";
            // 
            // nmImp_Price
            // 
            this.nmImp_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmImp_Price.Location = new System.Drawing.Point(1077, 80);
            this.nmImp_Price.Margin = new System.Windows.Forms.Padding(5);
            this.nmImp_Price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmImp_Price.Name = "nmImp_Price";
            this.nmImp_Price.Size = new System.Drawing.Size(80, 38);
            this.nmImp_Price.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(511, 398);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(407, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddImportDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmImp_Price);
            this.Controls.Add(this.btnAddNewProduct);
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
            this.Name = "AddImportDetailUC";
            this.Size = new System.Drawing.Size(1226, 487);
            this.Load += new System.EventHandler(this.AddImportDetailUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValuable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmImp_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAmout;
        private System.Windows.Forms.DataGridView dtgvSelected;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmdQuantity;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvValuable;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmImp_Price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
