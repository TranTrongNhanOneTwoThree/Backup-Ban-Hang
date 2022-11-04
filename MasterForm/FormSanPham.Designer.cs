namespace MasterForm
{
    partial class FormSanPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_ThongTinSanPham = new System.Windows.Forms.TextBox();
            this.label_ThongTinSanPham = new System.Windows.Forms.Label();
            this.groupBox_SoLuong = new System.Windows.Forms.GroupBox();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.groupBox_TenSanPham = new System.Windows.Forms.GroupBox();
            this.textBox_TenSanPham = new System.Windows.Forms.TextBox();
            this.groupBox_MaSanPham = new System.Windows.Forms.GroupBox();
            this.textBox_MaSanPham = new System.Windows.Forms.TextBox();
            this.button_ThemSanPham = new System.Windows.Forms.Button();
            this.groupBox_LoaiSanPham = new System.Windows.Forms.GroupBox();
            this.comboBox_LoaiSanPham = new System.Windows.Forms.ComboBox();
            this.groupBox_GiaSanPham = new System.Windows.Forms.GroupBox();
            this.textBox_GiaSanPham = new System.Windows.Forms.TextBox();
            this.label_SanPhamMoi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.groupBox_SoLuong.SuspendLayout();
            this.groupBox_TenSanPham.SuspendLayout();
            this.groupBox_MaSanPham.SuspendLayout();
            this.groupBox_LoaiSanPham.SuspendLayout();
            this.groupBox_GiaSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.textBox_ThongTinSanPham);
            this.panel2.Controls.Add(this.label_ThongTinSanPham);
            this.panel2.Controls.Add(this.groupBox_SoLuong);
            this.panel2.Controls.Add(this.groupBox_TenSanPham);
            this.panel2.Controls.Add(this.groupBox_MaSanPham);
            this.panel2.Controls.Add(this.button_ThemSanPham);
            this.panel2.Controls.Add(this.groupBox_LoaiSanPham);
            this.panel2.Controls.Add(this.groupBox_GiaSanPham);
            this.panel2.Controls.Add(this.label_SanPhamMoi);
            this.panel2.Location = new System.Drawing.Point(340, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 590);
            this.panel2.TabIndex = 3;
            // 
            // textBox_ThongTinSanPham
            // 
            this.textBox_ThongTinSanPham.Location = new System.Drawing.Point(34, 369);
            this.textBox_ThongTinSanPham.Multiline = true;
            this.textBox_ThongTinSanPham.Name = "textBox_ThongTinSanPham";
            this.textBox_ThongTinSanPham.Size = new System.Drawing.Size(386, 126);
            this.textBox_ThongTinSanPham.TabIndex = 14;
            // 
            // label_ThongTinSanPham
            // 
            this.label_ThongTinSanPham.AutoSize = true;
            this.label_ThongTinSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_ThongTinSanPham.Location = new System.Drawing.Point(30, 346);
            this.label_ThongTinSanPham.Name = "label_ThongTinSanPham";
            this.label_ThongTinSanPham.Size = new System.Drawing.Size(212, 20);
            this.label_ThongTinSanPham.TabIndex = 13;
            this.label_ThongTinSanPham.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // groupBox_SoLuong
            // 
            this.groupBox_SoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_SoLuong.Controls.Add(this.textBox_SoLuong);
            this.groupBox_SoLuong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SoLuong.Location = new System.Drawing.Point(28, 245);
            this.groupBox_SoLuong.Name = "groupBox_SoLuong";
            this.groupBox_SoLuong.Size = new System.Drawing.Size(215, 80);
            this.groupBox_SoLuong.TabIndex = 12;
            this.groupBox_SoLuong.TabStop = false;
            this.groupBox_SoLuong.Text = "Số Lượng";
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.BackColor = System.Drawing.Color.White;
            this.textBox_SoLuong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoLuong.ForeColor = System.Drawing.Color.Gray;
            this.textBox_SoLuong.Location = new System.Drawing.Point(6, 30);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(203, 32);
            this.textBox_SoLuong.TabIndex = 0;
            this.textBox_SoLuong.Text = "Thêm Số Lượng";
            this.textBox_SoLuong.Enter += new System.EventHandler(this.textBox_SoLuong_Enter);
            this.textBox_SoLuong.Leave += new System.EventHandler(this.textBox_SoLuong_Leave);
            // 
            // groupBox_TenSanPham
            // 
            this.groupBox_TenSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_TenSanPham.Controls.Add(this.textBox_TenSanPham);
            this.groupBox_TenSanPham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TenSanPham.Location = new System.Drawing.Point(249, 73);
            this.groupBox_TenSanPham.Name = "groupBox_TenSanPham";
            this.groupBox_TenSanPham.Size = new System.Drawing.Size(215, 80);
            this.groupBox_TenSanPham.TabIndex = 11;
            this.groupBox_TenSanPham.TabStop = false;
            this.groupBox_TenSanPham.Text = "Tên Sản Phẩm";
            // 
            // textBox_TenSanPham
            // 
            this.textBox_TenSanPham.BackColor = System.Drawing.Color.White;
            this.textBox_TenSanPham.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenSanPham.ForeColor = System.Drawing.Color.Gray;
            this.textBox_TenSanPham.Location = new System.Drawing.Point(6, 30);
            this.textBox_TenSanPham.Name = "textBox_TenSanPham";
            this.textBox_TenSanPham.Size = new System.Drawing.Size(203, 32);
            this.textBox_TenSanPham.TabIndex = 1;
            this.textBox_TenSanPham.Text = "Thêm Tên Sản Phẩm";
            this.textBox_TenSanPham.Enter += new System.EventHandler(this.textBox_TenSanPham_Enter);
            this.textBox_TenSanPham.Leave += new System.EventHandler(this.textBox_TenSanPham_Leave);
            // 
            // groupBox_MaSanPham
            // 
            this.groupBox_MaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_MaSanPham.Controls.Add(this.textBox_MaSanPham);
            this.groupBox_MaSanPham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_MaSanPham.Location = new System.Drawing.Point(28, 73);
            this.groupBox_MaSanPham.Name = "groupBox_MaSanPham";
            this.groupBox_MaSanPham.Size = new System.Drawing.Size(215, 80);
            this.groupBox_MaSanPham.TabIndex = 10;
            this.groupBox_MaSanPham.TabStop = false;
            this.groupBox_MaSanPham.Text = "Mã Sản Phẩm";
            // 
            // textBox_MaSanPham
            // 
            this.textBox_MaSanPham.BackColor = System.Drawing.Color.White;
            this.textBox_MaSanPham.Enabled = false;
            this.textBox_MaSanPham.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaSanPham.Location = new System.Drawing.Point(6, 30);
            this.textBox_MaSanPham.Name = "textBox_MaSanPham";
            this.textBox_MaSanPham.Size = new System.Drawing.Size(203, 32);
            this.textBox_MaSanPham.TabIndex = 0;
            // 
            // button_ThemSanPham
            // 
            this.button_ThemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_ThemSanPham.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemSanPham.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ThemSanPham.Location = new System.Drawing.Point(34, 501);
            this.button_ThemSanPham.Name = "button_ThemSanPham";
            this.button_ThemSanPham.Size = new System.Drawing.Size(386, 45);
            this.button_ThemSanPham.TabIndex = 9;
            this.button_ThemSanPham.Text = "THÊM SẢN PHẨM";
            this.button_ThemSanPham.UseVisualStyleBackColor = false;
            // 
            // groupBox_LoaiSanPham
            // 
            this.groupBox_LoaiSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_LoaiSanPham.Controls.Add(this.comboBox_LoaiSanPham);
            this.groupBox_LoaiSanPham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_LoaiSanPham.Location = new System.Drawing.Point(249, 159);
            this.groupBox_LoaiSanPham.Name = "groupBox_LoaiSanPham";
            this.groupBox_LoaiSanPham.Size = new System.Drawing.Size(215, 80);
            this.groupBox_LoaiSanPham.TabIndex = 6;
            this.groupBox_LoaiSanPham.TabStop = false;
            this.groupBox_LoaiSanPham.Text = "Loại Sản Phẩm";
            // 
            // comboBox_LoaiSanPham
            // 
            this.comboBox_LoaiSanPham.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LoaiSanPham.FormattingEnabled = true;
            this.comboBox_LoaiSanPham.Location = new System.Drawing.Point(6, 31);
            this.comboBox_LoaiSanPham.Name = "comboBox_LoaiSanPham";
            this.comboBox_LoaiSanPham.Size = new System.Drawing.Size(203, 31);
            this.comboBox_LoaiSanPham.TabIndex = 1;
            // 
            // groupBox_GiaSanPham
            // 
            this.groupBox_GiaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_GiaSanPham.Controls.Add(this.textBox_GiaSanPham);
            this.groupBox_GiaSanPham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_GiaSanPham.Location = new System.Drawing.Point(28, 159);
            this.groupBox_GiaSanPham.Name = "groupBox_GiaSanPham";
            this.groupBox_GiaSanPham.Size = new System.Drawing.Size(215, 80);
            this.groupBox_GiaSanPham.TabIndex = 5;
            this.groupBox_GiaSanPham.TabStop = false;
            this.groupBox_GiaSanPham.Text = "Giá Sản Phẩm";
            // 
            // textBox_GiaSanPham
            // 
            this.textBox_GiaSanPham.BackColor = System.Drawing.Color.White;
            this.textBox_GiaSanPham.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GiaSanPham.ForeColor = System.Drawing.Color.Gray;
            this.textBox_GiaSanPham.Location = new System.Drawing.Point(6, 30);
            this.textBox_GiaSanPham.Name = "textBox_GiaSanPham";
            this.textBox_GiaSanPham.Size = new System.Drawing.Size(203, 32);
            this.textBox_GiaSanPham.TabIndex = 0;
            this.textBox_GiaSanPham.Text = "Thêm Giá Sản Phẩm";
            this.textBox_GiaSanPham.Enter += new System.EventHandler(this.textBox_GiaSanPham_Enter);
            this.textBox_GiaSanPham.Leave += new System.EventHandler(this.textBox_GiaSanPham_Leave);
            // 
            // label_SanPhamMoi
            // 
            this.label_SanPhamMoi.AutoSize = true;
            this.label_SanPhamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_SanPhamMoi.Location = new System.Drawing.Point(135, 17);
            this.label_SanPhamMoi.Name = "label_SanPhamMoi";
            this.label_SanPhamMoi.Size = new System.Drawing.Size(172, 25);
            this.label_SanPhamMoi.TabIndex = 0;
            this.label_SanPhamMoi.Text = "SẢN PHẨM MỚI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 591);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSanPham";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_SoLuong.ResumeLayout(false);
            this.groupBox_SoLuong.PerformLayout();
            this.groupBox_TenSanPham.ResumeLayout(false);
            this.groupBox_TenSanPham.PerformLayout();
            this.groupBox_MaSanPham.ResumeLayout(false);
            this.groupBox_MaSanPham.PerformLayout();
            this.groupBox_LoaiSanPham.ResumeLayout(false);
            this.groupBox_GiaSanPham.ResumeLayout(false);
            this.groupBox_GiaSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ThemSanPham;
        private System.Windows.Forms.GroupBox groupBox_LoaiSanPham;
        private System.Windows.Forms.GroupBox groupBox_GiaSanPham;
        private System.Windows.Forms.TextBox textBox_GiaSanPham;
        private System.Windows.Forms.Label label_SanPhamMoi;
        private System.Windows.Forms.GroupBox groupBox_SoLuong;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.GroupBox groupBox_TenSanPham;
        private System.Windows.Forms.GroupBox groupBox_MaSanPham;
        private System.Windows.Forms.TextBox textBox_MaSanPham;
        private System.Windows.Forms.TextBox textBox_ThongTinSanPham;
        private System.Windows.Forms.Label label_ThongTinSanPham;
        private System.Windows.Forms.ComboBox comboBox_LoaiSanPham;
        private System.Windows.Forms.TextBox textBox_TenSanPham;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}