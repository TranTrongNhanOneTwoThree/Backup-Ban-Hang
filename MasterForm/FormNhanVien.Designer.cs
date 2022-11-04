namespace MasterForm
{
    partial class FormNhanVien
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
            this.panelLabel = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.button_DangXuat = new System.Windows.Forms.Button();
            this.button_CaiDat = new System.Windows.Forms.Button();
            this.button_NhapHang = new System.Windows.Forms.Button();
            this.button_KhachHang = new System.Windows.Forms.Button();
            this.button_SanPham = new System.Windows.Forms.Button();
            this.button_DonHang = new System.Windows.Forms.Button();
            this.button_TrangChu = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panelLabel.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.Color.White;
            this.panelLabel.Controls.Add(this.button_Exit);
            this.panelLabel.Controls.Add(this.label1);
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLabel.ForeColor = System.Drawing.Color.Gray;
            this.panelLabel.Location = new System.Drawing.Point(195, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(1023, 77);
            this.panelLabel.TabIndex = 5;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.White;
            this.button_Exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.Red;
            this.button_Exit.Location = new System.Drawing.Point(974, 0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(49, 43);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(329, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "VNB SPORTS";
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.White;
            this.panelButton.Controls.Add(this.button_DangXuat);
            this.panelButton.Controls.Add(this.button_CaiDat);
            this.panelButton.Controls.Add(this.button_NhapHang);
            this.panelButton.Controls.Add(this.button_KhachHang);
            this.panelButton.Controls.Add(this.button_SanPham);
            this.panelButton.Controls.Add(this.button_DonHang);
            this.panelButton.Controls.Add(this.button_TrangChu);
            this.panelButton.Controls.Add(this.pictureBox_Logo);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(195, 741);
            this.panelButton.TabIndex = 4;
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(195, 77);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1023, 664);
            this.panelShow.TabIndex = 6;
            // 
            // button_DangXuat
            // 
            this.button_DangXuat.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_DangXuat.FlatAppearance.BorderSize = 0;
            this.button_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangXuat.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangXuat.ForeColor = System.Drawing.Color.White;
            this.button_DangXuat.Image = global::MasterForm.Properties.Resources.Thoát;
            this.button_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DangXuat.Location = new System.Drawing.Point(-2, 681);
            this.button_DangXuat.Name = "button_DangXuat";
            this.button_DangXuat.Size = new System.Drawing.Size(197, 58);
            this.button_DangXuat.TabIndex = 7;
            this.button_DangXuat.Text = "      ĐĂNG XUẤT";
            this.button_DangXuat.UseVisualStyleBackColor = false;
            // 
            // button_CaiDat
            // 
            this.button_CaiDat.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_CaiDat.FlatAppearance.BorderSize = 0;
            this.button_CaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CaiDat.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CaiDat.ForeColor = System.Drawing.Color.White;
            this.button_CaiDat.Image = global::MasterForm.Properties.Resources.Cài_đặt;
            this.button_CaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CaiDat.Location = new System.Drawing.Point(0, 456);
            this.button_CaiDat.Name = "button_CaiDat";
            this.button_CaiDat.Size = new System.Drawing.Size(197, 58);
            this.button_CaiDat.TabIndex = 6;
            this.button_CaiDat.Text = "CÀI ĐẶT";
            this.button_CaiDat.UseVisualStyleBackColor = false;
            this.button_CaiDat.Click += new System.EventHandler(this.button_CaiDat_Click);
            // 
            // button_NhapHang
            // 
            this.button_NhapHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_NhapHang.FlatAppearance.BorderSize = 0;
            this.button_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NhapHang.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NhapHang.ForeColor = System.Drawing.Color.White;
            this.button_NhapHang.Image = global::MasterForm.Properties.Resources.Nhập_hàng;
            this.button_NhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_NhapHang.Location = new System.Drawing.Point(0, 402);
            this.button_NhapHang.Name = "button_NhapHang";
            this.button_NhapHang.Size = new System.Drawing.Size(197, 58);
            this.button_NhapHang.TabIndex = 5;
            this.button_NhapHang.Text = "       NHẬP HÀNG";
            this.button_NhapHang.UseVisualStyleBackColor = false;
            this.button_NhapHang.Click += new System.EventHandler(this.button_NhapHang_Click);
            // 
            // button_KhachHang
            // 
            this.button_KhachHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_KhachHang.FlatAppearance.BorderSize = 0;
            this.button_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KhachHang.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_KhachHang.ForeColor = System.Drawing.Color.White;
            this.button_KhachHang.Image = global::MasterForm.Properties.Resources.Khách_hàng;
            this.button_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_KhachHang.Location = new System.Drawing.Point(0, 349);
            this.button_KhachHang.Name = "button_KhachHang";
            this.button_KhachHang.Size = new System.Drawing.Size(197, 58);
            this.button_KhachHang.TabIndex = 4;
            this.button_KhachHang.Text = "          KHÁCH HÀNG";
            this.button_KhachHang.UseVisualStyleBackColor = false;
            this.button_KhachHang.Click += new System.EventHandler(this.button_KhachHang_Click);
            // 
            // button_SanPham
            // 
            this.button_SanPham.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_SanPham.FlatAppearance.BorderSize = 0;
            this.button_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SanPham.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SanPham.ForeColor = System.Drawing.Color.White;
            this.button_SanPham.Image = global::MasterForm.Properties.Resources.Sản_Phẩm;
            this.button_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SanPham.Location = new System.Drawing.Point(0, 294);
            this.button_SanPham.Name = "button_SanPham";
            this.button_SanPham.Size = new System.Drawing.Size(197, 58);
            this.button_SanPham.TabIndex = 3;
            this.button_SanPham.Text = "     SẢN PHẨM";
            this.button_SanPham.UseVisualStyleBackColor = false;
            this.button_SanPham.Click += new System.EventHandler(this.button_SanPham_Click);
            // 
            // button_DonHang
            // 
            this.button_DonHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_DonHang.FlatAppearance.BorderSize = 0;
            this.button_DonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DonHang.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DonHang.ForeColor = System.Drawing.Color.White;
            this.button_DonHang.Image = global::MasterForm.Properties.Resources.Đơn_hàng;
            this.button_DonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DonHang.Location = new System.Drawing.Point(0, 239);
            this.button_DonHang.Name = "button_DonHang";
            this.button_DonHang.Size = new System.Drawing.Size(197, 58);
            this.button_DonHang.TabIndex = 2;
            this.button_DonHang.Text = "       ĐƠN HÀNG";
            this.button_DonHang.UseVisualStyleBackColor = false;
            this.button_DonHang.Click += new System.EventHandler(this.button_DonHang_Click);
            // 
            // button_TrangChu
            // 
            this.button_TrangChu.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_TrangChu.FlatAppearance.BorderSize = 0;
            this.button_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TrangChu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TrangChu.ForeColor = System.Drawing.Color.White;
            this.button_TrangChu.Image = global::MasterForm.Properties.Resources.Trang_Chủ;
            this.button_TrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TrangChu.Location = new System.Drawing.Point(0, 185);
            this.button_TrangChu.Name = "button_TrangChu";
            this.button_TrangChu.Size = new System.Drawing.Size(197, 58);
            this.button_TrangChu.TabIndex = 1;
            this.button_TrangChu.Text = "         TRANG CHỦ";
            this.button_TrangChu.UseVisualStyleBackColor = false;
            this.button_TrangChu.Click += new System.EventHandler(this.button_TrangChu_Click_1);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::MasterForm.Properties.Resources.Logo_Shop;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(195, 114);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // FormNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1218, 741);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.panelButton);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button button_DangXuat;
        private System.Windows.Forms.Button button_CaiDat;
        private System.Windows.Forms.Button button_NhapHang;
        private System.Windows.Forms.Button button_KhachHang;
        private System.Windows.Forms.Button button_SanPham;
        private System.Windows.Forms.Button button_DonHang;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Button button_TrangChu;
    }
}