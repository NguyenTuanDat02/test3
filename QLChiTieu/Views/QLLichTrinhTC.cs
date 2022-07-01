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
    public partial class QLLichTrinhTC : Form
    {
        BUS_LICHTRINHTC bUS_LICHTRINHTC = new BUS_LICHTRINHTC();

        public QLLichTrinhTC()
        {
            InitializeComponent();
        }

        private void QLLichTrinhTC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dsLichTrinhTC.DataSource = bUS_LICHTRINHTC.LoadDSLichTrinhTC();
        }

        private void dsLichTrinhTC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbMaTC.Text = DSToTextBox(dsLichTrinhTC, 0);
            tbTenTC.Text = DSToTextBox(dsLichTrinhTC, 1);
            tbSoTien.Text = DSToTextBox(dsLichTrinhTC, 2);
            dpTuNgay.Value = DateTime.Parse(DSToTextBox(dsLichTrinhTC, 3));
            dpDenNgay.Value = DateTime.Parse(DSToTextBox(dsLichTrinhTC, 4));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTenTC.Text) || string.IsNullOrWhiteSpace(tbSoTien.Text))
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            else
            {
                var newLT = new DTO_LICHTRINHTC()
                {
                    TenTC = tbTenTC.Text,
                    SoTien = float.Parse(tbSoTien.Text),
                    TuNgay = dpTuNgay.Value.ToString("yyyy-MM-dd"),
                    DenNgay = dpDenNgay.Value.ToString("yyyy-MM-dd")
                };
                if (bUS_LICHTRINHTC.ThemLichTrinhTC(newLT) == true)
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
            if (string.IsNullOrWhiteSpace(tbMaTC.Text))
                return;
            else
            {
                if (bUS_LICHTRINHTC.XoaLichTrinhTC(int.Parse(tbMaTC.Text)) == true)
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
            if (string.IsNullOrWhiteSpace(tbMaTC.Text))
                return;
            else if (string.IsNullOrWhiteSpace(tbTenTC.Text) || string.IsNullOrWhiteSpace(tbSoTien.Text))
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            else
            {
                var newLT = new DTO_LICHTRINHTC()
                {
                    MaTC = int.Parse(tbMaTC.Text),
                    TenTC = tbTenTC.Text,
                    SoTien = float.Parse(tbSoTien.Text),
                    TuNgay = dpTuNgay.Value.ToString("yyyy-MM-dd"),
                    DenNgay = dpDenNgay.Value.ToString("yyyy-MM-dd")
                };
                if (bUS_LICHTRINHTC.SuaLichTrinhTC(newLT) == true)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var sc = new ThongKeLichTrinhTC();
            sc.ShowDialog();
        }
    }
}
