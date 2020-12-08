namespace EventieManagement
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEventieioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomerOptions = new System.Windows.Forms.Button();
            this.btnEventOptions = new System.Windows.Forms.Button();
            this.btnReservationOptions = new System.Windows.Forms.Button();
            this.lblEventie = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutEventieioToolStripMenuItem
            // 
            this.aboutEventieioToolStripMenuItem.Name = "aboutEventieioToolStripMenuItem";
            this.aboutEventieioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutEventieioToolStripMenuItem.Text = "About Eventie";
            this.aboutEventieioToolStripMenuItem.Click += new System.EventHandler(this.aboutEventieioToolStripMenuItem_Click);
            // 
            // btnCustomerOptions
            // 
            this.btnCustomerOptions.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnCustomerOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomerOptions.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnCustomerOptions.Font = new System.Drawing.Font("Eras Bold ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerOptions.ForeColor = System.Drawing.Color.Plum;
            this.btnCustomerOptions.Location = new System.Drawing.Point(290, 243);
            this.btnCustomerOptions.Name = "btnCustomerOptions";
            this.btnCustomerOptions.Size = new System.Drawing.Size(635, 139);
            this.btnCustomerOptions.TabIndex = 1;
            this.btnCustomerOptions.Text = "CUSTOMER OPTIONS";
            this.btnCustomerOptions.UseVisualStyleBackColor = false;
            this.btnCustomerOptions.Click += new System.EventHandler(this.btnCustomerOptions_Click);
            // 
            // btnEventOptions
            // 
            this.btnEventOptions.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnEventOptions.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnEventOptions.Font = new System.Drawing.Font("Eras Bold ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventOptions.ForeColor = System.Drawing.Color.LightCoral;
            this.btnEventOptions.Location = new System.Drawing.Point(290, 388);
            this.btnEventOptions.Name = "btnEventOptions";
            this.btnEventOptions.Size = new System.Drawing.Size(635, 139);
            this.btnEventOptions.TabIndex = 2;
            this.btnEventOptions.Text = "EVENT OPTIONS";
            this.btnEventOptions.UseVisualStyleBackColor = false;
            this.btnEventOptions.Click += new System.EventHandler(this.btnEventOptions_Click);
            // 
            // btnReservationOptions
            // 
            this.btnReservationOptions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReservationOptions.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnReservationOptions.FlatAppearance.BorderSize = 3;
            this.btnReservationOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReservationOptions.Font = new System.Drawing.Font("Eras Bold ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationOptions.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnReservationOptions.Location = new System.Drawing.Point(290, 533);
            this.btnReservationOptions.Name = "btnReservationOptions";
            this.btnReservationOptions.Size = new System.Drawing.Size(635, 139);
            this.btnReservationOptions.TabIndex = 3;
            this.btnReservationOptions.Text = "RESERVATION OPTIONS";
            this.btnReservationOptions.UseVisualStyleBackColor = false;
            this.btnReservationOptions.Click += new System.EventHandler(this.btnReservationOptions_Click);
            // 
            // lblEventie
            // 
            this.lblEventie.AutoSize = true;
            this.lblEventie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEventie.Font = new System.Drawing.Font("Harlow Solid Italic", 99.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventie.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblEventie.Location = new System.Drawing.Point(351, 48);
            this.lblEventie.Name = "lblEventie";
            this.lblEventie.Size = new System.Drawing.Size(468, 168);
            this.lblEventie.TabIndex = 4;
            this.lblEventie.Text = "Eventie";
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.lblEventie);
            this.Controls.Add(this.btnReservationOptions);
            this.Controls.Add(this.btnEventOptions);
            this.Controls.Add(this.btnCustomerOptions);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1214, 738);
            this.MinimumSize = new System.Drawing.Size(1214, 738);
            this.Name = "MainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventie";
            this.Load += new System.EventHandler(this.MainMenuScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCustomerOptions;
        private System.Windows.Forms.Button btnEventOptions;
        private System.Windows.Forms.Button btnReservationOptions;
        private System.Windows.Forms.Label lblEventie;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEventieioToolStripMenuItem;
    }
}