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
            rs.Tag = "3";
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
        public bool InsertGuest()
        {
            if (Validate(txtName.Text) || Validate(txtAddress.Text) || Validate(txtEmail.Text) || Validate(txtCity.Text) || Validate(txtState.Text) || Validate(txtPhone.Text))
            {
                MessageBox.Show("Please fill the the field");
                return false;
            }
            else
            {
                var sql = "insert into Guest([name],[address],email,city,country,phone)" +
                  " Values('" + txtName.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtPhone.Text + "')";
                if (!db.execute(sql))
                {
                    MessageBox.Show("Failed to insert");
                }
                else
                {
                    return true;
                }

            }
            return false;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text);
        }
    }
}
