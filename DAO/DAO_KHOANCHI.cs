using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_KHOANCHI : ThuVien
    {
        public DataView LoadDSKhoanChi()
        {
            string sql = "select * from KHOANCHI";
            return reDataSet(sql).Tables[0].DefaultView;
        }

        public bool ThemKhoanChi(DTO_KHOANCHI kc)
        {
            string sql = "Insert into KHOANCHI Values(N'" + kc.TenChi + "', N'" + kc.SoTien + "', N'" + kc.NgayChi + "', N'" + kc.DanhMuc + "')";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool XoaKhoanChi(int id)
        {
            string sql = "Delete From KHOANCHI Where MaChi=N'" + id + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool SuaKhoanChi(DTO_KHOANCHI kc)
        {
            string sql = "Update KHOANCHI Set TenChi=N'" + kc.TenChi + "', SoTien=N'" + kc.SoTien + "', NgayChi=N'" + kc.NgayChi + "', DanhMuc=N'" + kc.DanhMuc + "' Where MaChi =N'" + kc.MaChi + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }
    }
}
