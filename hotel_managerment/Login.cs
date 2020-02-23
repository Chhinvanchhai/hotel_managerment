using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_managerment
{
    public partial class Login : Form
    {
        dbconnection db = new dbconnection();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sql ="select * from Users where Username='"+txtName.Text+"' And Password= '"+txtPassword.Text+"'";
            if (db.Isexist(sql))
            {
                Home hm = new Home();
                hm.Hide();
                this.Close();
                Admin ad = new Admin();
                ad.Show();
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* Home hm = new Home();
            hm.Show();*/
            
        }
    }
}
