using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class DonHang : UserControl
    {
        public DonHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_TìmKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_HoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TìmKiem_Enter(object sender, EventArgs e)
        {
            if(textBox_TìmKiem.Text == "Tìm Kiếm")
            {
                textBox_TìmKiem.Text = "";
                textBox_TìmKiem.ForeColor = Color.Black;
            }
        }

        private void textBox_TìmKiem_Leave(object sender, EventArgs e)
        {
            if (textBox_TìmKiem.Text == "")
            {
                textBox_TìmKiem.Text = "Tìm Kiếm";
                textBox_TìmKiem.ForeColor = Color.Gray;
            }
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHoaDon = new FormHoaDon();
            frmHoaDon.ShowDialog();
        }
    }
}
