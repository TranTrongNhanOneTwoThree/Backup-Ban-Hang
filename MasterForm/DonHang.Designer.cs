namespace MasterForm
{
    partial class DonHang
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
            this.groupBox_DonHang = new System.Windows.Forms.GroupBox();
            this.button_Tao = new System.Windows.Forms.Button();
            this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
            this.textBox_TìmKiem = new System.Windows.Forms.TextBox();
            this.comboBox_TimKiem = new System.Windows.Forms.ComboBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_DonHang.SuspendLayout();
            this.groupBox_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DonHang
            // 
            this.groupBox_DonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_DonHang.Controls.Add(this.button_Tao);
            this.groupBox_DonHang.Controls.Add(this.groupBox_TimKiem);
            this.groupBox_DonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_DonHang.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DonHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox_DonHang.Location = new System.Drawing.Point(0, 0);
            this.groupBox_DonHang.Name = "groupBox_DonHang";
            this.groupBox_DonHang.Size = new System.Drawing.Size(1023, 664);
            this.groupBox_DonHang.TabIndex = 1;
            this.groupBox_DonHang.TabStop = false;
            this.groupBox_DonHang.Text = "ĐƠN HÀNG";
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
            // groupBox_TimKiem
            // 
            this.groupBox_TimKiem.Controls.Add(this.textBox_TìmKiem);
            this.groupBox_TimKiem.Controls.Add(this.comboBox_TimKiem);
            this.groupBox_TimKiem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_TimKiem.Location = new System.Drawing.Point(12, 64);
            this.groupBox_TimKiem.Name = "groupBox_TimKiem";
            this.groupBox_TimKiem.Size = new System.Drawing.Size(555, 83);
            this.groupBox_TimKiem.TabIndex = 0;
            this.groupBox_TimKiem.TabStop = false;
            this.groupBox_TimKiem.Text = "Tìm Kiếm";
            // 
            // textBox_TìmKiem
            // 
            this.textBox_TìmKiem.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TìmKiem.ForeColor = System.Drawing.Color.Gray;
            this.textBox_TìmKiem.Location = new System.Drawing.Point(206, 26);
            this.textBox_TìmKiem.Name = "textBox_TìmKiem";
            this.textBox_TìmKiem.Size = new System.Drawing.Size(327, 38);
            this.textBox_TìmKiem.TabIndex = 1;
            this.textBox_TìmKiem.Text = "Tìm Kiếm";
            this.textBox_TìmKiem.Enter += new System.EventHandler(this.textBox_TìmKiem_Enter);
            this.textBox_TìmKiem.Leave += new System.EventHandler(this.textBox_TìmKiem_Leave);
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
            // DonHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox_DonHang);
            this.Name = "DonHang";
            this.Size = new System.Drawing.Size(1023, 664);
            this.groupBox_DonHang.ResumeLayout(false);
            this.groupBox_TimKiem.ResumeLayout(false);
            this.groupBox_TimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DonHang;
        private System.Windows.Forms.Button button_Tao;
        private System.Windows.Forms.GroupBox groupBox_TimKiem;
        private System.Windows.Forms.TextBox textBox_TìmKiem;
        private System.Windows.Forms.ComboBox comboBox_TimKiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
