using BUS;
using DTO;
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
    public partial class QLTaiKhoan : Form
    {
        BUS_TAIKHOAN bUS_TAIKHOAN = new BUS_TAIKHOAN();

        public QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dsTaiKhoan.DataSource = bUS_TAIKHOAN.LoadDSTaiKhoan();
        }

        private void dsTaiKhoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbMaTK.Text = DSToTextBox(dsTaiKhoan, 0);
            tbUsername.Text = DSToTextBox(dsTaiKhoan, 1);
            tbPassword.Text = DSToTextBox(dsTaiKhoan, 2);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            else
            {
                var newTK = new DTO_TAIKHOAN()
                {
                    Username = tbUsername.Text,
                    Password = tbPassword.Text
                };
                if (bUS_TAIKHOAN.ThemTaiKhoan(newTK) == true)
                {
                    LoadData();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                    MessageBox.Show("Thêm không thành công !!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaTK.Text))
                return;
            else
            {
                if (bUS_TAIKHOAN.XoaTaiKhoan(int.Parse(tbMaTK.Text)) == true)
                {
                    LoadData();
                    MessageBox.Show("Xóa thành công !!!");
                }
                else
                    MessageBox.Show("Xóa không thành công !!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaTK.Text))
                return;
            else if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            else
            {
                var newTK = new DTO_TAIKHOAN()
                {
                    MaTK = int.Parse(tbMaTK.Text),
                    Username = tbUsername.Text,
                    Password = tbPassword.Text
                };
                if (bUS_TAIKHOAN.SuaTaiKhoan(newTK) == true)
                {
                    LoadData();
                    MessageBox.Show("Sửa thành công !!!");
                }
                else
                    MessageBox.Show("Sửa không thành công !!!");
            }
        }

        String DSToTextBox(DataGridView x, int index)
        {
            return x.CurrentRow.Cells[index].Value.ToString();
        }
    }
}
