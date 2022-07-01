
namespace QLChiTieu
{
    partial class MainWindow
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnQLKhoanThu = new System.Windows.Forms.ToolStripLabel();
            this.btnQLKhoanChi = new System.Windows.Forms.ToolStripLabel();
            this.btnQLLichTrinhTC = new System.Windows.Forms.ToolStripLabel();
            this.btnQLDanhMuc = new System.Windows.Forms.ToolStripLabel();
            this.btnQLTaiKhoan = new System.Windows.Forms.ToolStripLabel();
            this.btnDangXuat = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLKhoanThu,
            this.btnQLKhoanChi,
            this.btnQLLichTrinhTC,
            this.btnQLDanhMuc,
            this.btnQLTaiKhoan,
            this.btnDangXuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnQLKhoanThu
            // 
            this.btnQLKhoanThu.Name = "btnQLKhoanThu";
            this.btnQLKhoanThu.Size = new System.Drawing.Size(101, 22);
            this.btnQLKhoanThu.Text = "QL Khoản Thu";
            this.btnQLKhoanThu.Click += new System.EventHandler(this.btnQLKhoanThu_Click);
            // 
            // btnQLKhoanChi
            // 
            this.btnQLKhoanChi.Name = "btnQLKhoanChi";
            this.btnQLKhoanChi.Size = new System.Drawing.Size(98, 22);
            this.btnQLKhoanChi.Text = "QL Khoản Chi";
            this.btnQLKhoanChi.Click += new System.EventHandler(this.btnQLKhoanChi_Click);
            // 
            // btnQLLichTrinhTC
            // 
            this.btnQLLichTrinhTC.Name = "btnQLLichTrinhTC";
            this.btnQLLichTrinhTC.Size = new System.Drawing.Size(113, 22);
            this.btnQLLichTrinhTC.Text = "QL Lịch Trình TC";
            this.btnQLLichTrinhTC.Click += new System.EventHandler(this.btnQLLichTrinhTC_Click);
            // 
            // btnQLDanhMuc
            // 
            this.btnQLDanhMuc.Name = "btnQLDanhMuc";
            this.btnQLDanhMuc.Size = new System.Drawing.Size(98, 22);
            this.btnQLDanhMuc.Text = "QL Danh Mục";
            this.btnQLDanhMuc.Click += new System.EventHandler(this.btnQLDanhMuc_Click);
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(95, 22);
            this.btnQLTaiKhoan.Text = "QL Tài Khoản";
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(79, 22);
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLChiTieu.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý ChiTiêu";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnQLKhoanChi;
        private System.Windows.Forms.ToolStripLabel btnQLLichTrinhTC;
        private System.Windows.Forms.ToolStripLabel btnQLDanhMuc;
        private System.Windows.Forms.ToolStripLabel btnQLTaiKhoan;
        private System.Windows.Forms.ToolStripLabel btnDangXuat;
        private System.Windows.Forms.ToolStripLabel btnQLKhoanThu;
    }
}

