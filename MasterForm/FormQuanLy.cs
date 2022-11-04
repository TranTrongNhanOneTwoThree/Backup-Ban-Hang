using System;
using System.Windows.Forms;
using System.Xml;

namespace MasterForm
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void button_TrangChu_Click(object sender, EventArgs e)
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

        private void button_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void button_QuanLy_Click(object sender, EventArgs e)
        {
            panelShow.Controls["QuanLyNhanVien"].BringToFront();
        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            panelShow.Controls["CaiDat"].BringToFront();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
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

            QuanLyNhanVien ql = new QuanLyNhanVien();
            ql.Dock = DockStyle.Fill;
            panelShow.Controls.Add(ql);
        }
    }
}
