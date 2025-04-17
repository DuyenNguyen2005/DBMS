namespace Project_DBMS
{
    partial class SellForm
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
            this.dtpSell = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.dataGridViewSell = new System.Windows.Forms.DataGridView();
            this.lbList = new System.Windows.Forms.Label();
            this.txtSell_Quantity = new System.Windows.Forms.TextBox();
            this.txtSell_Date = new System.Windows.Forms.TextBox();
            this.txtEmp_Name = new System.Windows.Forms.TextBox();
            this.txtPro_Name = new System.Windows.Forms.TextBox();
            this.txtCus_Name = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSell_Discount = new System.Windows.Forms.TextBox();
            this.txrSell_Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSell)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSell
            // 
            this.dtpSell.Location = new System.Drawing.Point(693, 112);
            this.dtpSell.Name = "dtpSell";
            this.dtpSell.Size = new System.Drawing.Size(324, 30);
            this.dtpSell.TabIndex = 58;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(550, 117);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(113, 25);
            this.lbDate.TabIndex = 57;
            this.lbDate.Text = "Selled Date";
            // 
            // dataGridViewSell
            // 
            this.dataGridViewSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSell.Location = new System.Drawing.Point(555, 213);
            this.dataGridViewSell.Name = "dataGridViewSell";
            this.dataGridViewSell.RowHeadersWidth = 62;
            this.dataGridViewSell.RowTemplate.Height = 28;
            this.dataGridViewSell.Size = new System.Drawing.Size(462, 308);
            this.dataGridViewSell.TabIndex = 56;
            this.dataGridViewSell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSell_CellClick);
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Location = new System.Drawing.Point(550, 174);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(135, 25);
            this.lbList.TabIndex = 55;
            this.lbList.Text = "List of Product";
            // 
            // txtSell_Quantity
            // 
            this.txtSell_Quantity.Location = new System.Drawing.Point(195, 405);
            this.txtSell_Quantity.Name = "txtSell_Quantity";
            this.txtSell_Quantity.Size = new System.Drawing.Size(324, 30);
            this.txtSell_Quantity.TabIndex = 54;
            // 
            // txtSell_Date
            // 
            this.txtSell_Date.Location = new System.Drawing.Point(195, 343);
            this.txtSell_Date.Name = "txtSell_Date";
            this.txtSell_Date.Size = new System.Drawing.Size(324, 30);
            this.txtSell_Date.TabIndex = 53;
            // 
            // txtEmp_Name
            // 
            this.txtEmp_Name.Location = new System.Drawing.Point(195, 285);
            this.txtEmp_Name.Name = "txtEmp_Name";
            this.txtEmp_Name.Size = new System.Drawing.Size(324, 30);
            this.txtEmp_Name.TabIndex = 52;
            // 
            // txtPro_Name
            // 
            this.txtPro_Name.Location = new System.Drawing.Point(195, 169);
            this.txtPro_Name.Name = "txtPro_Name";
            this.txtPro_Name.Size = new System.Drawing.Size(324, 30);
            this.txtPro_Name.TabIndex = 51;
            // 
            // txtCus_Name
            // 
            this.txtCus_Name.Location = new System.Drawing.Point(195, 226);
            this.txtCus_Name.Name = "txtCus_Name";
            this.txtCus_Name.Size = new System.Drawing.Size(324, 30);
            this.txtCus_Name.TabIndex = 50;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(195, 112);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(324, 30);
            this.txtId.TabIndex = 49;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 48);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Location = new System.Drawing.Point(52, 410);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(99, 25);
            this.lbEmployee.TabIndex = 46;
            this.lbEmployee.Text = "Employee";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(52, 348);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(57, 25);
            this.lbType.TabIndex = 45;
            this.lbType.Text = "Type";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(52, 290);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(85, 25);
            this.lbQuantity.TabIndex = 44;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(52, 231);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(94, 25);
            this.lbPrice.TabIndex = 43;
            this.lbPrice.Text = "Sell Price";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(52, 174);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(136, 25);
            this.lbName.TabIndex = 42;
            this.lbName.Text = "Product Name";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(52, 117);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(69, 25);
            this.lbId.TabIndex = 41;
            this.lbId.Text = "Sell ID";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(49, 42);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(260, 44);
            this.lbTitle.TabIndex = 40;
            this.lbTitle.Text = "Sell Transaction";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(159, 579);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 30);
            this.txtSearch.TabIndex = 65;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Search";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(273, 473);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 48);
            this.btnEdit.TabIndex = 61;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 473);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 48);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(57, 473);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 48);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSell_Discount
            // 
            this.txtSell_Discount.Location = new System.Drawing.Point(543, 563);
            this.txtSell_Discount.Name = "txtSell_Discount";
            this.txtSell_Discount.Size = new System.Drawing.Size(324, 30);
            this.txtSell_Discount.TabIndex = 66;
            // 
            // txrSell_Price
            // 
            this.txrSell_Price.Location = new System.Drawing.Point(543, 626);
            this.txrSell_Price.Name = "txrSell_Price";
            this.txrSell_Price.Size = new System.Drawing.Size(324, 30);
            this.txrSell_Price.TabIndex = 67;
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 761);
            this.Controls.Add(this.txrSell_Price);
            this.Controls.Add(this.txtSell_Discount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpSell);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.dataGridViewSell);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.txtSell_Quantity);
            this.Controls.Add(this.txtSell_Date);
            this.Controls.Add(this.txtEmp_Name);
            this.Controls.Add(this.txtPro_Name);
            this.Controls.Add(this.txtCus_Name);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbEmployee);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellForm";
            this.Text = "Sell Form";
            this.Load += new System.EventHandler(this.SellForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSell;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DataGridView dataGridViewSell;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.TextBox txtSell_Quantity;
        private System.Windows.Forms.TextBox txtSell_Date;
        private System.Windows.Forms.TextBox txtEmp_Name;
        private System.Windows.Forms.TextBox txtPro_Name;
        private System.Windows.Forms.TextBox txtCus_Name;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSell_Discount;
        private System.Windows.Forms.TextBox txrSell_Price;
    }
}