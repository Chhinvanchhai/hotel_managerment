using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_managerment.HomeFolder
{
    public partial class reservation : UserControl
    {
        dbconnection db = new dbconnection();
        public reservation()
        {
            InitializeComponent();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
        

        }
        private bool Validate(String value)
        {
            if (value == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertReserve()
        {
            if (Validate(adult_num.Text) || Validate(chlid_num.Text) || Validate(check_id.Value.ToString()) || Validate(check_out.Value.ToString()))
            {
                MessageBox.Show("Please fill the field");
                return false;
            }
            var sql = "insert into Reservation(guest_id,room_id,check_in_date,check_out_date)" +
                " Values('"+adult_num.Text+"','"+chlid_num.Text+"','" + check_id.Value.ToString() + "','" + check_out.Value.ToString() + "')";
            if (!db.execute(sql))
            {
                MessageBox.Show("Failed to insert!");
                return false;
            }
            else
            {
                 return true;
            }

        }

        private void reservation_Load(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Room WHERE status = 'Available'";
            var data = db.GetData(sql);
            MessageBox.Show(Tag.ToString());
            while (data.Read())
            {
                ListViewItem list = lsRoom.Items.Add(data[0].ToString());
                list.SubItems.Add(data[8].ToString());
                list.SubItems.Add(data[4].ToString());
                list.SubItems.Add(data[5].ToString());
                list.SubItems.Add(data[7].ToString());
                list.SubItems.Add(data[7].ToString());
                list.SubItems.Add(data[8].ToString());

            }

        }

        private void lbShowAvaiableRoom_Click(object sender, EventArgs e)
        {
            var list = lsRoom.SelectedItems;
            room_id.Text = list[0].SubItems[0].Text;
        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
