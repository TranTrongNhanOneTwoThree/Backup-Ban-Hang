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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void textBox_TenSanPham_Leave(object sender, EventArgs e)
        {
            if (textBox_TenSanPham.Text == "")
            {
                textBox_TenSanPham.Text = "Thêm Tên Sản Phẩm";
                textBox_TenSanPham.ForeColor = Color.Gray;
            }
        }

        private void textBox_TenSanPham_Enter(object sender, EventArgs e)
        {
            if (textBox_TenSanPham.Text == "Thêm Tên Sản Phẩm")
            {
                textBox_TenSanPham.Text = "";
                textBox_TenSanPham.ForeColor = Color.Black;
            }
        }

        private void textBox_GiaSanPham_Leave(object sender, EventArgs e)
        {
            if (textBox_GiaSanPham.Text == "")
            {
                textBox_GiaSanPham.Text = "Thêm Giá Sản Phẩm";
                textBox_GiaSanPham.ForeColor = Color.Gray;
            }
        }

        private void textBox_GiaSanPham_Enter(object sender, EventArgs e)
        {
            if (textBox_GiaSanPham.Text == "Thêm Giá Sản Phẩm")
            {
                textBox_GiaSanPham.Text = "";
                textBox_GiaSanPham.ForeColor = Color.Black;
            }
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
