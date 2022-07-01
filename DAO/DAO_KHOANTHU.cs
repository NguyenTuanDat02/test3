using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_KHOANTHU : ThuVien
    {
        public DataView LoadDSKhoanThu()
        {
            string sql = "select * from KHOANTHU";
            return reDataSet(sql).Tables[0].DefaultView;
        }

        public bool ThemKhoanThu(DTO_KHOANTHU kt)
        {
            string sql = "Insert into KHOANTHU Values(N'" + kt.TenThu + "', N'" + kt.SoTien + "', N'" + kt.NgayThu + "', N'" + kt.DanhMuc + "')";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool XoaKhoanThu(int id)
        {
            string sql = "Delete From KHOANTHU Where MaThu=N'" + id + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool SuaKhoanThu(DTO_KHOANTHU kt)
        {
            string sql = "Update KHOANTHU Set TenThu=N'" + kt.TenThu + "', SoTien=N'" + kt.SoTien + "', NgayThu=N'" + kt.NgayThu + "', DanhMuc=N'" + kt.DanhMuc + "' Where MaThu =N'" + kt.MaThu + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }
    }
}
