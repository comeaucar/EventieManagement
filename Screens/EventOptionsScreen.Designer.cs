namespace EventieManagement
{
    partial class EventOptionsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventOptionsScreen));
            this.lblCustomerOptions = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnViewEvents = new System.Windows.Forms.Button();
            this.btnViewSpecEvent = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEventieioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerOptions
            // 
            this.lblCustomerOptions.AutoSize = true;
            this.lblCustomerOptions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCustomerOptions.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerOptions.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblCustomerOptions.Location = new System.Drawing.Point(382, 42);
            this.lblCustomerOptions.Name = "lblCustomerOptions";
            this.lblCustomerOptions.Size = new System.Drawing.Size(407, 97);
            this.lblCustomerOptions.TabIndex = 6;
            this.lblCustomerOptions.Text = "Event Options";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEvent.Font = new System.Drawing.Font("Eras Bold ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.ForeColor = System.Drawing.Color.LightCoral;
            this.btnAddEvent.Location = new System.Drawing.Point(249, 202);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(692, 91);
            this.btnAddEvent.TabIndex = 7;
            this.btnAddEvent.Text = "ADD EVENT";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnViewEvents
            // 
            this.btnViewEvents.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewEvents.Font = new System.Drawing.Font("Eras Bold ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEvents.ForeColor = System.Drawing.Color.LightCoral;
            this.btnViewEvents.Location = new System.Drawing.Point(249, 321);
            this.btnViewEvents.Name = "btnViewEvents";
            this.btnViewEvents.Size = new System.Drawing.Size(692, 91);
            this.btnViewEvents.TabIndex = 8;
            this.btnViewEvents.Text = "VIEW ALL EVENTS";
            this.btnViewEvents.UseVisualStyleBackColor = false;
            this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click);
            // 
            // btnViewSpecEvent
            // 
            this.btnViewSpecEvent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewSpecEvent.Font = new System.Drawing.Font("Eras Bold ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSpecEvent.ForeColor = System.Drawing.Color.LightCoral;
            this.btnViewSpecEvent.Location = new System.Drawing.Point(249, 442);
            this.btnViewSpecEvent.Name = "btnViewSpecEvent";
            this.btnViewSpecEvent.Size = new System.Drawing.Size(692, 91);
            this.btnViewSpecEvent.TabIndex = 9;
            this.btnViewSpecEvent.Text = "SEARCH EVENT";
            this.btnViewSpecEvent.UseVisualStyleBackColor = false;
            this.btnViewSpecEvent.Click += new System.EventHandler(this.btnViewSpecEvent_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackToMain.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBackToMain.Location = new System.Drawing.Point(12, 630);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(123, 57);
            this.btnBackToMain.TabIndex = 10;
            this.btnBackToMain.Text = "Back";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
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
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // EventOptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnViewSpecEvent);
            this.Controls.Add(this.btnViewEvents);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.lblCustomerOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1214, 738);
            this.MinimumSize = new System.Drawing.Size(1214, 738);
            this.Name = "EventOptionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Options";
            this.Load += new System.EventHandler(this.EventOptionsScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerOptions;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnViewEvents;
        private System.Windows.Forms.Button btnViewSpecEvent;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEventieioToolStripMenuItem;
    }
}