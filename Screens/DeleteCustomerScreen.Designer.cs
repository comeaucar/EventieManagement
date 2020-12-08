namespace EventieManagement
{
    partial class DeleteCustomerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomerScreen));
            this.lblDeleteCustomer = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnBackToCustomerOptions = new System.Windows.Forms.Button();
            this.lblSuccessMsg = new System.Windows.Forms.Label();
            this.lblConfirmDelete = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEventieioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteCustomer
            // 
            this.lblDeleteCustomer.AutoSize = true;
            this.lblDeleteCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeleteCustomer.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCustomer.ForeColor = System.Drawing.Color.LightCoral;
            this.lblDeleteCustomer.Location = new System.Drawing.Point(305, 37);
            this.lblDeleteCustomer.Name = "lblDeleteCustomer";
            this.lblDeleteCustomer.Size = new System.Drawing.Size(497, 97);
            this.lblDeleteCustomer.TabIndex = 1;
            this.lblDeleteCustomer.Text = "Delete Customer";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerID.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCustomerID.Location = new System.Drawing.Point(311, 205);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(275, 63);
            this.lblCustomerID.TabIndex = 8;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(592, 221);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(101, 47);
            this.txtCustomerID.TabIndex = 9;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchCustomer.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnSearchCustomer.Location = new System.Drawing.Point(724, 221);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(117, 47);
            this.btnSearchCustomer.TabIndex = 11;
            this.btnSearchCustomer.Text = "DELETE";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnBackToCustomerOptions
            // 
            this.btnBackToCustomerOptions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackToCustomerOptions.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToCustomerOptions.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBackToCustomerOptions.Location = new System.Drawing.Point(12, 633);
            this.btnBackToCustomerOptions.Name = "btnBackToCustomerOptions";
            this.btnBackToCustomerOptions.Size = new System.Drawing.Size(99, 54);
            this.btnBackToCustomerOptions.TabIndex = 12;
            this.btnBackToCustomerOptions.Text = "Back";
            this.btnBackToCustomerOptions.UseVisualStyleBackColor = false;
            this.btnBackToCustomerOptions.Click += new System.EventHandler(this.btnBackToCustomerOptions_Click);
            // 
            // lblSuccessMsg
            // 
            this.lblSuccessMsg.AutoSize = true;
            this.lblSuccessMsg.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessMsg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSuccessMsg.Location = new System.Drawing.Point(422, 611);
            this.lblSuccessMsg.Name = "lblSuccessMsg";
            this.lblSuccessMsg.Size = new System.Drawing.Size(0, 46);
            this.lblSuccessMsg.TabIndex = 13;
            // 
            // lblConfirmDelete
            // 
            this.lblConfirmDelete.AutoSize = true;
            this.lblConfirmDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConfirmDelete.Location = new System.Drawing.Point(314, 400);
            this.lblConfirmDelete.Name = "lblConfirmDelete";
            this.lblConfirmDelete.Size = new System.Drawing.Size(0, 48);
            this.lblConfirmDelete.TabIndex = 14;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYes.Font = new System.Drawing.Font("HP Simplified", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnYes.Location = new System.Drawing.Point(433, 488);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(153, 73);
            this.btnYes.TabIndex = 15;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Font = new System.Drawing.Font("HP Simplified", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(592, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 73);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutEventieioToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutEventieioToolStripMenuItem
            // 
            this.aboutEventieioToolStripMenuItem.Name = "aboutEventieioToolStripMenuItem";
            this.aboutEventieioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutEventieioToolStripMenuItem.Text = "About Eventie.io";
            // 
            // DeleteCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblConfirmDelete);
            this.Controls.Add(this.lblSuccessMsg);
            this.Controls.Add(this.btnBackToCustomerOptions);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblDeleteCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1214, 738);
            this.MinimumSize = new System.Drawing.Size(1214, 738);
            this.Name = "DeleteCustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.DeleteCustomerScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteCustomer;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnBackToCustomerOptions;
        private System.Windows.Forms.Label lblSuccessMsg;
        private System.Windows.Forms.Label lblConfirmDelete;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEventieioToolStripMenuItem;
    }
}