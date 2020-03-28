using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace hotel_managerment.HomeFolder
{
    public partial class GuestRegister : UserControl
    {
        dbconnection db = new dbconnection();
        public GuestRegister()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            reservation rs = new reservation();
            rs.Tag = "12";
            Home hm = new Home();
            hm.AddControll(rs);

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool Validate(String value)
        { 
            if(value == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int InsertGuest()
        {
          
            var sql = "insert into Guest([name],[address],email,city,country,phone)" +
                " Values('" + txtName.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtPhone.Text + "')";
            int guest_id = db.executeId(sql);
            if (guest_id == 0)
            {
                MessageBox.Show("Failed to insert");
            }
            else
            {
                return guest_id;
            }
            return guest_id;
         
        }

        public void insertReserve(int guest_id)
        {
            string[] food_name = cmbFood.Text.Split('-');
            var sql_food = "SELECT id from food where food= '"+food_name[0]+"'";
            var food_id = db.GetId(sql_food);
            var sql = "insert into Reservation(adults,childs,check_in_date,check_out_date,guest_id,room_id,food_id)" +
                " Values('" + adult_num.Text + "','" + chlid_num.Text + "','" + check_id.Value.ToString() + "','" + check_out.Value.ToString() + "','" + guest_id + "','" + room_id.Text + "','"+food_id+"')";
            if (!db.execute(sql))
            {
                MessageBox.Show("Failed to insert!");
            }
            else
            {
                showGuestList list_guest = new showGuestList();
                Home hm = new Home();
                hm.AddControll(list_guest);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text);
        }

        private void GuestRegister_Load(object sender, EventArgs e)
        {
            panelReservation.Visible = false;
            var sql = "SELECT * FROM Room WHERE status = 'Available'";
            var data = db.GetData(sql);
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
            data.Close();
            var sql_food = "SELECT 0 id,'Please select' Food,0 price UNION SELECT * FROM Food";
            var food = db.GetData(sql_food);
            while (food.Read())
            {
                cmbFood.Items.Add(food[1].ToString()+" - $"+food[2]);
            }
            cmbFood.SelectedIndex = 0;
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (Validate(txtName.Text) || Validate(txtAddress.Text) || Validate(txtEmail.Text) || Validate(txtCity.Text) || Validate(txtState.Text) || Validate(txtPhone.Text))
            {
                MessageBox.Show("Please fill the field");
            }
             else
            {
                panelReservation.Visible = true;
                Home hm = new Home();
                panelGuestRegister.Visible = false;
             
            }
        
            
       
        }

        private void btnToConfrim_Click(object sender, EventArgs e)
        {

            if (Validate(adult_num.Text) || Validate(chlid_num.Text) || Validate(check_id.Value.ToString()) || Validate(check_out.Value.ToString()))
            {
                MessageBox.Show("Please fill the field");
            }
            else
            {
                var guest_id = this.InsertGuest();
                this.insertReserve(guest_id);
                showGuestList list_guest = new showGuestList();
                Home hm = new Home();
                hm.AddControll(list_guest);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            panelReservation.Visible = false;
            panelGuestRegister.Visible = true;
            hm.guestPanel();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
        }

        private void lsRoom_MouseClick(object sender, MouseEventArgs e)
        {
            var list = lsRoom.SelectedItems;
            room_id.Text = list[0].SubItems[0].Text;
        }

        private void panelReservation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("let me hsow");
            reservation rs = new reservation();
            Home hm = new Home();
            rs.Show();
        }
    }
}
