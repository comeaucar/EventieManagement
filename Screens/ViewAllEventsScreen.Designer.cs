namespace EventieManagement
{
    partial class ViewAllEventsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllEventsScreen));
            this.lblAllCustomers = new System.Windows.Forms.Label();
            this.txtViewAllEvents = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEventVenue = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventId = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEventieioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAllCustomers
            // 
            this.lblAllCustomers.AutoSize = true;
            this.lblAllCustomers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAllCustomers.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCustomers.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAllCustomers.Location = new System.Drawing.Point(417, 24);
            this.lblAllCustomers.Name = "lblAllCustomers";
            this.lblAllCustomers.Size = new System.Drawing.Size(299, 97);
            this.lblAllCustomers.TabIndex = 0;
            this.lblAllCustomers.Text = "All Events";
            // 
            // txtViewAllEvents
            // 
            this.txtViewAllEvents.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtViewAllEvents.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtViewAllEvents.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewAllEvents.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtViewAllEvents.Location = new System.Drawing.Point(119, 232);
            this.txtViewAllEvents.Multiline = true;
            this.txtViewAllEvents.Name = "txtViewAllEvents";
            this.txtViewAllEvents.ReadOnly = true;
            this.txtViewAllEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtViewAllEvents.Size = new System.Drawing.Size(933, 361);
            this.txtViewAllEvents.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBack.Location = new System.Drawing.Point(12, 630);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 57);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEventVenue
            // 
            this.lblEventVenue.AutoSize = true;
            this.lblEventVenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventVenue.Font = new System.Drawing.Font("HP Simplified", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventVenue.ForeColor = System.Drawing.Color.Lavender;
            this.lblEventVenue.Location = new System.Drawing.Point(594, 180);
            this.lblEventVenue.Name = "lblEventVenue";
            this.lblEventVenue.Size = new System.Drawing.Size(218, 49);
            this.lblEventVenue.TabIndex = 10;
            this.lblEventVenue.Text = "Event Venue";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventName.Font = new System.Drawing.Font("HP Simplified", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.Lavender;
            this.lblEventName.Location = new System.Drawing.Point(292, 180);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(211, 49);
            this.lblEventName.TabIndex = 11;
            this.lblEventName.Text = "Event Name";
            // 
            // lblEventId
            // 
            this.lblEventId.AutoSize = true;
            this.lblEventId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventId.Font = new System.Drawing.Font("HP Simplified", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventId.ForeColor = System.Drawing.Color.Lavender;
            this.lblEventId.Location = new System.Drawing.Point(110, 180);
            this.lblEventId.Name = "lblEventId";
            this.lblEventId.Size = new System.Drawing.Size(154, 49);
            this.lblEventId.TabIndex = 12;
            this.lblEventId.Text = "Event ID";
            this.lblEventId.Click += new System.EventHandler(this.label2_Click);
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
            // ViewAllEventsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblEventId);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventVenue);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtViewAllEvents);
            this.Controls.Add(this.lblAllCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1214, 738);
            this.MinimumSize = new System.Drawing.Size(1214, 738);
            this.Name = "ViewAllEventsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Events";
            this.Load += new System.EventHandler(this.ViewAllEventsScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllCustomers;
        private System.Windows.Forms.TextBox txtViewAllEvents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEventVenue;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEventieioToolStripMenuItem;
    }
}