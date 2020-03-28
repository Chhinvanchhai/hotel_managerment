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
    public partial class showGuestList : UserControl
    {
        dbconnection db = new dbconnection();
        public showGuestList()
        {
            InitializeComponent();
        }

        private void showGuestList_Load(object sender, EventArgs e)
        {
            var sql = "select "
                        +"g.id,g.name,g.address,g.email,g.phone,"+
                        "r.check_in_date,check_out_date,"+
                        "f.food,"+
                        "ro.id"+
                        " from Guest g"+
                        " join Reservation r on g.id = r.guest_id"+
                        " join Food f on f.id = r.food_id"+
                        " join Room ro on r.room_id = ro.id";
            var data = db.GetData(sql);
            while (data.Read())
            {
                ListViewItem list = lsGuestList.Items.Add(data[0].ToString());
                list.SubItems.Add(data[1].ToString());
                list.SubItems.Add(data[2].ToString());
                list.SubItems.Add(data[3].ToString());
                list.SubItems.Add(data[4].ToString());
                list.SubItems.Add(data[5].ToString());
                list.SubItems.Add(data[6].ToString());
                list.SubItems.Add(data[7].ToString());
                list.SubItems.Add(data[8].ToString());
            }
            data.Close();
        }

        private void lsGuestList_Click(object sender, EventArgs e)
        {
            var list = lsGuestList.SelectedItems;
            txtGuestId.Text = list[0].SubItems[0].Text;


        }

        private void lsGuestList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntCheckGuest_Click(object sender, EventArgs e)
        {
            if (txtGuestId.Text != "")
            {
                FormDetial fd = new FormDetial();
                fd.Tag = txtGuestId.Text;
                fd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select the list below to check detial!");
            }
           
           
        }
    }
}
