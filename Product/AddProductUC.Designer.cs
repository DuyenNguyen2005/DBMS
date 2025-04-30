namespace Project_DBMS.Product
{
    partial class AddProductUC
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
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxSupID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesciption = new System.Windows.Forms.TextBox();
            this.txttpe = new System.Windows.Forms.TextBox();
            this.numericUpDownMaxQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(252, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 39);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxSupID
            // 
            this.comboBoxSupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupID.FormattingEnabled = true;
            this.comboBoxSupID.Location = new System.Drawing.Point(252, 319);
            this.comboBoxSupID.Name = "comboBoxSupID";
            this.comboBoxSupID.Size = new System.Drawing.Size(200, 37);
            this.comboBoxSupID.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 104;
            this.label1.Text = "Supplier ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 102;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 101;
            this.label4.Text = "Product Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 100;
            this.label5.Text = "Max Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 99;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 98;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 29);
            this.label8.TabIndex = 97;
            this.label8.Text = "Product Name";
            // 
            // txtDesciption
            // 
            this.txtDesciption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesciption.Location = new System.Drawing.Point(252, 269);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(200, 35);
            this.txtDesciption.TabIndex = 94;
            // 
            // txttpe
            // 
            this.txttpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttpe.Location = new System.Drawing.Point(252, 225);
            this.txttpe.Name = "txttpe";
            this.txttpe.Size = new System.Drawing.Size(200, 35);
            this.txttpe.TabIndex = 93;
            // 
            // numericUpDownMaxQuantity
            // 
            this.numericUpDownMaxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMaxQuantity.Location = new System.Drawing.Point(252, 180);
            this.numericUpDownMaxQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMaxQuantity.Name = "numericUpDownMaxQuantity";
            this.numericUpDownMaxQuantity.Size = new System.Drawing.Size(200, 35);
            this.numericUpDownMaxQuantity.TabIndex = 92;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(252, 140);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 35);
            this.numericUpDownQuantity.TabIndex = 91;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(252, 100);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(200, 35);
            this.numericUpDownPrice.TabIndex = 90;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(252, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 35);
            this.txtname.TabIndex = 89;
            // 
            // AddProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSupID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.txttpe);
            this.Controls.Add(this.numericUpDownMaxQuantity);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnSave);
            this.Name = "AddProductUC";
            this.Size = new System.Drawing.Size(577, 500);
            this.Load += new System.EventHandler(this.AddProductUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxSupID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesciption;
        private System.Windows.Forms.TextBox txttpe;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.TextBox txtname;
    }
}
