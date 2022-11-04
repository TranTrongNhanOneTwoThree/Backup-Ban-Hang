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
    public partial class FormNhapHang : Form
    {
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void textBox_SoLuong_Leave(object sender, EventArgs e)
        {
            if(textBox_SoLuong.Text == "")
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
