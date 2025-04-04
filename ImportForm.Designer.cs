namespace Project_DBMS
{
    partial class ImportForm
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
            this.dataGridViewImport = new System.Windows.Forms.DataGridView();
            this.lbList = new System.Windows.Forms.Label();
            this.TxtSupplier = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtpImport = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImport
            // 
            this.dataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImport.Location = new System.Drawing.Point(552, 209);
            this.dataGridViewImport.Name = "dataGridViewImport";
            this.dataGridViewImport.RowHeadersWidth = 62;
            this.dataGridViewImport.RowTemplate.Height = 28;
            this.dataGridViewImport.Size = new System.Drawing.Size(462, 308);
            this.dataGridViewImport.TabIndex = 37;
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Location = new System.Drawing.Point(547, 170);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(135, 25);
            this.lbList.TabIndex = 36;
            this.lbList.Text = "List of Product";
            // 
            // TxtSupplier
            // 
            this.TxtSupplier.Location = new System.Drawing.Point(192, 401);
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.Size = new System.Drawing.Size(324, 30);
            this.TxtSupplier.TabIndex = 35;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(192, 339);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(324, 30);
            this.txtType.TabIndex = 34;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(192, 281);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(324, 30);
            this.txtQuantity.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 165);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(324, 30);
            this.txtName.TabIndex = 32;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(192, 222);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(324, 30);
            this.txtPrice.TabIndex = 31;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(192, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(324, 30);
            this.txtId.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(192, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 48);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(54, 469);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 48);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Location = new System.Drawing.Point(49, 406);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(84, 25);
            this.lbSupplier.TabIndex = 25;
            this.lbSupplier.Text = "Supplier";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(49, 344);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(57, 25);
            this.lbType.TabIndex = 24;
            this.lbType.Text = "Type";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(49, 286);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(85, 25);
            this.lbQuantity.TabIndex = 23;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(49, 227);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(115, 25);
            this.lbPrice.TabIndex = 22;
            this.lbPrice.Text = "Import Price";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(49, 170);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(136, 25);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Product Name";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(49, 113);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(90, 25);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Import ID";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(46, 38);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(303, 44);
            this.lbTitle.TabIndex = 19;
            this.lbTitle.Text = "Import Transaction";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(547, 113);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(134, 25);
            this.lbDate.TabIndex = 38;
            this.lbDate.Text = "Imported Date";
            // 
            // dtpImport
            // 
            this.dtpImport.Location = new System.Drawing.Point(690, 108);
            this.dtpImport.Name = "dtpImport";
            this.dtpImport.Size = new System.Drawing.Size(324, 30);
            this.dtpImport.TabIndex = 39;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dtpImport);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.dataGridViewImport);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.TxtSupplier);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbSupplier);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportForm";
            this.Text = "Import Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewImport;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.TextBox TxtSupplier;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dtpImport;
    }
}