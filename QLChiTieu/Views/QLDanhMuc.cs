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
    public partial class QLDanhMuc : Form
    {
        BUS_DANHMUC bUS_DANHMUC = new BUS_DANHMUC();

        public QLDanhMuc()
        {
            InitializeComponent();
        }

        private void QLDanhMuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dsDanhMuc.DataSource = bUS_DANHMUC.LoadDSDanhMuc();
        }

        private void dsDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbMaDM.Text = DSToTextBox(dsDanhMuc, 0);
            tbTenDM.Text = DSToTextBox(dsDanhMuc, 1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTenDM.Text))
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            else
            {
                var newDM = new DTO_DANHMUC()
                {
                    TenDM = tbTenDM.Text
                };
                if (bUS_DANHMUC.ThemDanhMuc(newDM) == true)
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
            if (string.IsNullOrWhiteSpace(tbMaDM.Text))
                return;
            else
            {
                if (bUS_DANHMUC.XoaDanhMuc(int.Parse(tbMaDM.Text)) == true)
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
            if (string.IsNullOrWhiteSpace(tbMaDM.Text))
                return;
            else if (string.IsNullOrWhiteSpace(tbTenDM.Text))
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            else
            {
                var newDM = new DTO_DANHMUC()
                {
                    MaDM = int.Parse(tbMaDM.Text),
                    TenDM = tbTenDM.Text
                };
                if (bUS_DANHMUC.SuaDanhMuc(newDM) == true)
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
