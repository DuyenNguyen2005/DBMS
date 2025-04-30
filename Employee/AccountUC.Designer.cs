namespace Project_DBMS.Employee
{
    partial class AccountUC
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
            this.dtgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnListAcount = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDisplay
            // 
            this.dtgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDisplay.Location = new System.Drawing.Point(101, 222);
            this.dtgvDisplay.Name = "dtgvDisplay";
            this.dtgvDisplay.RowHeadersWidth = 62;
            this.dtgvDisplay.RowTemplate.Height = 28;
            this.dtgvDisplay.Size = new System.Drawing.Size(856, 406);
            this.dtgvDisplay.TabIndex = 0;
            // 
            // btnListAcount
            // 
            this.btnListAcount.Location = new System.Drawing.Point(101, 53);
            this.btnListAcount.Name = "btnListAcount";
            this.btnListAcount.Size = new System.Drawing.Size(178, 70);
            this.btnListAcount.TabIndex = 1;
            this.btnListAcount.Text = "List Account";
            this.btnListAcount.UseVisualStyleBackColor = true;
            this.btnListAcount.Click += new System.EventHandler(this.btnListAcount_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modified time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset Password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnListAcount);
            this.Controls.Add(this.dtgvDisplay);
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(1043, 659);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDisplay;
        private System.Windows.Forms.Button btnListAcount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
