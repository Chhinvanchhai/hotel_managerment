namespace hotel_managerment.AdminFolder
{
    partial class AviableRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsAviabelRoom = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Floors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.air_conditioanal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room_numner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Aviable";
            // 
            // lsAviabelRoom
            // 
            this.lsAviabelRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsAviabelRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Floors,
            this.Bed,
            this.Price,
            this.air_conditioanal,
            this.Status,
            this.room_numner});
            this.lsAviabelRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsAviabelRoom.FullRowSelect = true;
            this.lsAviabelRoom.HideSelection = false;
            this.lsAviabelRoom.Location = new System.Drawing.Point(70, 196);
            this.lsAviabelRoom.Name = "lsAviabelRoom";
            this.lsAviabelRoom.Size = new System.Drawing.Size(1858, 861);
            this.lsAviabelRoom.TabIndex = 17;
            this.lsAviabelRoom.UseCompatibleStateImageBehavior = false;
            this.lsAviabelRoom.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // Floors
            // 
            this.Floors.Text = "Floors";
            this.Floors.Width = 120;
            // 
            // Bed
            // 
            this.Bed.Text = "Bed";
            this.Bed.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 300;
            // 
            // air_conditioanal
            // 
            this.air_conditioanal.Text = "Air Conditional";
            this.air_conditioanal.Width = 200;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 200;
            // 
            // room_numner
            // 
            this.room_numner.Text = "Room Number";
            this.room_numner.Width = 120;
            // 
            // AviableRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsAviabelRoom);
            this.Controls.Add(this.label1);
            this.Name = "AviableRoom";
            this.Size = new System.Drawing.Size(2011, 1157);
            this.Load += new System.EventHandler(this.AviableRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsAviabelRoom;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Floors;
        private System.Windows.Forms.ColumnHeader Bed;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader air_conditioanal;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader room_numner;
    }
}
