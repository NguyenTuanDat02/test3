using QLChiTieu.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChiTieu
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnQLKhoanThu_Click(object sender, EventArgs e)
        {
            var sc = new QLKhoanThu();
            sc.ShowDialog();
        }

        private void btnQLKhoanChi_Click(object sender, EventArgs e)
        {
            var sc = new QLKhoanChi();
            sc.ShowDialog();
        }

        private void btnQLLichTrinhTC_Click(object sender, EventArgs e)
        {
            var sc = new QLLichTrinhTC();
            sc.ShowDialog();
        }

        private void btnQLDanhMuc_Click(object sender, EventArgs e)
        {
            var sc = new QLDanhMuc();
            sc.ShowDialog();
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            var sc = new QLTaiKhoan();
            sc.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var sc = new LoginWindow();
            sc.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Show();
            var sc = new LoginWindow();
            sc.ShowDialog();
        }
    }
}
