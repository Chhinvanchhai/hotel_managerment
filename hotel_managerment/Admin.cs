
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_managerment.AdminFolder;

namespace hotel_managerment
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void AddControll(Control c)
        {
            c.Dock = DockStyle.Fill;
            adMinPanel.Controls.Clear();
            adMinPanel.Controls.Add(c);

        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void addRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addRoomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdRoom ad = new AdRoom();
            AddControll(ad);
        }

        private void aviableRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AviableRoom AR = new AviableRoom();
            AddControll(AR);


        }

        private void adMinPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
