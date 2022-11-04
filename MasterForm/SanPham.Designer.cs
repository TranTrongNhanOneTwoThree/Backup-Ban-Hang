namespace MasterForm
{
    partial class SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_SanPham = new System.Windows.Forms.GroupBox();
            this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
            this.comboBox_TimKiem = new System.Windows.Forms.ComboBox();
            this.textBox_TìmKiem = new System.Windows.Forms.TextBox();
            this.button_Tao = new System.Windows.Forms.Button();
            this.groupBox_BoLoc = new System.Windows.Forms.GroupBox();
            this.comboBox_BoLoc = new System.Windows.Forms.ComboBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_SanPham.SuspendLayout();
            this.groupBox_TimKiem.SuspendLayout();
            this.groupBox_BoLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_SanPham
            // 
            this.groupBox_SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_SanPham.Controls.Add(this.groupBox_TimKiem);
            this.groupBox_SanPham.Controls.Add(this.textBox_TìmKiem);
            this.groupBox_SanPham.Controls.Add(this.button_Tao);
            this.groupBox_SanPham.Controls.Add(this.groupBox_BoLoc);
            this.groupBox_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SanPham.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SanPham.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox_SanPham.Location = new System.Drawing.Point(0, 0);
            this.groupBox_SanPham.Name = "groupBox_SanPham";
            this.groupBox_SanPham.Size = new System.Drawing.Size(1023, 664);
            this.groupBox_SanPham.TabIndex = 2;
            this.groupBox_SanPham.TabStop = false;
            this.groupBox_SanPham.Text = "SẢN PHẨM";
            // 
            // groupBox_TimKiem
            // 
            this.groupBox_TimKiem.Controls.Add(this.comboBox_TimKiem);
            this.groupBox_TimKiem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_TimKiem.Location = new System.Drawing.Point(222, 64);
            this.groupBox_TimKiem.Name = "groupBox_TimKiem";
            this.groupBox_TimKiem.Size = new System.Drawing.Size(212, 83);
            this.groupBox_TimKiem.TabIndex = 2;
            this.groupBox_TimKiem.TabStop = false;
            this.groupBox_TimKiem.Text = "Tìm Kiếm";
            // 
            // comboBox_TimKiem
            // 
            this.comboBox_TimKiem.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TimKiem.FormattingEnabled = true;
            this.comboBox_TimKiem.Location = new System.Drawing.Point(6, 27);
            this.comboBox_TimKiem.Name = "comboBox_TimKiem";
            this.comboBox_TimKiem.Size = new System.Drawing.Size(167, 37);
            this.comboBox_TimKiem.TabIndex = 0;
            // 
            // textBox_TìmKiem
            // 
            this.textBox_TìmKiem.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TìmKiem.ForeColor = System.Drawing.Color.Gray;
            this.textBox_TìmKiem.Location = new System.Drawing.Point(457, 90);
            this.textBox_TìmKiem.Name = "textBox_TìmKiem";
            this.textBox_TìmKiem.Size = new System.Drawing.Size(327, 38);
            this.textBox_TìmKiem.TabIndex = 1;
            this.textBox_TìmKiem.Text = "Tìm Kiếm";
            this.textBox_TìmKiem.TextChanged += new System.EventHandler(this.textBox_TìmKiem_TextChanged);
            this.textBox_TìmKiem.Enter += new System.EventHandler(this.textBox_TìmKiem_Enter);
            this.textBox_TìmKiem.Leave += new System.EventHandler(this.textBox_TìmKiem_Leave);
            // 
            // button_Tao
            // 
            this.button_Tao.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Tao.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tao.ForeColor = System.Drawing.Color.White;
            this.button_Tao.Location = new System.Drawing.Point(850, 90);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(135, 38);
            this.button_Tao.TabIndex = 1;
            this.button_Tao.Text = "TẠO";
            this.button_Tao.UseVisualStyleBackColor = false;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // groupBox_BoLoc
            // 
            this.groupBox_BoLoc.Controls.Add(this.comboBox_BoLoc);
            this.groupBox_BoLoc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_BoLoc.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_BoLoc.Location = new System.Drawing.Point(12, 64);
            this.groupBox_BoLoc.Name = "groupBox_BoLoc";
            this.groupBox_BoLoc.Size = new System.Drawing.Size(190, 83);
            this.groupBox_BoLoc.TabIndex = 0;
            this.groupBox_BoLoc.TabStop = false;
            this.groupBox_BoLoc.Text = "Bộ Lọc";
            // 
            // comboBox_BoLoc
            // 
            this.comboBox_BoLoc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BoLoc.FormattingEnabled = true;
            this.comboBox_BoLoc.Location = new System.Drawing.Point(6, 27);
            this.comboBox_BoLoc.Name = "comboBox_BoLoc";
            this.comboBox_BoLoc.Size = new System.Drawing.Size(167, 37);
            this.comboBox_BoLoc.TabIndex = 0;
            // 
            // SanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox_SanPham);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(1023, 664);
            this.groupBox_SanPham.ResumeLayout(false);
            this.groupBox_SanPham.PerformLayout();
            this.groupBox_TimKiem.ResumeLayout(false);
            this.groupBox_BoLoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SanPham;
        private System.Windows.Forms.GroupBox groupBox_TimKiem;
        private System.Windows.Forms.ComboBox comboBox_TimKiem;
        private System.Windows.Forms.TextBox textBox_TìmKiem;
        private System.Windows.Forms.Button button_Tao;
        private System.Windows.Forms.GroupBox groupBox_BoLoc;
        private System.Windows.Forms.ComboBox comboBox_BoLoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
    }
}
