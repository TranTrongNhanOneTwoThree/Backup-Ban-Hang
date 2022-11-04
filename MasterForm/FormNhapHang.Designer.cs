namespace MasterForm
{
    partial class FormNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_LoaiHang = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.comboBox_TenSP = new System.Windows.Forms.ComboBox();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.label_TienNhap = new System.Windows.Forms.Label();
            this.button_ThanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.groupBox_LoaiHang = new System.Windows.Forms.GroupBox();
            this.groupBox_SoLuong = new System.Windows.Forms.GroupBox();
            this.groupBox_TenSP = new System.Windows.Forms.GroupBox();
            this.groupBox_DonGia = new System.Windows.Forms.GroupBox();
            this.label_ChiTietHoaDon = new System.Windows.Forms.Label();
            this.label_ThongTinHoaDon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_MaPhieuNhap = new System.Windows.Forms.GroupBox();
            this.textBox_SoHoaDon = new System.Windows.Forms.TextBox();
            this.groupBox_ThoiGian = new System.Windows.Forms.GroupBox();
            this.label_ThoiGian = new System.Windows.Forms.Label();
            this.textBox_ThoiGian = new System.Windows.Forms.TextBox();
            this.groupBox_MaNV = new System.Windows.Forms.GroupBox();
            this.textBox_MaNV = new System.Windows.Forms.TextBox();
            this.label_NhapHang = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox_LoaiHang.SuspendLayout();
            this.groupBox_SoLuong.SuspendLayout();
            this.groupBox_TenSP.SuspendLayout();
            this.groupBox_DonGia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_MaPhieuNhap.SuspendLayout();
            this.groupBox_ThoiGian.SuspendLayout();
            this.groupBox_MaNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_LoaiHang
            // 
            this.comboBox_LoaiHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LoaiHang.FormattingEnabled = true;
            this.comboBox_LoaiHang.Location = new System.Drawing.Point(6, 32);
            this.comboBox_LoaiHang.Name = "comboBox_LoaiHang";
            this.comboBox_LoaiHang.Size = new System.Drawing.Size(175, 31);
            this.comboBox_LoaiHang.TabIndex = 1;
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.BackColor = System.Drawing.Color.White;
            this.textBox_DonGia.Enabled = false;
            this.textBox_DonGia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DonGia.ForeColor = System.Drawing.Color.Gray;
            this.textBox_DonGia.Location = new System.Drawing.Point(6, 30);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(380, 32);
            this.textBox_DonGia.TabIndex = 0;
            // 
            // comboBox_TenSP
            // 
            this.comboBox_TenSP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenSP.FormattingEnabled = true;
            this.comboBox_TenSP.Location = new System.Drawing.Point(6, 25);
            this.comboBox_TenSP.Name = "comboBox_TenSP";
            this.comboBox_TenSP.Size = new System.Drawing.Size(380, 31);
            this.comboBox_TenSP.TabIndex = 0;
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.BackColor = System.Drawing.Color.White;
            this.textBox_SoLuong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoLuong.ForeColor = System.Drawing.Color.Gray;
            this.textBox_SoLuong.Location = new System.Drawing.Point(6, 30);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(175, 32);
            this.textBox_SoLuong.TabIndex = 0;
            this.textBox_SoLuong.Text = "Thêm Số Lượng";
            this.textBox_SoLuong.Enter += new System.EventHandler(this.textBox_SoLuong_Enter);
            this.textBox_SoLuong.Leave += new System.EventHandler(this.textBox_SoLuong_Leave);
            // 
            // label_TienNhap
            // 
            this.label_TienNhap.AutoSize = true;
            this.label_TienNhap.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TienNhap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_TienNhap.Location = new System.Drawing.Point(434, 778);
            this.label_TienNhap.Name = "label_TienNhap";
            this.label_TienNhap.Size = new System.Drawing.Size(124, 26);
            this.label_TienNhap.TabIndex = 11;
            this.label_TienNhap.Text = "TIỀN NHẬP";
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_ThanhToan.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThanhToan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ThanhToan.Location = new System.Drawing.Point(230, 329);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(196, 45);
            this.button_ThanhToan.TabIndex = 9;
            this.button_ThanhToan.Text = "THANH TOÁN";
            this.button_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.button_ThanhToan);
            this.panel2.Controls.Add(this.button_Xoa);
            this.panel2.Controls.Add(this.button_Them);
            this.panel2.Controls.Add(this.groupBox_LoaiHang);
            this.panel2.Controls.Add(this.groupBox_SoLuong);
            this.panel2.Controls.Add(this.groupBox_TenSP);
            this.panel2.Controls.Add(this.groupBox_DonGia);
            this.panel2.Controls.Add(this.label_ChiTietHoaDon);
            this.panel2.Location = new System.Drawing.Point(477, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 419);
            this.panel2.TabIndex = 8;
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Xoa.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Xoa.Location = new System.Drawing.Point(125, 330);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(99, 45);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "XÓA ";
            this.button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Them.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Them.Location = new System.Drawing.Point(28, 330);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(91, 45);
            this.button_Them.TabIndex = 7;
            this.button_Them.Text = "THÊM";
            this.button_Them.UseVisualStyleBackColor = false;
            // 
            // groupBox_LoaiHang
            // 
            this.groupBox_LoaiHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_LoaiHang.Controls.Add(this.comboBox_LoaiHang);
            this.groupBox_LoaiHang.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_LoaiHang.Location = new System.Drawing.Point(230, 230);
            this.groupBox_LoaiHang.Name = "groupBox_LoaiHang";
            this.groupBox_LoaiHang.Size = new System.Drawing.Size(196, 80);
            this.groupBox_LoaiHang.TabIndex = 6;
            this.groupBox_LoaiHang.TabStop = false;
            this.groupBox_LoaiHang.Text = "Loại Hàng";
            // 
            // groupBox_SoLuong
            // 
            this.groupBox_SoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_SoLuong.Controls.Add(this.textBox_SoLuong);
            this.groupBox_SoLuong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SoLuong.Location = new System.Drawing.Point(28, 230);
            this.groupBox_SoLuong.Name = "groupBox_SoLuong";
            this.groupBox_SoLuong.Size = new System.Drawing.Size(196, 80);
            this.groupBox_SoLuong.TabIndex = 5;
            this.groupBox_SoLuong.TabStop = false;
            this.groupBox_SoLuong.Text = "Số Lượng";
            // 
            // groupBox_TenSP
            // 
            this.groupBox_TenSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_TenSP.Controls.Add(this.comboBox_TenSP);
            this.groupBox_TenSP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TenSP.Location = new System.Drawing.Point(28, 58);
            this.groupBox_TenSP.Name = "groupBox_TenSP";
            this.groupBox_TenSP.Size = new System.Drawing.Size(396, 71);
            this.groupBox_TenSP.TabIndex = 4;
            this.groupBox_TenSP.TabStop = false;
            this.groupBox_TenSP.Text = "Mã SP | Tên Sản Phẩm";
            // 
            // groupBox_DonGia
            // 
            this.groupBox_DonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_DonGia.Controls.Add(this.textBox_DonGia);
            this.groupBox_DonGia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DonGia.Location = new System.Drawing.Point(28, 144);
            this.groupBox_DonGia.Name = "groupBox_DonGia";
            this.groupBox_DonGia.Size = new System.Drawing.Size(396, 80);
            this.groupBox_DonGia.TabIndex = 3;
            this.groupBox_DonGia.TabStop = false;
            this.groupBox_DonGia.Text = "Đơn Giá";
            // 
            // label_ChiTietHoaDon
            // 
            this.label_ChiTietHoaDon.AutoSize = true;
            this.label_ChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_ChiTietHoaDon.Location = new System.Drawing.Point(129, 17);
            this.label_ChiTietHoaDon.Name = "label_ChiTietHoaDon";
            this.label_ChiTietHoaDon.Size = new System.Drawing.Size(178, 25);
            this.label_ChiTietHoaDon.TabIndex = 0;
            this.label_ChiTietHoaDon.Text = "Chi Tiết Hóa Đơn";
            // 
            // label_ThongTinHoaDon
            // 
            this.label_ThongTinHoaDon.AutoSize = true;
            this.label_ThongTinHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_ThongTinHoaDon.Location = new System.Drawing.Point(113, 17);
            this.label_ThongTinHoaDon.Name = "label_ThongTinHoaDon";
            this.label_ThongTinHoaDon.Size = new System.Drawing.Size(201, 25);
            this.label_ThongTinHoaDon.TabIndex = 0;
            this.label_ThongTinHoaDon.Text = "Thông Tin Hóa Đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.groupBox_MaPhieuNhap);
            this.panel1.Controls.Add(this.groupBox_ThoiGian);
            this.panel1.Controls.Add(this.groupBox_MaNV);
            this.panel1.Controls.Add(this.label_ThongTinHoaDon);
            this.panel1.Location = new System.Drawing.Point(14, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 419);
            this.panel1.TabIndex = 7;
            // 
            // groupBox_MaPhieuNhap
            // 
            this.groupBox_MaPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_MaPhieuNhap.Controls.Add(this.textBox_SoHoaDon);
            this.groupBox_MaPhieuNhap.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_MaPhieuNhap.Location = new System.Drawing.Point(37, 230);
            this.groupBox_MaPhieuNhap.Name = "groupBox_MaPhieuNhap";
            this.groupBox_MaPhieuNhap.Size = new System.Drawing.Size(396, 76);
            this.groupBox_MaPhieuNhap.TabIndex = 4;
            this.groupBox_MaPhieuNhap.TabStop = false;
            this.groupBox_MaPhieuNhap.Text = "Mã Phiếu Nhập";
            // 
            // textBox_SoHoaDon
            // 
            this.textBox_SoHoaDon.BackColor = System.Drawing.Color.White;
            this.textBox_SoHoaDon.Enabled = false;
            this.textBox_SoHoaDon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoHoaDon.Location = new System.Drawing.Point(6, 30);
            this.textBox_SoHoaDon.Name = "textBox_SoHoaDon";
            this.textBox_SoHoaDon.Size = new System.Drawing.Size(380, 32);
            this.textBox_SoHoaDon.TabIndex = 0;
            // 
            // groupBox_ThoiGian
            // 
            this.groupBox_ThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_ThoiGian.Controls.Add(this.label_ThoiGian);
            this.groupBox_ThoiGian.Controls.Add(this.textBox_ThoiGian);
            this.groupBox_ThoiGian.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ThoiGian.Location = new System.Drawing.Point(37, 144);
            this.groupBox_ThoiGian.Name = "groupBox_ThoiGian";
            this.groupBox_ThoiGian.Size = new System.Drawing.Size(396, 72);
            this.groupBox_ThoiGian.TabIndex = 3;
            this.groupBox_ThoiGian.TabStop = false;
            this.groupBox_ThoiGian.Text = "Thời Gian";
            // 
            // label_ThoiGian
            // 
            this.label_ThoiGian.AutoSize = true;
            this.label_ThoiGian.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThoiGian.Location = new System.Drawing.Point(6, 28);
            this.label_ThoiGian.Name = "label_ThoiGian";
            this.label_ThoiGian.Size = new System.Drawing.Size(59, 23);
            this.label_ThoiGian.TabIndex = 2;
            this.label_ThoiGian.Text = "label";
            // 
            // textBox_ThoiGian
            // 
            this.textBox_ThoiGian.BackColor = System.Drawing.Color.White;
            this.textBox_ThoiGian.Enabled = false;
            this.textBox_ThoiGian.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ThoiGian.Location = new System.Drawing.Point(6, 25);
            this.textBox_ThoiGian.Name = "textBox_ThoiGian";
            this.textBox_ThoiGian.Size = new System.Drawing.Size(380, 32);
            this.textBox_ThoiGian.TabIndex = 1;
            // 
            // groupBox_MaNV
            // 
            this.groupBox_MaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_MaNV.Controls.Add(this.textBox_MaNV);
            this.groupBox_MaNV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_MaNV.Location = new System.Drawing.Point(37, 58);
            this.groupBox_MaNV.Name = "groupBox_MaNV";
            this.groupBox_MaNV.Size = new System.Drawing.Size(396, 80);
            this.groupBox_MaNV.TabIndex = 1;
            this.groupBox_MaNV.TabStop = false;
            this.groupBox_MaNV.Text = "Mã NV | Tên NV";
            // 
            // textBox_MaNV
            // 
            this.textBox_MaNV.BackColor = System.Drawing.Color.White;
            this.textBox_MaNV.Enabled = false;
            this.textBox_MaNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaNV.Location = new System.Drawing.Point(6, 30);
            this.textBox_MaNV.Name = "textBox_MaNV";
            this.textBox_MaNV.Size = new System.Drawing.Size(380, 32);
            this.textBox_MaNV.TabIndex = 0;
            // 
            // label_NhapHang
            // 
            this.label_NhapHang.AutoSize = true;
            this.label_NhapHang.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NhapHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_NhapHang.Location = new System.Drawing.Point(403, 8);
            this.label_NhapHang.Name = "label_NhapHang";
            this.label_NhapHang.Size = new System.Drawing.Size(184, 34);
            this.label_NhapHang.TabIndex = 6;
            this.label_NhapHang.Text = "NHẬP HÀNG";
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 826);
            this.Controls.Add(this.label_TienNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_NhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_LoaiHang.ResumeLayout(false);
            this.groupBox_SoLuong.ResumeLayout(false);
            this.groupBox_SoLuong.PerformLayout();
            this.groupBox_TenSP.ResumeLayout(false);
            this.groupBox_DonGia.ResumeLayout(false);
            this.groupBox_DonGia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_MaPhieuNhap.ResumeLayout(false);
            this.groupBox_MaPhieuNhap.PerformLayout();
            this.groupBox_ThoiGian.ResumeLayout(false);
            this.groupBox_ThoiGian.PerformLayout();
            this.groupBox_MaNV.ResumeLayout(false);
            this.groupBox_MaNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_LoaiHang;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_DonGia;
        private System.Windows.Forms.ComboBox comboBox_TenSP;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Label label_TienNhap;
        private System.Windows.Forms.Button button_ThanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.GroupBox groupBox_LoaiHang;
        private System.Windows.Forms.GroupBox groupBox_SoLuong;
        private System.Windows.Forms.GroupBox groupBox_TenSP;
        private System.Windows.Forms.GroupBox groupBox_DonGia;
        private System.Windows.Forms.Label label_ChiTietHoaDon;
        private System.Windows.Forms.Label label_ThongTinHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_MaPhieuNhap;
        private System.Windows.Forms.TextBox textBox_SoHoaDon;
        private System.Windows.Forms.GroupBox groupBox_ThoiGian;
        private System.Windows.Forms.Label label_ThoiGian;
        private System.Windows.Forms.TextBox textBox_ThoiGian;
        private System.Windows.Forms.GroupBox groupBox_MaNV;
        private System.Windows.Forms.TextBox textBox_MaNV;
        private System.Windows.Forms.Label label_NhapHang;
    }
}