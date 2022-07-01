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
    public partial class QLKhoanChi : Form
    {
        BUS_KHOANCHI bUS_KHOANCHI = new BUS_KHOANCHI();
        BUS_DANHMUC bUS_DANHMUC = new BUS_DANHMUC();

        public QLKhoanChi()
        {
            InitializeComponent();
        }

        private void QLKhoanChi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dsKhoanChi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbMaChi.Text = DSToTextBox(dsKhoanChi, 0);
            tbTenChi.Text = DSToTextBox(dsKhoanChi, 1);
            int Selected = -1;
            int count = cbDanhMuc.Items.Count;
            for (int i = 0; (i <= (count - 1)); i++)
            {
                cbDanhMuc.SelectedIndex = i;
                if ((string)(cbDanhMuc.SelectedValue.ToString()) == DSToTextBox(dsKhoanChi, 4).ToString())
                {
                    Selected = i;
                    break;
                }

            }
            cbDanhMuc.SelectedIndex = Selected;
            tbSoTien.Text = DSToTextBox(dsKhoanChi, 2);
            dpNgayChi.Value = DateTime.Parse(DSToTextBox(dsKhoanChi, 3));
        }

        private void LoadData()
        {
            dsKhoanChi.DataSource = bUS_KHOANCHI.LoadDSKhoanChi();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTenChi.Text) || string.IsNullOrWhiteSpace(tbSoTien.Text))
                MessageBox.Show("Chưa nhập đủ dữ liệu !!!");
            else
            {
                var selectedDM = cbDanhMuc.SelectedItem as DTO_DANHMUC;
                var newKC = new DTO_KHOANCHI()
                {
                    TenChi = tbTenChi.Text,
                    SoTien = float.Parse(tbSoTien.Text),
                    NgayChi = dpNgayChi.Value.ToString("yyyy-MM-dd"),
                    DanhMuc = selectedDM.MaDM
                };
                if (bUS_KHOANCHI.ThemKhoanChi(newKC) == true)
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
            if (string.IsNullOrWhiteSpace(tbMaChi.Text))
                return;
            else
            {
                if (bUS_KHOANCHI.XoaKhoanChi(int.Parse(tbMaChi.Text)) == true)
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
            if (string.IsNullOrWhiteSpace(tbMaChi.Text))
                return;
            else if (string.IsNullOrWhiteSpace(tbTenChi.Text) || string.IsNullOrWhiteSpace(tbSoTien.Text))
                MessageBox.Show("Chưa nhập đủ dữ liệu !!!");
            else
            {
                var selectedDM = cbDanhMuc.SelectedItem as DTO_DANHMUC;
                var newKC = new DTO_KHOANCHI()
                {
                    MaChi = int.Parse(tbMaChi.Text),
                    TenChi = tbTenChi.Text,
                    SoTien = int.Parse(tbSoTien.Text),
                    NgayChi = dpNgayChi.Value.ToString("yyyy-MM-dd"),
                    DanhMuc = selectedDM.MaDM
                };
                if (bUS_KHOANCHI.SuaKhoanChi(newKC) == true)
                {
                    LoadData();
                    MessageBox.Show("Sửa thành công !!!");
                }
                else
                    MessageBox.Show("Sửa không thành công !!!");
            }
        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            var sc = new ThongKeKhoanChi();
            sc.ShowDialog();
        }
    }
}
