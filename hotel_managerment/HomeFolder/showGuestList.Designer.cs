namespace hotel_managerment.HomeFolder
{
    partial class showGuestList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lsGuestList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guestAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.check_in = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Check_out = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Orderfood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bntCheckGuest = new System.Windows.Forms.Button();
            this.btnCheckFood = new System.Windows.Forms.Button();
            this.btnCheckRoom = new System.Windows.Forms.Button();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.txtRooId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1133, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest List";
            // 
            // lsGuestList
            // 
            this.lsGuestList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsGuestList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.GuestName,
            this.guestAddress,
            this.email,
            this.phone,
            this.check_in,
            this.Check_out,
            this.Orderfood,
            this.RoomNumber});
            this.lsGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsGuestList.FullRowSelect = true;
            this.lsGuestList.HideSelection = false;
            this.lsGuestList.Location = new System.Drawing.Point(61, 304);
            this.lsGuestList.Name = "lsGuestList";
            this.lsGuestList.Size = new System.Drawing.Size(2361, 1052);
            this.lsGuestList.TabIndex = 32;
            this.lsGuestList.UseCompatibleStateImageBehavior = false;
            this.lsGuestList.View = System.Windows.Forms.View.Details;
            this.lsGuestList.SelectedIndexChanged += new System.EventHandler(this.lsGuestList_SelectedIndexChanged);
            this.lsGuestList.Click += new System.EventHandler(this.lsGuestList_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // GuestName
            // 
            this.GuestName.Text = "Name";
            this.GuestName.Width = 200;
            // 
            // guestAddress
            // 
            this.guestAddress.Text = "Address";
            this.guestAddress.Width = 300;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 200;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 120;
            // 
            // check_in
            // 
            this.check_in.Text = "Check In";
            this.check_in.Width = 100;
            // 
            // Check_out
            // 
            this.Check_out.Text = "Check Out";
            this.Check_out.Width = 100;
            // 
            // Orderfood
            // 
            this.Orderfood.Text = "Order Food";
            this.Orderfood.Width = 100;
            // 
            // RoomNumber
            // 
            this.RoomNumber.Text = "Room No";
            this.RoomNumber.Width = 100;
            // 
            // bntCheckGuest
            // 
            this.bntCheckGuest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bntCheckGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCheckGuest.Location = new System.Drawing.Point(1121, 185);
            this.bntCheckGuest.Name = "bntCheckGuest";
            this.bntCheckGuest.Size = new System.Drawing.Size(375, 64);
            this.bntCheckGuest.TabIndex = 33;
            this.bntCheckGuest.Text = "Check Guest Detail";
            this.bntCheckGuest.UseVisualStyleBackColor = true;
            this.bntCheckGuest.Click += new System.EventHandler(this.bntCheckGuest_Click);
            // 
            // btnCheckFood
            // 
            this.btnCheckFood.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCheckFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckFood.Location = new System.Drawing.Point(1971, 185);
            this.btnCheckFood.Name = "btnCheckFood";
            this.btnCheckFood.Size = new System.Drawing.Size(451, 64);
            this.btnCheckFood.TabIndex = 34;
            this.btnCheckFood.Text = "Check Food Detial";
            this.btnCheckFood.UseVisualStyleBackColor = true;
            // 
            // btnCheckRoom
            // 
            this.btnCheckRoom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCheckRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckRoom.Location = new System.Drawing.Point(1514, 185);
            this.btnCheckRoom.Name = "btnCheckRoom";
            this.btnCheckRoom.Size = new System.Drawing.Size(432, 64);
            this.btnCheckRoom.TabIndex = 35;
            this.btnCheckRoom.Text = "Check Room Detail";
            this.btnCheckRoom.UseVisualStyleBackColor = true;
            // 
            // txtGuestId
            // 
            this.txtGuestId.Location = new System.Drawing.Point(352, 113);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(100, 35);
            this.txtGuestId.TabIndex = 36;
            this.txtGuestId.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtFoodId
            // 
            this.txtFoodId.Location = new System.Drawing.Point(725, 113);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(100, 35);
            this.txtFoodId.TabIndex = 38;
            this.txtFoodId.Visible = false;
            // 
            // txtRooId
            // 
            this.txtRooId.Location = new System.Drawing.Point(540, 113);
            this.txtRooId.Name = "txtRooId";
            this.txtRooId.Size = new System.Drawing.Size(100, 35);
            this.txtRooId.TabIndex = 39;
            this.txtRooId.Visible = false;
            // 
            // showGuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRooId);
            this.Controls.Add(this.txtFoodId);
            this.Controls.Add(this.txtGuestId);
            this.Controls.Add(this.btnCheckRoom);
            this.Controls.Add(this.btnCheckFood);
            this.Controls.Add(this.bntCheckGuest);
            this.Controls.Add(this.lsGuestList);
            this.Controls.Add(this.label1);
            this.Name = "showGuestList";
            this.Size = new System.Drawing.Size(2487, 1416);
            this.Load += new System.EventHandler(this.showGuestList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsGuestList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader GuestName;
        private System.Windows.Forms.ColumnHeader guestAddress;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader check_in;
        private System.Windows.Forms.ColumnHeader Check_out;
        private System.Windows.Forms.ColumnHeader Orderfood;
        private System.Windows.Forms.ColumnHeader RoomNumber;
        private System.Windows.Forms.Button bntCheckGuest;
        private System.Windows.Forms.Button btnCheckFood;
        private System.Windows.Forms.Button btnCheckRoom;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.TextBox txtRooId;
    }
}
