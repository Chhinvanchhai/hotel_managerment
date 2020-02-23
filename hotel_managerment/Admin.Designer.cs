namespace hotel_managerment
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservesRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aviableRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adMinPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1949, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRoomsToolStripMenuItem
            // 
            this.addRoomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomsToolStripMenuItem1,
            this.reservesRoomToolStripMenuItem,
            this.aviableRoomToolStripMenuItem});
            this.addRoomsToolStripMenuItem.Name = "addRoomsToolStripMenuItem";
            this.addRoomsToolStripMenuItem.Size = new System.Drawing.Size(120, 41);
            this.addRoomsToolStripMenuItem.Text = "Rooms";
            this.addRoomsToolStripMenuItem.Click += new System.EventHandler(this.addRoomsToolStripMenuItem_Click);
            // 
            // addRoomsToolStripMenuItem1
            // 
            this.addRoomsToolStripMenuItem1.Name = "addRoomsToolStripMenuItem1";
            this.addRoomsToolStripMenuItem1.Size = new System.Drawing.Size(345, 48);
            this.addRoomsToolStripMenuItem1.Text = "Add Rooms";
            this.addRoomsToolStripMenuItem1.Click += new System.EventHandler(this.addRoomsToolStripMenuItem1_Click);
            // 
            // reservesRoomToolStripMenuItem
            // 
            this.reservesRoomToolStripMenuItem.Name = "reservesRoomToolStripMenuItem";
            this.reservesRoomToolStripMenuItem.Size = new System.Drawing.Size(345, 48);
            this.reservesRoomToolStripMenuItem.Text = "Reserves Room";
            // 
            // aviableRoomToolStripMenuItem
            // 
            this.aviableRoomToolStripMenuItem.Name = "aviableRoomToolStripMenuItem";
            this.aviableRoomToolStripMenuItem.Size = new System.Drawing.Size(345, 48);
            this.aviableRoomToolStripMenuItem.Text = "Aviable Room";
            this.aviableRoomToolStripMenuItem.Click += new System.EventHandler(this.aviableRoomToolStripMenuItem_Click);
            // 
            // adMinPanel
            // 
            this.adMinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adMinPanel.Location = new System.Drawing.Point(0, 45);
            this.adMinPanel.Name = "adMinPanel";
            this.adMinPanel.Size = new System.Drawing.Size(1949, 1071);
            this.adMinPanel.TabIndex = 1;
            this.adMinPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adMinPanel_Paint);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1949, 1116);
            this.Controls.Add(this.adMinPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRoomsToolStripMenuItem;
        private System.Windows.Forms.Panel adMinPanel;
        private System.Windows.Forms.ToolStripMenuItem addRoomsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reservesRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aviableRoomToolStripMenuItem;
    }
}