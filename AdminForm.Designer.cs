namespace Project_DBMS
{
    partial class AdminForm
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
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Location = new System.Drawing.Point(37, 52);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(216, 92);
            this.btnAddNewEmployee.TabIndex = 0;
            this.btnAddNewEmployee.Text = "Add New Employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // pnDisplay
            // 
            this.pnDisplay.Location = new System.Drawing.Point(313, 52);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(1999, 1035);
            this.pnDisplay.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(37, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(216, 92);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(37, 248);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(216, 92);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2392, 1155);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.btnAddNewEmployee);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnDisplay;
        internal System.Windows.Forms.Button btnAddNewEmployee;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnAccount;
    }
}