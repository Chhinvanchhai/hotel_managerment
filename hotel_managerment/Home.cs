using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_managerment.HomeFolder;

namespace hotel_managerment
{
    public partial class Home : Form
    {
        GuestRegister guest = new GuestRegister();
        reservation reserve = new reservation();
        public Home()
        {
            InitializeComponent();
        }
        dbconnection db = new dbconnection();
        private void button1_Click(object sender, EventArgs e)
        {
            dbconnection db = new dbconnection();
            String sql = "INSERT INTO  Users(FirstName) VALUES('Chhin Vanchhai')";
            var data =db.execute(sql);
            if (data)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show(sql);
            }
            
            
        }
        public void AddControll(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelHome.Controls.Clear();
            panelHome.Controls.Add(c);

        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnNext.Hide();
            btnNextFood.Hide();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        public void guestPanel()
        {
            panelActive.Width = lbRegister.Width;
            panelActive.Left = lbRegister.Left;
            MessageBox.Show("this word for me gues panel");
        }

        private void lbRoomAvialable_Click(object sender, EventArgs e)
        {
            panelActive.Width = lbRoomAvialable.Width;
            panelActive.Left = lbRoomAvialable.Left;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            panelActive.Width = lbRegister.Width;
            panelActive.Left = lbRegister.Left;
            btnNext.Show();
            AddControll(guest);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //if (guest.InsertGuest())
            //{
            //    guest.InsertGuest();
            //    panelActive.Width = lbReservation.Width;
            //    panelActive.Left = lbReservation.Left;
            //    btnNext.Hide();
            //    btnNextFood.Show();
            //    AddControll(reserve);
            //}
        }

        private void btnNextFood_Click(object sender, EventArgs e)
        {

            if (reserve.insertReserve())
            {
                Foods food = new Foods();
                AddControll(food);
            }
           
        }

        private void hfg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            showGuestList listGuest = new showGuestList();
            panelActive.Width = lbGuest.Width;
            panelActive.Left = lbGuest.Left;
            AddControll(listGuest);
        }

        private void lbHome_Click(object sender, EventArgs e)
        {
            
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            GuestRegister guest = new GuestRegister();
            panelActive.Width = lbRegister.Width;
            panelActive.Left = lbRegister.Left;
            AddControll(guest);
        }
    }
}
