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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // add các controll vào panelShow

            TrangChu tc = new TrangChu();
            tc.Dock = DockStyle.Fill;
            panelShow.Controls.Add(tc);

            DonHang dh = new DonHang();
            dh.Dock = DockStyle.Fill;
            panelShow.Controls.Add(dh);

            SanPham sp = new SanPham();
            sp.Dock = DockStyle.Fill;
            panelShow.Controls.Add(sp);

            KhachHang kh = new KhachHang();
            kh.Dock = DockStyle.Fill;
            panelShow.Controls.Add(kh);

            NhapHang nh = new NhapHang();
            nh.Dock = DockStyle.Fill;
            panelShow.Controls.Add(nh);

            CaiDat cd = new CaiDat();
            cd.Dock = DockStyle.Fill;
            panelShow.Controls.Add(cd);
        }

        private void button_TrangChu_Click_1(object sender, EventArgs e)
        {
            panelShow.Controls["TrangChu"].BringToFront();
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls["DonHang"].BringToFront();
        }

        private void button_SanPham_Click(object sender, EventArgs e)
        {
            panelShow.Controls["SanPham"].BringToFront();
        }

        private void button_KhachHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls["KhachHang"].BringToFront();
        }

        private void button_NhapHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls["NhapHang"].BringToFront();
        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            panelShow.Controls["CaiDat"].BringToFront();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
