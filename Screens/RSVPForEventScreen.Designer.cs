namespace EventieManagement
{
    partial class RSVPForEventScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSVPForEventScreen));
            this.txtCustList = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventList = new System.Windows.Forms.TextBox();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.btnSubmitCustomer = new System.Windows.Forms.Button();
            this.btnBackToCustomerOptions = new System.Windows.Forms.Button();
            this.lblSuccessMsg = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEventieioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustList
            // 
            this.txtCustList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCustList.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustList.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCustList.Location = new System.Drawing.Point(594, 160);
            this.txtCustList.Multiline = true;
            this.txtCustList.Name = "txtCustList";
            this.txtCustList.ReadOnly = true;
            this.txtCustList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCustList.Size = new System.Drawing.Size(592, 201);
            this.txtCustList.TabIndex = 9;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFirstName.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Peru;
            this.lblFirstName.Location = new System.Drawing.Point(586, 111);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(229, 46);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "Customer List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(586, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Event List";
            // 
            // txtEventList
            // 
            this.txtEventList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEventList.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventList.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtEventList.Location = new System.Drawing.Point(594, 422);
            this.txtEventList.Multiline = true;
            this.txtEventList.Name = "txtEventList";
            this.txtEventList.ReadOnly = true;
            this.txtEventList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEventList.Size = new System.Drawing.Size(592, 192);
            this.txtEventList.TabIndex = 4;
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddCustomer.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAddCustomer.Location = new System.Drawing.Point(358, 14);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(480, 97);
            this.lblAddCustomer.TabIndex = 5;
            this.lblAddCustomer.Text = "Add Reservation";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerID.Font = new System.Drawing.Font("Eras Bold ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCustomerID.Location = new System.Drawing.Point(44, 141);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(321, 56);
            this.lblCustomerID.TabIndex = 6;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.BackColor = System.Drawing.SystemColors.Control;
            this.lblEventID.Font = new System.Drawing.Font("Eras Bold ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEventID.Location = new System.Drawing.Point(135, 232);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(230, 56);
            this.lblEventID.TabIndex = 7;
            this.lblEventID.Text = "Event ID";
            // 
            // txtEventId
            // 
            this.txtEventId.AcceptsTab = true;
            this.txtEventId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventId.Location = new System.Drawing.Point(375, 253);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(100, 35);
            this.txtEventId.TabIndex = 1;
            // 
            // txtCustId
            // 
            this.txtCustId.AcceptsTab = true;
            this.txtCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(375, 162);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(100, 35);
            this.txtCustId.TabIndex = 0;
            // 
            // btnSubmitCustomer
            // 
            this.btnSubmitCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitCustomer.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCustomer.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitCustomer.Location = new System.Drawing.Point(163, 317);
            this.btnSubmitCustomer.Name = "btnSubmitCustomer";
            this.btnSubmitCustomer.Size = new System.Drawing.Size(312, 44);
            this.btnSubmitCustomer.TabIndex = 10;
            this.btnSubmitCustomer.Text = "CREATE RESERVATION";
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
            this.btnBackToCustomerOptions.TabIndex = 11;
            this.btnBackToCustomerOptions.Text = "Back";
            this.btnBackToCustomerOptions.UseVisualStyleBackColor = false;
            this.btnBackToCustomerOptions.Click += new System.EventHandler(this.btnBackToCustomerOptions_Click);
            // 
            // lblSuccessMsg
            // 
            this.lblSuccessMsg.AutoSize = true;
            this.lblSuccessMsg.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuccessMsg.Location = new System.Drawing.Point(343, 633);
            this.lblSuccessMsg.Name = "lblSuccessMsg";
            this.lblSuccessMsg.Size = new System.Drawing.Size(212, 46);
            this.lblSuccessMsg.TabIndex = 12;
            this.lblSuccessMsg.Text = "SuccessMsgf";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 13;
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            this.aboutEventieioToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutEventieioToolStripMenuItem.Text = "About Eventie";
            this.aboutEventieioToolStripMenuItem.Click += new System.EventHandler(this.aboutEventieioToolStripMenuItem_Click);
            // 
            // progress
            // 
            this.progress.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.progress.Location = new System.Drawing.Point(80, 406);
            this.progress.MarqueeAnimationSpeed = 15;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(475, 13);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 15;
            // 
            // RSVPForEventScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblSuccessMsg);
            this.Controls.Add(this.btnBackToCustomerOptions);
            this.Controls.Add(this.btnSubmitCustomer);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.txtEventId);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.txtEventList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtCustList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1214, 738);
            this.MinimumSize = new System.Drawing.Size(1214, 738);
            this.Name = "RSVPForEventScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Reservation";
            this.Load += new System.EventHandler(this.RSVPForEventScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustList;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventList;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Button btnSubmitCustomer;
        private System.Windows.Forms.Button btnBackToCustomerOptions;
        private System.Windows.Forms.Label lblSuccessMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEventieioToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progress;
    }
}