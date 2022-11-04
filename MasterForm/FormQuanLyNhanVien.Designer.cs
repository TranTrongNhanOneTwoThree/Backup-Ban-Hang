namespace MasterForm
{
    partial class FormQuanLyNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_NgayVaoLam = new System.Windows.Forms.GroupBox();
            this.label_NgayVaoLam = new System.Windows.Forms.Label();
            this.textBox_NgayVaoLam = new System.Windows.Forms.TextBox();
            this.groupBox_HoTen = new System.Windows.Forms.GroupBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.groupBox_MaNV = new System.Windows.Forms.GroupBox();
            this.textBox_MaNV = new System.Windows.Forms.TextBox();
            this.button_ThemNhanVien = new System.Windows.Forms.Button();
            this.groupBox_SoDienThoai = new System.Windows.Forms.GroupBox();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label_ThongTinKhachHang = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox_NgayVaoLam.SuspendLayout();
            this.groupBox_HoTen.SuspendLayout();
            this.groupBox_MaNV.SuspendLayout();
            this.groupBox_SoDienThoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox1.Controls.Add(this.groupBox_NgayVaoLam);
            this.groupBox1.Controls.Add(this.groupBox_HoTen);
            this.groupBox1.Controls.Add(this.groupBox_MaNV);
            this.groupBox1.Controls.Add(this.button_ThemNhanVien);
            this.groupBox1.Controls.Add(this.groupBox_SoDienThoai);
            this.groupBox1.Location = new System.Drawing.Point(29, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 511);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBox_NgayVaoLam
            // 
            this.groupBox_NgayVaoLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_NgayVaoLam.Controls.Add(this.label_NgayVaoLam);
            this.groupBox_NgayVaoLam.Controls.Add(this.textBox_NgayVaoLam);
            this.groupBox_NgayVaoLam.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NgayVaoLam.Location = new System.Drawing.Point(27, 227);
            this.groupBox_NgayVaoLam.Name = "groupBox_NgayVaoLam";
            this.groupBox_NgayVaoLam.Size = new System.Drawing.Size(374, 80);
            this.groupBox_NgayVaoLam.TabIndex = 20;
            this.groupBox_NgayVaoLam.TabStop = false;
            this.groupBox_NgayVaoLam.Text = "Ngày Vào Làm";
            // 
            // label_NgayVaoLam
            // 
            this.label_NgayVaoLam.AutoSize = true;
            this.label_NgayVaoLam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayVaoLam.Location = new System.Drawing.Point(6, 33);
            this.label_NgayVaoLam.Name = "label_NgayVaoLam";
            this.label_NgayVaoLam.Size = new System.Drawing.Size(70, 23);
            this.label_NgayVaoLam.TabIndex = 1;
            this.label_NgayVaoLam.Text = "label1";
            this.label_NgayVaoLam.Click += new System.EventHandler(this.label_NgayVaoLam_Click);
            // 
            // textBox_NgayVaoLam
            // 
            this.textBox_NgayVaoLam.BackColor = System.Drawing.Color.White;
            this.textBox_NgayVaoLam.Enabled = false;
            this.textBox_NgayVaoLam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NgayVaoLam.Location = new System.Drawing.Point(6, 30);
            this.textBox_NgayVaoLam.Name = "textBox_NgayVaoLam";
            this.textBox_NgayVaoLam.Size = new System.Drawing.Size(349, 32);
            this.textBox_NgayVaoLam.TabIndex = 0;
            // 
            // groupBox_HoTen
            // 
            this.groupBox_HoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_HoTen.Controls.Add(this.textBox_HoTen);
            this.groupBox_HoTen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_HoTen.Location = new System.Drawing.Point(27, 30);
            this.groupBox_HoTen.Name = "groupBox_HoTen";
            this.groupBox_HoTen.Size = new System.Drawing.Size(374, 80);
            this.groupBox_HoTen.TabIndex = 20;
            this.groupBox_HoTen.TabStop = false;
            this.groupBox_HoTen.Text = "Họ Tên";
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.BackColor = System.Drawing.Color.White;
            this.textBox_HoTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HoTen.ForeColor = System.Drawing.Color.Gray;
            this.textBox_HoTen.Location = new System.Drawing.Point(6, 30);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(349, 32);
            this.textBox_HoTen.TabIndex = 1;
            this.textBox_HoTen.Text = "Thêm Họ Tên";
            this.textBox_HoTen.Enter += new System.EventHandler(this.textBox_HoTen_Enter);
            this.textBox_HoTen.Leave += new System.EventHandler(this.textBox_HoTen_Leave);
            // 
            // groupBox_MaNV
            // 
            this.groupBox_MaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_MaNV.Controls.Add(this.textBox_MaNV);
            this.groupBox_MaNV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_MaNV.Location = new System.Drawing.Point(27, 129);
            this.groupBox_MaNV.Name = "groupBox_MaNV";
            this.groupBox_MaNV.Size = new System.Drawing.Size(374, 80);
            this.groupBox_MaNV.TabIndex = 19;
            this.groupBox_MaNV.TabStop = false;
            this.groupBox_MaNV.Text = "Mã Nhân Viên";
            // 
            // textBox_MaNV
            // 
            this.textBox_MaNV.BackColor = System.Drawing.Color.White;
            this.textBox_MaNV.Enabled = false;
            this.textBox_MaNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaNV.Location = new System.Drawing.Point(6, 30);
            this.textBox_MaNV.Name = "textBox_MaNV";
            this.textBox_MaNV.Size = new System.Drawing.Size(349, 32);
            this.textBox_MaNV.TabIndex = 0;
            // 
            // button_ThemNhanVien
            // 
            this.button_ThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_ThemNhanVien.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemNhanVien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ThemNhanVien.Location = new System.Drawing.Point(27, 443);
            this.button_ThemNhanVien.Name = "button_ThemNhanVien";
            this.button_ThemNhanVien.Size = new System.Drawing.Size(374, 45);
            this.button_ThemNhanVien.TabIndex = 18;
            this.button_ThemNhanVien.Text = "THÊM NHÂN VIÊN";
            this.button_ThemNhanVien.UseVisualStyleBackColor = false;
            // 
            // groupBox_SoDienThoai
            // 
            this.groupBox_SoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_SoDienThoai.Controls.Add(this.textBox_SoDienThoai);
            this.groupBox_SoDienThoai.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SoDienThoai.Location = new System.Drawing.Point(27, 322);
            this.groupBox_SoDienThoai.Name = "groupBox_SoDienThoai";
            this.groupBox_SoDienThoai.Size = new System.Drawing.Size(374, 80);
            this.groupBox_SoDienThoai.TabIndex = 16;
            this.groupBox_SoDienThoai.TabStop = false;
            this.groupBox_SoDienThoai.Text = "Số Điện Thoại";
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.BackColor = System.Drawing.Color.White;
            this.textBox_SoDienThoai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoDienThoai.ForeColor = System.Drawing.Color.Gray;
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(6, 30);
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(349, 32);
            this.textBox_SoDienThoai.TabIndex = 0;
            this.textBox_SoDienThoai.Text = "Thêm SĐT";
            this.textBox_SoDienThoai.Enter += new System.EventHandler(this.textBox_SoDienThoai_Enter);
            this.textBox_SoDienThoai.Leave += new System.EventHandler(this.textBox_SoDienThoai_Leave);
            // 
            // label_ThongTinKhachHang
            // 
            this.label_ThongTinKhachHang.AutoSize = true;
            this.label_ThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_ThongTinKhachHang.Location = new System.Drawing.Point(115, 9);
            this.label_ThongTinKhachHang.Name = "label_ThongTinKhachHang";
            this.label_ThongTinKhachHang.Size = new System.Drawing.Size(252, 25);
            this.label_ThongTinKhachHang.TabIndex = 28;
            this.label_ThongTinKhachHang.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_ThongTinKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyNhanVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox_NgayVaoLam.ResumeLayout(false);
            this.groupBox_NgayVaoLam.PerformLayout();
            this.groupBox_HoTen.ResumeLayout(false);
            this.groupBox_HoTen.PerformLayout();
            this.groupBox_MaNV.ResumeLayout(false);
            this.groupBox_MaNV.PerformLayout();
            this.groupBox_SoDienThoai.ResumeLayout(false);
            this.groupBox_SoDienThoai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_NgayVaoLam;
        private System.Windows.Forms.Label label_NgayVaoLam;
        private System.Windows.Forms.TextBox textBox_NgayVaoLam;
        private System.Windows.Forms.GroupBox groupBox_HoTen;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.GroupBox groupBox_MaNV;
        private System.Windows.Forms.TextBox textBox_MaNV;
        private System.Windows.Forms.Button button_ThemNhanVien;
        private System.Windows.Forms.GroupBox groupBox_SoDienThoai;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private System.Windows.Forms.Label label_ThongTinKhachHang;
        private System.Windows.Forms.Timer timer1;
    }
}