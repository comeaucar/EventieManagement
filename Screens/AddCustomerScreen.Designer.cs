namespace EventieManagement
{
    partial class AddCustomerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerScreen));
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnSubmitCustomer = new System.Windows.Forms.Button();
            this.btnBackToCustomerOptions = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEventieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddCustomer.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAddCustomer.Location = new System.Drawing.Point(405, 41);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(423, 97);
            this.lblAddCustomer.TabIndex = 20;
            this.lblAddCustomer.Text = "Add Customer";
            this.lblAddCustomer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFirstName.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Lavender;
            this.lblFirstName.Location = new System.Drawing.Point(373, 170);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(248, 63);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLastName.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Lavender;
            this.lblLastName.Location = new System.Drawing.Point(379, 247);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(242, 63);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhoneNumber.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Lavender;
            this.lblPhoneNumber.Location = new System.Drawing.Point(294, 324);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(327, 63);
            this.lblPhoneNumber.TabIndex = 32;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // btnSubmitCustomer
            // 
            this.btnSubmitCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitCustomer.Font = new System.Drawing.Font("Eras Bold ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCustomer.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitCustomer.Location = new System.Drawing.Point(552, 448);
            this.btnSubmitCustomer.Name = "btnSubmitCustomer";
            this.btnSubmitCustomer.Size = new System.Drawing.Size(158, 57);
            this.btnSubmitCustomer.TabIndex = 3;
            this.btnSubmitCustomer.Text = "SUBMIT";
            this.btnSubmitCustomer.UseVisualStyleBackColor = false;
            this.btnSubmitCustomer.Click += new System.EventHandler(this.btnSubmitCustomer_Click);
            // 
            // btnBackToCustomerOptions
            // 
            this.btnBackToCustomerOptions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackToCustomerOptions.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToCustomerOptions.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBackToCustomerOptions.Location = new System.Drawing.Point(12, 633);
            this.btnBackToCustomerOptions.Name = "btnBackToCustomerOptions";
            this.btnBackToCustomerOptions.Size = new System.Drawing.Size(99, 54);
            this.btnBackToCustomerOptions.TabIndex = 5;
            this.btnBackToCustomerOptions.Text = "Back";
            this.btnBackToCustomerOptions.UseVisualStyleBackColor = false;
            this.btnBackToCustomerOptions.Click += new System.EventHandler(this.btnBackToCustomerOptions_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.AcceptsTab = true;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(638, 196);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 29);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.AcceptsTab = true;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(638, 273);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 29);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSuccess.Font = new System.Drawing.Font("Eras Bold ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblSuccess.Location = new System.Drawing.Point(392, 624);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 40);
            this.lblSuccess.TabIndex = 10;
            this.lblSuccess.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutEventieToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutEventieToolStripMenuItem
            // 
            this.aboutEventieToolStripMenuItem.Name = "aboutEventieToolStripMenuItem";
            this.aboutEventieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutEventieToolStripMenuItem.Text = "About Eventie";
            this.aboutEventieToolStripMenuItem.Click += new System.EventHandler(this.aboutEventieToolStripMenuItem_Click);
            // 
            // progress
            // 
            this.progress.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.progress.Location = new System.Drawing.Point(399, 551);
            this.progress.MarqueeAnimationSpeed = 15;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(475, 13);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BeepOnError = true;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(638, 350);
            this.txtPhoneNumber.Mask = "(999) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(203, 29);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // AddCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnBackToCustomerOptions);
            this.Controls.Add(this.btnSubmitCustomer);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1214, 738);
            this.MinimumSize = new System.Drawing.Size(1214, 738);
            this.Name = "AddCustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomerScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnSubmitCustomer;
        private System.Windows.Forms.Button btnBackToCustomerOptions;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEventieToolStripMenuItem;
    }
}