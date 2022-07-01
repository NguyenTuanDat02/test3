using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LICHTRINHTC : ThuVien
    {
        public DataView LoadDSLichTrinhTC()
        {
            string sql = "select * from LICHTRINHTC";
            return reDataSet(sql).Tables[0].DefaultView;
        }

        public bool ThemLichTrinhTC(DTO_LICHTRINHTC lt)
        {
            string sql = "Insert into LICHTRINHTC Values(N'" + lt.TenTC + "', N'" + lt.SoTien + "', N'" + lt.TuNgay + "', N'" + lt.DenNgay + "')";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool XoaLichTrinhTC(int id)
        {
            string sql = "Delete From LICHTRINHTC Where MaTC=N'" + id + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool SuaLichTrinhTC(DTO_LICHTRINHTC lt)
        {
            string sql = "Update LICHTRINHTC Set TenTC=N'" + lt.TenTC + "', SoTien=N'" + lt.SoTien + "', TuNgay=N'" + lt.TuNgay + "', DenNgay=N'" + lt.DenNgay + "' Where MaTC =N'" + lt.MaTC + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }
    }
}
