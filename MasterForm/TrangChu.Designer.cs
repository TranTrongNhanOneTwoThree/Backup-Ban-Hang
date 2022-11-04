namespace MasterForm
{
    partial class TrangChu
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
            this.pictureTrangChu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrangChu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureTrangChu
            // 
            this.pictureTrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureTrangChu.Image = global::MasterForm.Properties.Resources.Ảnh_Nền;
            this.pictureTrangChu.Location = new System.Drawing.Point(0, 0);
            this.pictureTrangChu.Name = "pictureTrangChu";
            this.pictureTrangChu.Size = new System.Drawing.Size(1023, 664);
            this.pictureTrangChu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTrangChu.TabIndex = 1;
            this.pictureTrangChu.TabStop = false;
            // 
            // TrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.pictureTrangChu);
            this.Name = "TrangChu";
            this.Size = new System.Drawing.Size(1023, 664);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrangChu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureTrangChu;
    }
}
