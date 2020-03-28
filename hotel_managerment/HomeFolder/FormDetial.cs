using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_managerment.HomeFolder
{
    public partial class FormDetial : Form
    {
        dbconnection db = new dbconnection();
        public FormDetial()
        {
            InitializeComponent();
        }

        private void FormDetial_Load(object sender, EventArgs e)
        {
         
            var sqlGuest   = "SELECT * FROM Guest Where id ='"+ this.Tag.ToString() + "'";
            var slqReserve = "select * from Reservation where guest_id = '" + this.Tag.ToString() +"'";
            var sqlFood = "select * from Food  where id=(select food_id from Reservation where guest_id ='" + this.Tag.ToString() + "')";
            var dataGuest = db.GetData(sqlGuest);
            while (dataGuest.Read())
            {
                ListViewItem list = listGuest.Items.Add(dataGuest[0].ToString());
                list.SubItems.Add(dataGuest[1].ToString());
                list.SubItems.Add(dataGuest[2].ToString());
                list.SubItems.Add(dataGuest[3].ToString());
                list.SubItems.Add(dataGuest[4].ToString());
                list.SubItems.Add(dataGuest[5].ToString());

            }
            dataGuest.Close();

            var dataReservation = db.GetData(slqReserve);
            while (dataReservation.Read())
            {
                ListViewItem list = ListReservation.Items.Add(dataReservation[0].ToString());
                list.SubItems.Add(dataReservation[1].ToString());
                list.SubItems.Add(dataReservation[2].ToString());
                list.SubItems.Add(dataReservation[3].ToString());
                list.SubItems.Add(dataReservation[4].ToString());
                list.SubItems.Add(dataReservation[5].ToString());
          
            }
            dataReservation.Close();

            var dataFood = db.GetData(sqlFood);
            while (dataFood.Read())
            {
                ListViewItem list = listFood.Items.Add(dataFood[0].ToString());
                list.SubItems.Add(dataFood[1].ToString());
                list.SubItems.Add(dataFood[2].ToString());
           
           
           
            }
            dataFood.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var get_food_id = "SELECT food_id from Reservation where guest_id='" + this.Tag.ToString() + "'";
            var food_id = db.GetId(get_food_id);
            MessageBox.Show(food_id.ToString());
        }
    }
}
