namespace hotel_managerment.HomeFolder
{
    partial class reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservation));
            this.panelRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.chlid_num = new System.Windows.Forms.ComboBox();
            this.adult_num = new System.Windows.Forms.ComboBox();
            this.check_out = new System.Windows.Forms.DateTimePicker();
            this.check_id = new System.Windows.Forms.DateTimePicker();
            this.lsRoom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.beds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.room_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.cmbFood);
            this.panelRight.Controls.Add(this.chlid_num);
            this.panelRight.Controls.Add(this.adult_num);
            this.panelRight.Controls.Add(this.check_out);
            this.panelRight.Controls.Add(this.check_id);
            this.panelRight.Controls.Add(this.lsRoom);
            this.panelRight.Controls.Add(this.pictureBox1);
            this.panelRight.Controls.Add(this.room_id);
            this.panelRight.Controls.Add(this.label10);
            this.panelRight.Controls.Add(this.label11);
            this.panelRight.Controls.Add(this.label12);
            this.panelRight.Controls.Add(this.label13);
            this.panelRight.Controls.Add(this.label14);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Location = new System.Drawing.Point(3, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(2081, 1242);
            this.panelRight.TabIndex = 2;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1190, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 48);
            this.label1.TabIndex = 38;
            this.label1.Text = "Foods";
            // 
            // cmbFood
            // 
            this.cmbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Items.AddRange(new object[] {
            "Breakfast($5)",
            "Breakfast and lunch ($10)",
            "None"});
            this.cmbFood.Location = new System.Drawing.Point(1332, 136);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(497, 56);
            this.cmbFood.TabIndex = 37;
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
            // 
            // chlid_num
            // 
            this.chlid_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlid_num.FormattingEnabled = true;
            this.chlid_num.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.chlid_num.Location = new System.Drawing.Point(300, 447);
            this.chlid_num.Name = "chlid_num";
            this.chlid_num.Size = new System.Drawing.Size(842, 56);
            this.chlid_num.TabIndex = 36;
            // 
            // adult_num
            // 
            this.adult_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adult_num.FormattingEnabled = true;
            this.adult_num.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.adult_num.Location = new System.Drawing.Point(300, 345);
            this.adult_num.Name = "adult_num";
            this.adult_num.Size = new System.Drawing.Size(842, 56);
            this.adult_num.TabIndex = 35;
            // 
            // check_out
            // 
            this.check_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out.Location = new System.Drawing.Point(300, 247);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(842, 55);
            this.check_out.TabIndex = 34;
            // 
            // check_id
            // 
            this.check_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_id.Location = new System.Drawing.Point(300, 139);
            this.check_id.Name = "check_id";
            this.check_id.Size = new System.Drawing.Size(842, 55);
            this.check_id.TabIndex = 33;
            // 
            // lsRoom
            // 
            this.lsRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.RoomNumber,
            this.RoomFloor,
            this.beds,
            this.Status});
            this.lsRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsRoom.FullRowSelect = true;
            this.lsRoom.HideSelection = false;
            this.lsRoom.Location = new System.Drawing.Point(50, 615);
            this.lsRoom.Name = "lsRoom";
            this.lsRoom.Size = new System.Drawing.Size(2007, 607);
            this.lsRoom.TabIndex = 31;
            this.lsRoom.UseCompatibleStateImageBehavior = false;
            this.lsRoom.View = System.Windows.Forms.View.Details;
            this.lsRoom.Click += new System.EventHandler(this.lbShowAvaiableRoom_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // RoomNumber
            // 
            this.RoomNumber.Text = "#Room Number";
            this.RoomNumber.Width = 100;
            // 
            // RoomFloor
            // 
            this.RoomFloor.Text = "#Floor";
            this.RoomFloor.Width = 100;
            // 
            // beds
            // 
            this.beds.Text = "Beds";
            this.beds.Width = 174;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 257;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1076, 548);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // room_id
            // 
            this.room_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_id.Location = new System.Drawing.Point(298, 548);
            this.room_id.Name = "room_id";
            this.room_id.Size = new System.Drawing.Size(772, 55);
            this.room_id.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 48);
            this.label10.TabIndex = 26;
            this.label10.Text = "Room/Floor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 48);
            this.label11.TabIndex = 24;
            this.label11.Text = "Child No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 48);
            this.label12.TabIndex = 22;
            this.label12.Text = "Adult No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 48);
            this.label13.TabIndex = 20;
            this.label13.Text = "Check Out";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 48);
            this.label14.TabIndex = 18;
            this.label14.Text = "Check In";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(974, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 55);
            this.label7.TabIndex = 17;
            this.label7.Text = "Room Information";
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRight);
            this.Name = "reservation";
            this.Size = new System.Drawing.Size(2081, 1242);
            this.Load += new System.EventHandler(this.reservation_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DateTimePicker check_out;
        private System.Windows.Forms.DateTimePicker check_id;
        private System.Windows.Forms.ListView lsRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader RoomNumber;
        private System.Windows.Forms.ColumnHeader RoomFloor;
        private System.Windows.Forms.ColumnHeader beds;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox room_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox chlid_num;
        private System.Windows.Forms.ComboBox adult_num;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFood;
    }
}
