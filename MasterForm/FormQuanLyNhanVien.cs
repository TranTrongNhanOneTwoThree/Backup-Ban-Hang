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
    public partial class FormQuanLyNhanVien : Form
    {
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void textBox_HoTen_Leave(object sender, EventArgs e)
        {
            if(textBox_HoTen.Text == "")
            {
                textBox_HoTen.Text = "Thêm Họ Tên";
                textBox_HoTen.ForeColor = Color.Gray;
            }
        }

        private void textBox_HoTen_Enter(object sender, EventArgs e)
        {
            if (textBox_HoTen.Text == "Thêm Họ Tên")
            {
                textBox_HoTen.Text = "";
                textBox_HoTen.ForeColor = Color.Black;
            }
        }

        private void textBox_SoDienThoai_Leave(object sender, EventArgs e)
        {
            if (textBox_SoDienThoai.Text == "")
            {
                textBox_SoDienThoai.Text = "Thêm SĐT";
                textBox_SoDienThoai.ForeColor = Color.Gray;
            }     
        }

        private void textBox_SoDienThoai_Enter(object sender, EventArgs e)
        {
            if (textBox_SoDienThoai.Text == "Thêm SĐT")
            {
                textBox_SoDienThoai.Text = "";
                textBox_SoDienThoai.ForeColor = Color.Black;
            }
        }

        private void label_NgayVaoLam_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label_NgayVaoLam.Text = DateTimeOffset.Now.ToString();
        }
    }
}
