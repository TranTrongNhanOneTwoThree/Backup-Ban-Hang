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
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void textBox_TìmKiem_Enter(object sender, EventArgs e)
        {
            if (textBox_TìmKiem.Text == "Tìm Kiếm")
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

        private void textBox_TìmKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            FormSanPham frmSanPham = new FormSanPham();
            frmSanPham.ShowDialog();
        }
    }
}
