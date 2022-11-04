using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterForm
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void groupBox_ThoiGian_Enter(object sender, EventArgs e)
        {

        }

        private void label_ThoiGian_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            label_ThoiGian.Text = DateTimeOffset.Now.ToString();
        }

        private void textBox_DonGia_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_DonGia_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_SoLuong_Leave(object sender, EventArgs e)
        {
            if (textBox_SoLuong.Text == "")
            {
                textBox_SoLuong.Text = "Thêm Số Lượng";
                textBox_SoLuong.ForeColor = Color.Gray;
            }
        }

        private void textBox_SoLuong_Enter(object sender, EventArgs e)
        {
            if (textBox_SoLuong.Text == "Thêm Số Lượng")
            {
                textBox_SoLuong.Text = "";
                textBox_SoLuong.ForeColor = Color.Black;
            }
        }
    }
}
