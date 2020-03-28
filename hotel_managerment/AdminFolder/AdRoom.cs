using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_managerment.HomeFolder;

namespace hotel_managerment.AdminFolder
{
    public partial class AdRoom : UserControl
    {
        dbconnection db = new dbconnection();
        public AdRoom()
        {
            InitializeComponent();
        }
        public bool Validation(String values)
        {
            if(values == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Validation(txtBed.Text) || Validation(txtAirCoditonal.Text) || Validation(txtPrice.Text) || Validation(txtStatus.Text) || Validation(txtRoomNumber.Text) )
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                var sql = "Insert Into Room(bed,air_condition,price,[floor],[status],room_number) Values('" + txtBed.Text + "','" + txtAirCoditonal.Text + "','" + txtPrice.Text + "','" + txtFloor.Text + "','" + txtStatus.Text + "','" + txtRoomNumber.Text + "')";
                if (db.execute(sql))
                {
                    GetDataList();
                    txtRoomNumber.Text = "";
                    txtPrice.Text = "";
                    txtFloor.Text = "";
                    txtStatus.Text = "";
                    txtBed.Text = "";
                    txtAirCoditonal.Text = "";
                    txtStatus.Text = "";

                }
                else
                {
                    MessageBox.Show("Failed to insert");
                }
            }

        }

        private void AdRoom_Load(object sender, EventArgs e)
        {
            GetDataList();
        }
        public void GetDataList()
        {
            var sql = "SELECT * FROM Room ORDER BY id DESC";
            var data = db.GetData(sql);
            lsAllRoom.Items.Clear();
            while (data.Read())
            {
                ListViewItem list = lsAllRoom.Items.Add(data[0].ToString());
                list.SubItems.Add(data[3].ToString());
                list.SubItems.Add(data[4].ToString());
                list.SubItems.Add(data[5].ToString());
                list.SubItems.Add(data[6].ToString());
                list.SubItems.Add(data[7].ToString());
                list.SubItems.Add(data[8].ToString());

            }
            data.Close();
        }

        private void txtFloorlb_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsAllRoom.SelectedItems.Count >= 1)
            {
                string ids = "";
                var list = lsAllRoom.SelectedItems;
                if(MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (var i = 0; i < list.Count; i++)
                    {
                        if (list.Count - 1 == i)
                        {
                            ids += list[i].Text;
                        }
                        else
                        {
                            ids += list[i].Text + ",";
                        }
                    }
                }
                var sql = "DELETE FROM Room WHERE id in("+ids+")";
                if (db.execute(sql))
                {
                    MessageBox.Show("Delete Successful");
                    GetDataList();
                }else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please Select the row!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation(txtBed.Text) || Validation(txtAirCoditonal.Text) || Validation(txtPrice.Text) || Validation(txtStatus.Text) || Validation(txtRoomNumber.Text))
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                var sql = "UPDATE Room SET bed ='" + txtBed.Text + "',air_condition='" + txtAirCoditonal.Text + "' ,price='" + txtPrice.Text + "' ,[floor]='" + txtFloor.Text + "',[status]='" + txtStatus.Text + "',room_number= '" + txtRoomNumber.Text + "' WHERE id = '" + txtID.Text + "'";
                if (db.execute(sql))
                {
                    GetDataList();
                    txtRoomNumber.Text = "";
                    txtPrice.Text = "";
                    txtFloor.Text = "";
                    txtStatus.Text = "";
                    txtBed.Text = "";
                    txtAirCoditonal.Text = "";
                    txtStatus.Text = "";

                }
                else
                {
                    MessageBox.Show("Failed to insert");
                }
            }
        }

        private void lsAllRoom_DoubleClick(object sender, EventArgs e)
        {
            var list = lsAllRoom.SelectedItems;
            txtID.Text = list[0].SubItems[0].Text;
            txtFloor.Text = list[0].SubItems[1].Text;
            txtBed.Text = list[0].SubItems[2].Text;
            txtPrice.Text = list[0].SubItems[3].Text;
            txtStatus.Text = list[0].SubItems[5].Text;
            txtAirCoditonal.Text = list[0].SubItems[4].Text;
            txtRoomNumber.Text = list[0].SubItems[6].Text;
        }

        private void lsAllRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormDetial fd = new FormDetial();
            fd.ShowDialog();
        }
    }
}
