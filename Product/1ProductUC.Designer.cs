using System.Drawing;

namespace Project_DBMS.Product
{
    partial class AddProduct
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

        private void InitializeComponent()
        {
            this.textBoxProID = new System.Windows.Forms.TextBox();
            this.textBoxProName = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxProType = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelProID = new System.Windows.Forms.Label();
            this.labelProName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelMaxQuantity = new System.Windows.Forms.Label();
            this.labelProType = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelSupID = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxSupID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProID
            // 
            this.textBoxProID.Location = new System.Drawing.Point(120, 20);
            this.textBoxProID.Name = "textBoxProID";
            this.textBoxProID.Size = new System.Drawing.Size(200, 26);
            this.textBoxProID.TabIndex = 0;
            // 
            // textBoxProName
            // 
            this.textBoxProName.Location = new System.Drawing.Point(120, 60);
            this.textBoxProName.Name = "textBoxProName";
            this.textBoxProName.Size = new System.Drawing.Size(200, 26);
            this.textBoxProName.TabIndex = 1;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(120, 100);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(200, 26);
            this.numericUpDownPrice.TabIndex = 2;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(120, 140);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 26);
            this.numericUpDownQuantity.TabIndex = 3;
            // 
            // numericUpDownMaxQuantity
            // 
            this.numericUpDownMaxQuantity.Location = new System.Drawing.Point(120, 180);
            this.numericUpDownMaxQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMaxQuantity.Name = "numericUpDownMaxQuantity";
            this.numericUpDownMaxQuantity.Size = new System.Drawing.Size(200, 26);
            this.numericUpDownMaxQuantity.TabIndex = 4;
            // 
            // textBoxProType
            // 
            this.textBoxProType.Location = new System.Drawing.Point(120, 220);
            this.textBoxProType.Name = "textBoxProType";
            this.textBoxProType.Size = new System.Drawing.Size(200, 26);
            this.textBoxProType.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(120, 260);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 26);
            this.textBoxDescription.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "In Stock",
            "Low Stock",
            "Out of Stock"});
            this.comboBoxStatus.Location = new System.Drawing.Point(120, 300);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 28);
            this.comboBoxStatus.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(120, 380);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 26);
            this.textBoxSearch.TabIndex = 13;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(30, 420);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.Size = new System.Drawing.Size(600, 200);
            this.dataGridViewProducts.TabIndex = 14;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // labelProID
            // 
            this.labelProID.AutoSize = true;
            this.labelProID.Location = new System.Drawing.Point(30, 20);
            this.labelProID.Name = "labelProID";
            this.labelProID.Size = new System.Drawing.Size(85, 20);
            this.labelProID.TabIndex = 15;
            this.labelProID.Text = "Product ID";
            // 
            // labelProName
            // 
            this.labelProName.AutoSize = true;
            this.labelProName.Location = new System.Drawing.Point(30, 60);
            this.labelProName.Name = "labelProName";
            this.labelProName.Size = new System.Drawing.Size(110, 20);
            this.labelProName.TabIndex = 16;
            this.labelProName.Text = "Product Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(30, 100);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 17;
            this.labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(30, 140);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 20);
            this.labelQuantity.TabIndex = 18;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelMaxQuantity
            // 
            this.labelMaxQuantity.AutoSize = true;
            this.labelMaxQuantity.Location = new System.Drawing.Point(30, 180);
            this.labelMaxQuantity.Name = "labelMaxQuantity";
            this.labelMaxQuantity.Size = new System.Drawing.Size(101, 20);
            this.labelMaxQuantity.TabIndex = 19;
            this.labelMaxQuantity.Text = "Max Quantity";
            // 
            // labelProType
            // 
            this.labelProType.AutoSize = true;
            this.labelProType.Location = new System.Drawing.Point(30, 220);
            this.labelProType.Name = "labelProType";
            this.labelProType.Size = new System.Drawing.Size(102, 20);
            this.labelProType.TabIndex = 20;
            this.labelProType.Text = "Product Type";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(30, 260);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(89, 20);
            this.labelDescription.TabIndex = 21;
            this.labelDescription.Text = "Description";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(30, 300);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 22;
            this.labelStatus.Text = "Status";
            // 
            // labelSupID
            // 
            this.labelSupID.AutoSize = true;
            this.labelSupID.Location = new System.Drawing.Point(30, 340);
            this.labelSupID.Name = "labelSupID";
            this.labelSupID.Size = new System.Drawing.Size(88, 20);
            this.labelSupID.TabIndex = 23;
            this.labelSupID.Text = "Supplier ID";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(30, 380);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(123, 20);
            this.labelSearch.TabIndex = 24;
            this.labelSearch.Text = "Search Product:";
            // 
            // comboBoxSupID
            // 
            this.comboBoxSupID.FormattingEnabled = true;
            this.comboBoxSupID.Location = new System.Drawing.Point(124, 334);
            this.comboBoxSupID.Name = "comboBoxSupID";
            this.comboBoxSupID.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSupID.TabIndex = 25;
            // 
            // AddProduct
            // 
            this.Controls.Add(this.comboBoxSupID);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelSupID);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelProType);
            this.Controls.Add(this.labelMaxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProName);
            this.Controls.Add(this.labelProID);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxProType);
            this.Controls.Add(this.numericUpDownMaxQuantity);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.textBoxProName);
            this.Controls.Add(this.textBoxProID);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(800, 650);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProID;
        private System.Windows.Forms.TextBox textBoxProName;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxQuantity;
        private System.Windows.Forms.TextBox textBoxProType;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelProID;
        private System.Windows.Forms.Label labelProName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelMaxQuantity;
        private System.Windows.Forms.Label labelProType;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelSupID;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxSupID;
    }
}
