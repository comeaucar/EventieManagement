namespace EventieManagement
{
    partial class AddEventScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventScreen));
            this.lblAddEvent = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMaxAttendees = new System.Windows.Forms.Label();
            this.btnBackToEventOptions = new System.Windows.Forms.Button();
            this.btnSubmitEvent = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventVenue = new System.Windows.Forms.TextBox();
            this.dateTimePick = new System.Windows.Forms.DateTimePicker();
            this.numMaxAttend = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEventieioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lblSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAttend)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddEvent
            // 
            this.lblAddEvent.AutoSize = true;
            this.lblAddEvent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddEvent.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEvent.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAddEvent.Location = new System.Drawing.Point(456, 37);
            this.lblAddEvent.Name = "lblAddEvent";
            this.lblAddEvent.Size = new System.Drawing.Size(301, 97);
            this.lblAddEvent.TabIndex = 13;
            this.lblAddEvent.Text = "Add Event";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventName.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.Lavender;
            this.lblEventName.Location = new System.Drawing.Point(341, 172);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(271, 63);
            this.lblEventName.TabIndex = 23;
            this.lblEventName.Text = "Event Name";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVenue.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.ForeColor = System.Drawing.Color.Lavender;
            this.lblVenue.Location = new System.Drawing.Point(331, 243);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(281, 63);
            this.lblVenue.TabIndex = 33;
            this.lblVenue.Text = "Event Venue";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Lavender;
            this.lblDate.Location = new System.Drawing.Point(363, 316);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(249, 63);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Event Date";
            // 
            // lblMaxAttendees
            // 
            this.lblMaxAttendees.AutoSize = true;
            this.lblMaxAttendees.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaxAttendees.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAttendees.ForeColor = System.Drawing.Color.Lavender;
            this.lblMaxAttendees.Location = new System.Drawing.Point(281, 383);
            this.lblMaxAttendees.Name = "lblMaxAttendees";
            this.lblMaxAttendees.Size = new System.Drawing.Size(331, 63);
            this.lblMaxAttendees.TabIndex = 5;
            this.lblMaxAttendees.Text = "Max Attendees";
            // 
            // btnBackToEventOptions
            // 
            this.btnBackToEventOptions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackToEventOptions.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToEventOptions.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBackToEventOptions.Location = new System.Drawing.Point(12, 633);
            this.btnBackToEventOptions.Name = "btnBackToEventOptions";
            this.btnBackToEventOptions.Size = new System.Drawing.Size(99, 54);
            this.btnBackToEventOptions.TabIndex = 6;
            this.btnBackToEventOptions.Text = "Back";
            this.btnBackToEventOptions.UseVisualStyleBackColor = false;
            this.btnBackToEventOptions.Click += new System.EventHandler(this.btnBackToEventOptions_Click);
            // 
            // btnSubmitEvent
            // 
            this.btnSubmitEvent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitEvent.Font = new System.Drawing.Font("Eras Bold ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEvent.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitEvent.Location = new System.Drawing.Point(543, 489);
            this.btnSubmitEvent.Name = "btnSubmitEvent";
            this.btnSubmitEvent.Size = new System.Drawing.Size(169, 50);
            this.btnSubmitEvent.TabIndex = 7;
            this.btnSubmitEvent.Text = "SUBMIT";
            this.btnSubmitEvent.UseVisualStyleBackColor = false;
            this.btnSubmitEvent.Click += new System.EventHandler(this.btnSubmitEvent_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(643, 198);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(165, 29);
            this.txtEventName.TabIndex = 0;
            // 
            // txtEventVenue
            // 
            this.txtEventVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventVenue.Location = new System.Drawing.Point(643, 269);
            this.txtEventVenue.Name = "txtEventVenue";
            this.txtEventVenue.Size = new System.Drawing.Size(165, 29);
            this.txtEventVenue.TabIndex = 1;
            // 
            // dateTimePick
            // 
            this.dateTimePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePick.Location = new System.Drawing.Point(643, 341);
            this.dateTimePick.MaxDate = new System.DateTime(3050, 12, 31, 0, 0, 0, 0);
            this.dateTimePick.MinDate = new System.DateTime(2020, 11, 26, 0, 0, 0, 0);
            this.dateTimePick.Name = "dateTimePick";
            this.dateTimePick.Size = new System.Drawing.Size(200, 29);
            this.dateTimePick.TabIndex = 2;
            this.dateTimePick.ValueChanged += new System.EventHandler(this.dateTimePick_ValueChanged);
            // 
            // numMaxAttend
            // 
            this.numMaxAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxAttend.Location = new System.Drawing.Point(643, 410);
            this.numMaxAttend.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMaxAttend.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxAttend.Name = "numMaxAttend";
            this.numMaxAttend.Size = new System.Drawing.Size(120, 29);
            this.numMaxAttend.TabIndex = 3;
            this.numMaxAttend.ThousandsSeparator = true;
            this.numMaxAttend.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.progress.Location = new System.Drawing.Point(396, 560);
            this.progress.MarqueeAnimationSpeed = 15;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(475, 13);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 14;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSuccess.Font = new System.Drawing.Font("Eras Bold ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblSuccess.Location = new System.Drawing.Point(357, 633);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 40);
            this.lblSuccess.TabIndex = 15;
            // 
            // AddEventScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.numMaxAttend);
            this.Controls.Add(this.dateTimePick);
            this.Controls.Add(this.txtEventVenue);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnSubmitEvent);
            this.Controls.Add(this.btnBackToEventOptions);
            this.Controls.Add(this.lblMaxAttendees);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblAddEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1214, 738);
            this.MinimumSize = new System.Drawing.Size(1214, 738);
            this.Name = "AddEventScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.AddEventScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAttend)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEvent;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMaxAttendees;
        private System.Windows.Forms.Button btnBackToEventOptions;
        private System.Windows.Forms.Button btnSubmitEvent;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventVenue;
        private System.Windows.Forms.DateTimePicker dateTimePick;
        private System.Windows.Forms.NumericUpDown numMaxAttend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEventieioToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lblSuccess;
    }
}