namespace hotel_managerment
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelLine = new System.Windows.Forms.Panel();
            this.panelActive = new System.Windows.Forms.Panel();
            this.lbRoomAvialable = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbHome = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNextFood = new System.Windows.Forms.Button();
            this.lbGuest = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDatePicker.CustomFormat = "MM-dd-yyyy";
            this.entryDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryDatePicker.Location = new System.Drawing.Point(86, -344);
            this.entryDatePicker.Margin = new System.Windows.Forms.Padding(16);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(468, 48);
            this.entryDatePicker.TabIndex = 36;
            this.entryDatePicker.Value = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2294, 56);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(186, 52);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminToolStripMenuItem.Image")));
            this.adminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(291, 56);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // PanelLine
            // 
            this.PanelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLine.BackColor = System.Drawing.Color.DimGray;
            this.PanelLine.Location = new System.Drawing.Point(53, 144);
            this.PanelLine.Name = "PanelLine";
            this.PanelLine.Size = new System.Drawing.Size(2212, 10);
            this.PanelLine.TabIndex = 40;
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.Blue;
            this.panelActive.Location = new System.Drawing.Point(53, 144);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(106, 10);
            this.panelActive.TabIndex = 41;
            // 
            // lbRoomAvialable
            // 
            this.lbRoomAvialable.AutoSize = true;
            this.lbRoomAvialable.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomAvialable.Location = new System.Drawing.Point(556, 90);
            this.lbRoomAvialable.Name = "lbRoomAvialable";
            this.lbRoomAvialable.Size = new System.Drawing.Size(288, 48);
            this.lbRoomAvialable.TabIndex = 44;
            this.lbRoomAvialable.Text = "Room Avialable";
            this.lbRoomAvialable.Click += new System.EventHandler(this.lbRoomAvialable_Click);
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelHome.Controls.Add(this.button2);
            this.panelHome.Controls.Add(this.btnBook);
            this.panelHome.Location = new System.Drawing.Point(53, 197);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(2174, 937);
            this.panelHome.TabIndex = 43;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.hfg_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::hotel_managerment.Properties.Resources.home2;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(1207, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(560, 473);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start Booking";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBook.BackgroundImage = global::hotel_managerment.Properties.Resources.home2;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.Red;
            this.btnBook.Location = new System.Drawing.Point(340, 210);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(560, 473);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Start Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(244, 90);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(219, 48);
            this.lbRegister.TabIndex = 45;
            this.lbRegister.Text = "Reservation";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.Location = new System.Drawing.Point(56, 93);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(120, 48);
            this.lbHome.TabIndex = 46;
            this.lbHome.Text = "Home";
            this.lbHome.Click += new System.EventHandler(this.lbHome_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(2095, 71);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 67);
            this.btnNext.TabIndex = 47;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNextFood
            // 
            this.btnNextFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFood.Location = new System.Drawing.Point(2150, 71);
            this.btnNextFood.Name = "btnNextFood";
            this.btnNextFood.Size = new System.Drawing.Size(132, 67);
            this.btnNextFood.TabIndex = 48;
            this.btnNextFood.Text = "Next";
            this.btnNextFood.UseVisualStyleBackColor = false;
            this.btnNextFood.Click += new System.EventHandler(this.btnNextFood_Click);
            // 
            // lbGuest
            // 
            this.lbGuest.AutoSize = true;
            this.lbGuest.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuest.Location = new System.Drawing.Point(916, 93);
            this.lbGuest.Name = "lbGuest";
            this.lbGuest.Size = new System.Drawing.Size(193, 48);
            this.lbGuest.TabIndex = 50;
            this.lbGuest.Text = "Guest List";
            this.lbGuest.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2294, 1167);
            this.Controls.Add(this.lbGuest);
            this.Controls.Add(this.btnNextFood);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lbRoomAvialable);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelActive);
            this.Controls.Add(this.PanelLine);
            this.Controls.Add(this.entryDatePicker);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel PanelLine;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Label lbRoomAvialable;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNextFood;
        private System.Windows.Forms.Label lbGuest;
    }
}

