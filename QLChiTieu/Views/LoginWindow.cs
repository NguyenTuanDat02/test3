using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChiTieu.Views
{
    public partial class LoginWindow : Form
    {
        BUS_TAIKHOAN bUS_TAIKHOAN = new BUS_TAIKHOAN();
        public BUS_TAIKHOAN tk { get; set; }

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            else
            {
                if (bUS_TAIKHOAN.TimTaiKhoan(tbUsername.Text, tbPassword.Text) == false)
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng !!!");
                else
                {
                    this.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
