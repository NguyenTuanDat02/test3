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
    public partial class QLKhoanThu : Form
    {
        BUS_KHOANTHU bUS_KHOANTHU = new BUS_KHOANTHU();
        BUS_DANHMUC bUS_DANHMUC = new BUS_DANHMUC();

        public QLKhoanThu()
        {
            InitializeComponent();
        }

        private void QLKhoanThu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dsKhoanThu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbMaThu.Text = DSToTextBox(dsKhoanThu, 0);
            tbTenThu.Text = DSToTextBox(dsKhoanThu, 1);
            int Selected = -1;
            int count = cbDanhMuc.Items.Count;
            for (int i = 0; (i <= (count - 1)); i++)
            {
                cbDanhMuc.SelectedIndex = i;
                if ((string)(cbDanhMuc.SelectedValue.ToString()) == DSToTextBox(dsKhoanThu, 4).ToString())
                {
                    Selected = i;
                    break;
                }

            }
            cbDanhMuc.SelectedIndex = Selected;
            tbSoTien.Text = DSToTextBox(dsKhoanThu, 2);
            dpNgayThu.Value = DateTime.Parse(DSToTextBox(dsKhoanThu, 3));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTenThu.Text) || string.IsNullOrWhiteSpace(tbSoTien.Text))
                MessageBox.Show("Chưa nhập đủ dữ liệu !!!");
            else
            {
                var selectedDM = cbDanhMuc.SelectedItem as DTO_DANHMUC;
                var newKC = new DTO_KHOANTHU()
                {
                    TenThu = tbTenThu.Text,
                    SoTien = float.Parse(tbSoTien.Text),
                    NgayThu = dpNgayThu.Value.ToString("yyyy-MM-dd"),
                    DanhMuc = selectedDM.MaDM
                };
                if (bUS_KHOANTHU.ThemKhoanThu(newKC) == true)
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
            if (string.IsNullOrWhiteSpace(tbMaThu.Text))
                return;
            else
            {
                if (bUS_KHOANTHU.XoaKhoanThu(int.Parse(tbMaThu.Text)) == true)
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
            if (string.IsNullOrWhiteSpace(tbMaThu.Text))
                return;
            else if (string.IsNullOrWhiteSpace(tbTenThu.Text) || string.IsNullOrWhiteSpace(tbSoTien.Text))
                MessageBox.Show("Chưa nhập đủ dữ liệu !!!");
            else
            {
                var selectedDM = cbDanhMuc.SelectedItem as DTO_DANHMUC;
                var newKC = new DTO_KHOANTHU()
                {
                    MaThu = int.Parse(tbMaThu.Text),
                    TenThu = tbTenThu.Text,
                    SoTien = float.Parse(tbSoTien.Text),
                    NgayThu = dpNgayThu.Value.ToString("yyyy-MM-dd"),
                    DanhMuc = selectedDM.MaDM
                };
                if (bUS_KHOANTHU.SuaKhoanThu(newKC) == true)
                {
                    LoadData();
                    MessageBox.Show("Sửa thành công !!!");
                }
                else
                    MessageBox.Show("Sửa không thành công !!!");
            }
        }

        private void LoadData()
        {
            dsKhoanThu.DataSource = bUS_KHOANTHU.LoadDSKhoanThu();
            List<DTO_DANHMUC> danhmucs = (from DataRow dr in bUS_DANHMUC.LoadDSDanhMuc().ToTable().Rows
                                          select new DTO_DANHMUC()
                                          {
                                              MaDM = int.Parse(dr["MaDM"].ToString()),
                                              TenDM = dr["TenDM"].ToString()
                                          }).ToList();
            cbDanhMuc.DataSource = danhmucs.ToList();
            if (danhmucs.ToList().Count > 0)
                cbDanhMuc.SelectedIndex = 0;
        }

        String DSToTextBox(DataGridView x, int index)
        {
            return x.CurrentRow.Cells[index].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sc = new ThongKeKhoanThu();
            sc.ShowDialog();
        }
    }
}
