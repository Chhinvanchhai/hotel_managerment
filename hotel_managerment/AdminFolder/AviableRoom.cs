using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_managerment.AdminFolder
{
    public partial class AviableRoom : UserControl
    {
        dbconnection db = new dbconnection();
        public AviableRoom()
        {
            InitializeComponent();
        }

        private void AviableRoom_Load(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Room WHERE status = 'Available'";
            var data = db.GetData(sql);
            while (data.Read())
            {
                ListViewItem list = lsAviabelRoom.Items.Add(data[0].ToString());
                list.SubItems.Add(data[3].ToString());
                list.SubItems.Add(data[4].ToString());
                list.SubItems.Add(data[5].ToString());
                list.SubItems.Add(data[6].ToString());
                list.SubItems.Add(data[7].ToString());
                list.SubItems.Add(data[8].ToString());

            }
            
        }

        private void lsAviableRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
